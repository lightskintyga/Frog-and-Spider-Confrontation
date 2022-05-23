﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sharpGame
{
    public partial class LoadingScreen : Form
    {
        public LoadingScreen()
        {
            InitializeComponent();
            this.Opacity = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity < 100)
            {
                Opacity += 0.05;
                progressBar1.Increment(5);
            }

            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                Menu option = new Menu();
                option.ShowDialog();
                Application.OpenForms["Form1"].Dispose();
            }
        }
    }
}
