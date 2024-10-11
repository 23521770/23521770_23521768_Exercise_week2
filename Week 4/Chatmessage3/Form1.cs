using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatmessage3
{
    public partial class server : Form
    {
        public server()
        {
            InitializeComponent();
        }

         SimpleTcpServer Server;
        private void Form1_Load(object sender, EventArgs e)
        {
            Server = new SimpleTcpServer();
            Server.Delimiter = 0x13;
            Server.DataReceived += Server_DataReceived;

        }
        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
             txtStatus.Invoke((MethodInvoker)delegate ()
            {
                txtStatus.Text += e.MessageString+ Environment.NewLine;
                e.ReplyLine(string.Format(e.MessageString));
            });
        }
        

        private void btnStart_Click(object sender, EventArgs e)
        {
            txtStatus.Text += "Server starting..";
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(txtHost.Text);
            Server.Start(ip, Convert.ToInt32(txtPort.Text));
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (Server.IsStarted) Server.Stop();
        }

        private void txtHost_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
