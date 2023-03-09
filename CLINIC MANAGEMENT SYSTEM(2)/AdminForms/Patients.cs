using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLINIC_MANAGEMENT_SYSTEM_2_.AdminForms
{
    public partial class Patients : Form
    {
        public Patients()
        {
            InitializeComponent();
        }

        private void Patients_Load(object sender, EventArgs e)
        {
            label1.Text = BL.NameBL.Name + " CLINIC MANAGEMENT SYSTEM";
            dataGridView1.DataSource = DL.MUsersDL.getPatients();
        }

        public void refresh()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DL.MUsersDL.getPatients();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BL.MUserBL mUser = (BL.MUserBL)dataGridView1.CurrentRow.DataBoundItem;
            if (dataGridView1.Columns["Delete"].Index == e.ColumnIndex)
            {
                DL.MUsersDL.deletePatient(e.RowIndex);
                DL.MUsersDL.writeData();
                refresh();
            }
            else if (dataGridView1.Columns["Edit"].Index == e.ColumnIndex)
            {
                EditPatient editPatient = new EditPatient(mUser);
                editPatient.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            addPatient.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Visible = false;
            DL.MUsersDL.writeData();
        }
    }
}
