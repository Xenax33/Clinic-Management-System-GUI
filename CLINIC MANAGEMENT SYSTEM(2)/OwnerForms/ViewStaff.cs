using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLINIC_MANAGEMENT_SYSTEM_2_.OwnerForms
{
    public partial class ViewStaff : Form
    {
        public ViewStaff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewStaff_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DL.DoctorsDL.getDoctors();
            dataGridView2.DataSource = DL.ManagersDL.getManagers();
            dataGridView3.DataSource = DL.StaffDL.getStaff();
            label1.Text = BL.NameBL.Name + " CLINIC MANAGEMENT SYSTEM";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Visible = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BL.Managers manager = (BL.Managers)dataGridView2.CurrentRow.DataBoundItem;
            if (dataGridView2.Columns["Delete"].Index == e.ColumnIndex)
            {
                DL.ManagersDL.deleteManager(e.RowIndex);
                DL.ManagersDL.PutManagersIntoFile();
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = DL.ManagersDL.getManagers();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = DL.ManagersDL.getManagers();
        }
    }
}
