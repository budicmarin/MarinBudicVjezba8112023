﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarinBudicVjezba8112023
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            Form2 forma=new Form2();
            if (txUsername.Text != "" && txPassword.Text != "") forma.Show();
        }

        private void btBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
