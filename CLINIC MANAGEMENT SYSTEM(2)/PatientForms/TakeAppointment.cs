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
using CLINIC_MANAGEMENT_SYSTEM_2_.DL;

namespace CLINIC_MANAGEMENT_SYSTEM_2_.PatientForms
{
    public partial class TakeAppointment : Form
    {
        public TakeAppointment()
        {
            InitializeComponent();
        }

        public void refresh()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DL.DoctorsDL.getDoctors();
            dataGridView1.Columns[4].Visible = false;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DoctorBL d = (DoctorBL)dataGridView1.CurrentRow.DataBoundItem;
            if (dataGridView1.Columns["Column1"].Index == e.ColumnIndex)
            {
                DL.DoctorsDL.takeAppointment(d);
                DL.DoctorsDL.writeDoctorsIntoFile();
                MessageBox.Show("Appointment Has Been Made.");
                refresh();
            }
        }

        private void TakeAppointment_Load(object sender, EventArgs e)
        {
            label1.Text = BL.NameBL.Name + " CLINIC MANAGEMENT SYSTEM";
            dataGridView1.DataSource = DL.DoctorsDL.getDoctors();
            dataGridView1.Columns[4].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Visible = false;
            DL.DoctorsDL.writeDoctorsIntoFile();
        }
    }
}
