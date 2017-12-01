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
    public partial class Appointment : Form
    {

        public Appointment()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            patient mm = new patient();
            mm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mm = new Form1();
            mm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'oversugeryDBDataSet2.appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this.oversugeryDBDataSet2.appointment);
            Edit(false);
        }

        private void Edit(bool value)
        {
            textBox1.Enabled = value;
            textBox2.Enabled = value;
            textBox4.Enabled = value;
            textBox5.Enabled = value;
            textBox6.Enabled = value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(true);
                oversugeryDBDataSet2.appointment.AddappointmentRow(oversugeryDBDataSet2.appointment.NewappointmentRow());
                textBox1.Focus();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Messaage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                oversugeryDBDataSet2.appointment.RejectChanges();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Edit(true);
            textBox1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Edit(false);
            appointmentBindingSource.ResetBindings(false);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Edit(false);
                appointmentBindingSource.EndEdit();
                appointmentTableAdapter.Update(oversugeryDBDataSet2.appointment);
                dataGridView2.Refresh();
                textBox1.Focus();
                MessageBox.Show("Appointment has been Confirmed.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                oversugeryDBDataSet2.appointment.RejectChanges();
            }
        }

        private void dataGridView2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)//enter 
            {
                if (MessageBox.Show("Are you sure you want ths appoinmnet should be removed", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    appointmentBindingSource.RemoveCurrent();
            }
        }
    }
}
