using System;
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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            patient mm = new patient();
            mm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mm = new Form1();
            mm.Show();
        }
    }
}
