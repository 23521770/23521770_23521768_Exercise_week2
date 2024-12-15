using GuessTheWordGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PLayGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1nc_Click(object sender, EventArgs e)
        {
            OnePlayer onePlayer = new OnePlayer();
            onePlayer.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMultipleplayer_Click(object sender, EventArgs e)
        {
            HostOrNot ok = new HostOrNot();
            ok.Show();
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            Instruction instruction = new Instruction();
            instruction.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to start the server?", "Choose Mode", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Launch Server
                Server server = new Server();
                server.Show();
            }
            else if (result == DialogResult.No)
            {
                // Launch Client
                Client client = new Client();
                client.Show();
            }

        }
    }
}
