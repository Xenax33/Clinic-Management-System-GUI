using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLINIC_MANAGEMENT_SYSTEM_2_.AdminForms;

namespace CLINIC_MANAGEMENT_SYSTEM_2_
{
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            label1.Text = BL.NameBL.Name + " CLINIC MANAGEMENT SYSTEM";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Doctors doctors = new Doctors();
            doctors.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Wards wards = new Wards();
            wards.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Patients patients = new Patients();
            patients.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Visible = true;
        }
    }
}
