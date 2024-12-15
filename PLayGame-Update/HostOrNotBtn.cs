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
    public partial class HostOrNotBtn : Form
    {
        public HostOrNotBtn()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            IPs ips = new IPs();
            ips.Show();
        }

        private void btnHost_Click(object sender, EventArgs e)
        {
            IPs ips = new IPs();
            ips.Show();
        }
    }
}
