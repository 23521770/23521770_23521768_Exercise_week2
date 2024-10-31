﻿using System;
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
    public partial class IP : Form
    {
        public IP()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            MultiplePLayers newGame = new MultiplePLayers(false, txtbIP.Text);
                 Visible = false;
                if (!newGame.IsDisposed)
                    newGame.ShowDialog();
                   Visible = true;
        }

        private void btnHost_Click(object sender, EventArgs e)
        {
            MultiplePLayers newGame = new MultiplePLayers(true);
            Visible = false;
            if (!newGame.IsDisposed) newGame.ShowDialog();
            Visible = true;
        }
    }
}
