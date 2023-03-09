using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLINIC_MANAGEMENT_SYSTEM_2_.PatientForms
{
    public partial class ApplyForTreatment : Form
    {
        public ApplyForTreatment()
        {
            InitializeComponent();
        }

        public void refresh()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DL.WardsDL.GetWards();
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }
        private void ApplyForTreatment_Load(object sender, EventArgs e)
        {
            label1.Text = BL.NameBL.Name + " CLINIC MANAGEMENT SYSTEM";
            dataGridView1.DataSource = DL.WardsDL.GetWards();
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[5].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BL.WardBL ward = (BL.WardBL)dataGridView1.CurrentRow.DataBoundItem;
            if (dataGridView1.Columns["Apply"].Index == e.ColumnIndex)
            {
                DL.WardsDL.applyForTreatment(ward);
                DL.WardsDL.putWardsIntoFile();
                refresh();
                MessageBox.Show("Application Has Been Submitted");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Visible = false;
            DL.WardsDL.putWardsIntoFile();
        }
    }
}
