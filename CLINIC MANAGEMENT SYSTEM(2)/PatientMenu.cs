using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLINIC_MANAGEMENT_SYSTEM_2_.PatientForms;

namespace CLINIC_MANAGEMENT_SYSTEM_2_
{
    public partial class PatientMenu : Form
    {
        public PatientMenu()
        {
            InitializeComponent();
        }

        private void PatientMenu_Load(object sender, EventArgs e)
        {
            label1.Text = BL.NameBL.Name + " CLINIC MANAGEMENT SYSTEM";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TakeAppointment appointment = new TakeAppointment();
            appointment.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ApplyForTreatment treatment = new ApplyForTreatment();
            treatment.Visible = true;
        }
    }
}
