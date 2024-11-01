using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__TCP_Private_Chat___Filesharing_with_AsyncCallback
{
    public partial class Form1 : Form
    {

        private Server server;
        private Client client;

        public Form1()
        {
            InitializeComponent();
            server = new Server("127.0.0.1", 5000);
            server.OnMessageReceived += Server_OnMessageReceived;
            server.OnFileReceived += Server_OnFileReceived;
            _ = server.StartAsync();
        }

        private void Server_OnMessageReceived(string message)
        {
            Invoke(new Action(() =>
            {
                txtChat.AppendText("Friend: " + message + Environment.NewLine);
            }));
        }

        private void Server_OnFileReceived(string filePath)
        {
            Invoke(new Action(() =>
            {
                txtChat.AppendText("File received: " + filePath + Environment.NewLine);
            }));
        }

        private async void ConnectButton_Click(object sender, EventArgs e)
        {
            client = new Client("127.0.0.1", 5000);
            txtChat.AppendText("Connected to server." + Environment.NewLine);
        }

        private async void SendButton_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text;
            await client.SendMessageAsync(message);
            txtChat.AppendText("Me: " + message + Environment.NewLine);
            txtMessage.Clear();
        }

        private async void SendFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                await client.SendFileAsync(filePath);
                txtChat.AppendText("File sent: " + filePath + Environment.NewLine);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            server.Stop();
            client?.Close();
        }
    }

}


