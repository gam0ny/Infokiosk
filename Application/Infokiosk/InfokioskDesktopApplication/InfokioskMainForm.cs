﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfokioskDesktopApplication
{
    public partial class InfokioskMainForm : Form
    {
        public InfokioskMainForm()
        {
            InitializeComponent();
            //this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void LblLogin_Click(object sender, EventArgs e)
        {
            this.Hide();


        }
    }
}
