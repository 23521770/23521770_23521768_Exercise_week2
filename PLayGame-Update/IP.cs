using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLayGame
{
    public partial class IP : Form
    {
        private Socket sock;
        private BackgroundWorker MessageReceiver = new BackgroundWorker();
        private TcpListener server = null;
        private TcpClient client;
        public IP()
        {
            InitializeComponent();
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            client = new TcpClient("127.0.0.1", 8088);
            sock = client.Client;
            MessageReceiver.RunWorkerAsync();


            // Kết hợp "start" và tên phòng vào một chuỗi, cách nhau bởi dấu phẩy hoặc dấu cách
            string message = $"start,{txtbRoomName.Text}";

            // Chuyển chuỗi thành mảng byte và gửi qua socket
            sock.Send(Encoding.UTF8.GetBytes(message));
            
            Hide();
           
        }


        private void IP_Load(object sender, EventArgs e)
        {

        }

        private void IP_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kết hợp "start" và tên phòng vào một chuỗi, cách nhau bởi dấu phẩy hoặc dấu cách
            string message = $"end,{txtbRoomName.Text}";

            // Chuyển chuỗi thành mảng byte và gửi qua socket
            sock.Send(Encoding.UTF8.GetBytes(message));
            
        }
    }
}
