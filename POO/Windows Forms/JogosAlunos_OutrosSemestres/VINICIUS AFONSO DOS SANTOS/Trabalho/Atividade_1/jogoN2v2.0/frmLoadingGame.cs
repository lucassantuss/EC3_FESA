﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogoN2v2._0
{
    public partial class frmLoadingGame : Form
    {
        public frmLoadingGame()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 15;
            if (panel2.Width >= panel1.Width)
            {
                timer1.Stop();
                this.Close();
            }
        }
    }
}
