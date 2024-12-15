using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLayGame
{
   
    public partial class IPs : Form
    {
        public int RoomsNumber;
        public int numberPLayers = 0;
        public string roomName;
        public bool isHost = true;
        private Socket sock;
        private BackgroundWorker MessageReceiver = new BackgroundWorker();
        private TcpListener server = null, serverbtn = null;
        private TcpClient client, clientbtn;
        List<Socket> connectedClients = new List<Socket>(); // Danh sách các client kết nối

        public IPs()
        {
            InitializeComponent();
           
        }

        

    public void IPs_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            MultiplePLayers newGame = new MultiplePLayers(false, txtbip.Text);
            Visible = false;
            if (!newGame.IsDisposed) 
                newGame.ShowDialog();
            Visible = true;
        }

        private void btnHost_Click(object sender, EventArgs e)
        {
            MultiplePLayers newGame = new MultiplePLayers(true, txtbip.Text);
            Visible = false;
            if (!newGame.IsDisposed) newGame.ShowDialog();
            Visible = true;

        }
    }
}
