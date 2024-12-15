using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLayGame
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Connect();
        }

        private void Server_Form1Closed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            foreach(Socket item in clientlist)
            {
                Send(item);
            }
            AddMessage(txbMessage.Text);
            txbMessage.Clear();
        }

        IPEndPoint IP;
        Socket server;
        List<Socket> clientlist;

        void Connect()
        {
            clientlist = new List<Socket>();
            IP = new IPEndPoint(IPAddress.Any, 9999);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            server.Bind(IP);

            Thread Listen = new Thread(() =>
            {
                try
                {
                    while (true)
                    {
                        server.Listen(100);
                        Socket client = server.Accept();
                        clientlist.Add(client);


                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    IP = new IPEndPoint(IPAddress.Any, 9999);
                    server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                }
            });

            Listen.IsBackground = true;
            Listen.Start();
        }

        void Close()
        {
            server.Close();
        }

        void Send(Socket client)
        {
            if (txbMessage.Text != string.Empty)
                client.Send(Serialize(txbMessage.Text));
        }

        void Receive(object obj)
        {
            Socket client = obj as Socket;
            try
            {
                while (true)
                {
                    byte[] data = new byte[1024 * 5000];
                    client.Receive(data);
                    string message = (string)Deserialize(data);
                    foreach(Socket item in clientlist)
                    {
                        if(item != null && item != client)
                        item.Send(Serialize(message));
                    }
                    AddMessage(message);
                }
            }
            catch
            {
                clientlist.Remove(client);
                client.Close();
            }
        }

        void AddMessage(string s)
        {
            lsvMessage.Items.Add(new ListViewItem() { Text = s });
        }

        byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(stream, obj);
            return stream.ToArray();
        }

        object Deserialize(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            BinaryFormatter formatter = new BinaryFormatter();

            return formatter.Deserialize(stream);
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }

    }
}
