using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLINIC_MANAGEMENT_SYSTEM_2_.BL;

namespace CLINIC_MANAGEMENT_SYSTEM_2_.AdminForms
{
    public partial class AddDoctor : Form
    {
        public AddDoctor()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            double salary = double.Parse(textBox2.Text);
            double fees = double.Parse(textBox3.Text);
            string timing = textBox4.Text;
            int appointment = 0;
            DoctorBL doctor = new DoctorBL(name, timing , salary , fees , appointment);
            DL.DoctorsDL.addDoctor(doctor);
            DL.DoctorsDL.writeDoctorsIntoFile();
            MessageBox.Show("Doctor Has Been Added.");
            this.Close();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Visible = false;
            Doctors doctors = new Doctors();
            doctors.Visible = true;
/*            doctors.refresh();*/
        }

        private void AddDoctor_Load(object sender, EventArgs e)
        {
            label1.Text = BL.NameBL.Name + " CLINIC MANAGEMENT SYSTEM";
        }
    }
}
