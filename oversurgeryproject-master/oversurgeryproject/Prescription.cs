﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oversurgeryproject
{
    public partial class Prescription : Form
    {
        public Prescription()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            patient mm = new patient();
            mm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login mm = new Login();
            mm.Show();
        }
    }
}
