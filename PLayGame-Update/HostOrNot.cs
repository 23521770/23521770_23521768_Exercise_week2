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
    public partial class HostOrNot : Form
    {
        public HostOrNot()
        {
            InitializeComponent();
        }

        private void btnHost_Click(object sender, EventArgs e)
        {
            Room room = new Room(true);
            room.Show();
            Hide();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            Room room = new Room(false);
            room.Show();
            Hide();
        }
    }
}
