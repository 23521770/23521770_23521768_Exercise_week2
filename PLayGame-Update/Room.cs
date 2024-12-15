using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PLayGame
{
    public partial class Room : Form
    {
        public int RoomsNumber;
        public int numberPLayers=0 ;
        public string roomName;
        public bool isHost=true;
        private Socket sock;
        private BackgroundWorker MessageReceiver = new BackgroundWorker();
        private TcpListener server = null,serverbtn=null;
        private TcpClient client, clientbtn;
        List<Socket> connectedClients = new List<Socket>(); // Danh sách các client kết nối

        public Room(bool isHost)
        {
            
            InitializeComponent();
            DrawBoard();
            MessageReceiver.DoWork += MessageReceiver_DoWork;
            CheckForIllegalCrossThreadCalls = false;

            if (isHost)
            {
                CheckForIllegalCrossThreadCalls = false;
                server = new TcpListener(IPAddress.Parse("127.0.0.1"), 8088);
                server.Start();
                AcceptClients();
                MessageReceiver.DoWork += MessageReceiver_DoWork;

            }
            else
            {
                client = new TcpClient("127.0.0.1",8088 );
                sock = client.Client;
                MessageReceiver.RunWorkerAsync();

            }


        }

        private void AcceptClients()
        {
            Thread listenThread = new Thread(new ThreadStart(() =>
            {
                while (true)
                {
                    try
                    {
                        // Chờ client kết nối
                        Socket clientSocket = server.AcceptSocket();
                        connectedClients.Add(clientSocket); // Lưu kết nối client
                        numberPLayers++;

                        // Xử lý client kết nối
                        HandleClientConnection(clientSocket);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi chấp nhận kết nối: {ex.Message}");
                    }
                }
            }));
            listenThread.IsBackground = true;
            listenThread.Start();
        }


        private void HandleClientConnection(Socket clientSocket)
        {
            // Tạo một BackgroundWorker để xử lý giao tiếp với client
            BackgroundWorker clientWorker = new BackgroundWorker();
            clientWorker.DoWork += (sender, e) =>
            {
                while (true)
                {
                    try
                    {
                        // Nhận dữ liệu từ client
                        byte[] buffer = new byte[1024];
                        int received = clientSocket.Receive(buffer);
                        if (received > 0)
                        {
                            string data = Encoding.UTF8.GetString(buffer, 0, received);
                            ReceiveMove(data);

                            // Gửi lại dữ liệu cho tất cả các client kết nối
                            BroadcastToClients(data, clientSocket); // Tránh gửi lại cho chính client gửi dữ liệu
                        }
                    }
                    catch (Exception ex)
                    {
                        // Client ngắt kết nối hoặc gặp lỗi
                        connectedClients.Remove(clientSocket); // Xóa client khỏi danh sách
                        numberPLayers--;
                        MessageBox.Show($"Client ngắt kết nối: {ex.Message}");
                        break;
                    }
                }
            };

            clientWorker.RunWorkerAsync();
        }

        private void BroadcastToClients(string data, Socket senderSocket)
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);

            foreach (Socket client in connectedClients)
            {
                if (client != senderSocket)
                {

                    try
                    {
                        client.Send(dataBytes);  // Gửi dữ liệu tới client

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi gửi dữ liệu cho client: {ex.Message}");
                    }
                }
            }

        }


        private void MessageReceiver_DoWork(object sender, DoWorkEventArgs e)
        {
            while (!MessageReceiver.CancellationPending)
            {
                try
                {
                    // Nhận dữ liệu từ server
                    byte[] buffer = new byte[1024];
                    int received = sock.Receive(buffer);
                    if (received > 0)
                    {
                        string data = Encoding.UTF8.GetString(buffer, 0, received);
                        ReceiveMove(data);  // Cập nhật giao diện khi nhận dữ liệu
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi nhận dữ liệu: {ex.Message}");
                    break;  // Ngừng nhận dữ liệu khi có lỗi
                }
            }
        }
        private void ReceiveMove(string data)
        {
            string[] parts = data.Split(',');

            if (parts.Length == 2)
            {
                string status = parts[0];     // Phần đầu tiên (ví dụ: trạng thái)
                string roomName = parts[1];   // Phần thứ hai (tên phòng)

                  if (status == "start")
                  { 


                    // Nếu tên phòng chưa trùng, tiến hành thay đổi tính chất của nút
                    foreach (Control control in pnlRoom.Controls)
                    {
                        if (control is Button btn && btn.Tag.ToString() == "available")
                        {
                            btn.BackColor = Color.LightBlue;  // Đổi màu nền thành màu xanh
                            btn.Text = $"Phòng {roomName}";
                            btn.Tag = "unavailable";  // Đảm bảo nút được kích hoạt và không còn "available"
                            break;  // Dừng vòng lặp khi đã tìm và thay đổi một nút
                        }
                        
                    }
                  }   
                  else if (status == "update")
                {
                    foreach (Control control in pnlRoom.Controls)
                    {
                        if (control is Button btn && btn.Tag.ToString() == "available")
                        {
                            btn.BackColor = Color.LightBlue;  // Đổi màu nền thành màu xanh
                            btn.Text = $"Phòng {roomName}{Environment.NewLine}Số lượng người chơi trong phòng: {numberPLayers}";
                            btn.Tag = "unavailable";  // Đảm bảo nút được kích hoạt và không còn "available"
                            break;  // Dừng vòng lặp khi đã tìm và thay đổi một nút
                        }

                    }
                }
                
                else if (status == "end")
                {
                    // Khi trạng thái là "end", khôi phục lại nút
                    foreach (Control control in pnlRoom.Controls)
                    {
                        if (control is Button btn && btn.Tag.ToString() == "unavailable" )
                        {
                            btn.Tag = "available";
                            btn.BackColor = Color.White;
                            btn.Text = "";
                        }
                    }
                }

            }
        }

        private void DrawBoard()
        {
            Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) };
            IP ip = new IP();

            for (int i = 0; i <= Cons.ROOM_BOARD_HEIGHT; i++)
            {

                for (int j = 1; j <= Cons.ROOM_BOARD_WIDTH; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Cons.ROOM_WIDTH,
                        Height = Cons.ROOM_HEIGHT,
                        Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y),
                        Margin = new Padding(10),
                        BackColor = Color.White,
                        Text = "",
                        Tag = "available",
                    };
                    btn.Click += btn_Click;
                    
                    pnlRoom.Controls.Add(btn);
                    oldButton = btn;
                }
                oldButton.Location = new Point(0, oldButton.Location.Y + Cons.ROOM_HEIGHT);
                oldButton.Width = 0;
                oldButton.Height = 0;
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn= sender as Button;
            if ((string)btn.Tag == "unavailable")
            {
                IPs ips = new IPs();
                ips.Show();

            }
            else
            {
                MessageBox.Show("Bạn chưa tạo phòng. Vui lòng nhấn vào nút tạo phòng.");
                return;
            }
            
        }


        private void pnlRoom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Room_Load(object sender, EventArgs e)
        {

        }

        private void Room_FormClosing(object sender, FormClosingEventArgs e)
        {
            server?.Stop();
            foreach (Socket client in connectedClients)
            {
                client.Close();
            }
        }

        private void btnCreateRoom_Click_1(object sender, EventArgs e)
        {
            IP ip = new IP();
            ip.Show();

        }

    }
}
