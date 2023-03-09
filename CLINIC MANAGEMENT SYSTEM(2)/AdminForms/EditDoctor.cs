using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLINIC_MANAGEMENT_SYSTEM_2_.DL;

namespace CLINIC_MANAGEMENT_SYSTEM_2_.AdminForms
{
    public partial class EditDoctor : Form
    {
        public int row;
        public EditDoctor(int row)
        {
            InitializeComponent();
        }

        private void EditDoctor_Load(object sender, EventArgs e)
        {
            label1.Text = BL.NameBL.Name + " CLINIC MANAGEMENT SYSTEM";
            textBox1.Text = DL.DoctorsDL.returnDoctor(row).Name;
            string text = "" + DL.DoctorsDL.returnDoctor(row).Salary;
            textBox2.Text = text;
            text = "" + DL.DoctorsDL.returnDoctor(row).Fees;
            textBox3.Text = text;
            text = "" + DL.DoctorsDL.returnDoctor(row).Appointments;
            textBox4.Text = text;
            textBox5.Text = DL.DoctorsDL.returnDoctor(row).Timing;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DL.DoctorsDL.returnDoctor(row).Name = textBox1.Text;
            DL.DoctorsDL.returnDoctor(row).Salary = double.Parse(textBox2.Text);
            DL.DoctorsDL.returnDoctor(row).Fees = double.Parse(textBox3.Text);
            DL.DoctorsDL.returnDoctor(row).Appointments = int.Parse(textBox4.Text);
            DL.DoctorsDL.returnDoctor(row).Timing = textBox5.Text;
            MessageBox.Show("Doctor Has Been Updated.");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Visible = false;
        }
    }
}
