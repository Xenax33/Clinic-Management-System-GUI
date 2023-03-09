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

namespace CLINIC_MANAGEMENT_SYSTEM_2_.AdminForms
{
    public partial class Doctors : Form
    {
        public Doctors()
        {
            InitializeComponent();
        }

        private void Doctors_Load(object sender, EventArgs e)
        {
            label1.Text = BL.NameBL.Name + " CLINIC MANAGEMENT SYSTEM";
            dataGridView1.DataSource = DL.DoctorsDL.getDoctors();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddDoctor addDoctor = new AddDoctor();
            addDoctor.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Visible = false;
            DL.DoctorsDL.writeDoctorsIntoFile();
        }

        public void refresh()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DL.DoctorsDL.getDoctors();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DoctorBL d = (DoctorBL)dataGridView1.CurrentRow.DataBoundItem;
            if (dataGridView1.Columns["Delete"].Index == e.ColumnIndex)
            {
                DL.DoctorsDL.deleteDoctor(e.RowIndex);
                DL.DoctorsDL.writeDoctorsIntoFile();
                refresh();
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DL.DoctorsDL.writeDoctorsIntoFile();
            refresh();
        }
    }
}
