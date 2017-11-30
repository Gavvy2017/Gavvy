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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mm = new Form1();
            mm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            patient mm = new patient();
            mm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff mm = new Staff();
            mm.Show();
        }
    }
}
