﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DollarCompany
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            splashTimer.Enabled = false;
            Program.startForm.Show();
            this.Hide();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            splashTimer.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
