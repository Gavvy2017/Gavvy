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
    public partial class Prescription : Form
    {
        public Prescription()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            main mm = new main();
            mm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //This code shows Gurvinder adding the  button so it will link up with the forms and interact
            this.Hide();
            Login mm = new Login();
            mm.Show();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oversugeryDBDataSet3.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.oversugeryDBDataSet3.staff);

        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Chad\Documents\GitHub\oversurgeryproject\oversurgeryproject\OversugeryDB.mdf;Integrated Security=True;Connect Timeout=30");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //SqlDataAdapter sda = new SqlDataAdapter("select count(*) from staff where id ='" + comboBox1.Text + "'", conn);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string local = textBox1.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Chad\Documents\GitHub\oversurgeryproject\oversurgeryproject\OversugeryDB.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter da = new SqlDataAdapter("select * from staff where id = '" + local + "'", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
