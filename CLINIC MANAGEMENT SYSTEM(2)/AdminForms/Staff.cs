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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            label1.Text = BL.NameBL.Name + " CLINIC MANAGEMENT SYSTEM";
            dataGridView1.DataSource = DL.StaffDL.getNurses();
            dataGridView2.DataSource = DL.StaffDL.getCleaners();
        }

        public void refresh()
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView1.DataSource = DL.StaffDL.getNurses();
            dataGridView2.DataSource = DL.StaffDL.getCleaners();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Visible = false;
            DL.StaffDL.putStaffIntoFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StaffAdd staffAdd = new StaffAdd();
            staffAdd.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            refresh();
            DL.StaffDL.putStaffIntoFile();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BL.Staff d = (BL.Staff)dataGridView1.CurrentRow.DataBoundItem;
            if (dataGridView1.Columns["Delete"].Index == e.ColumnIndex)
            {
                DL.StaffDL.deleteStaff(d);
                DL.StaffDL.putStaffIntoFile();
                refresh();
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BL.Staff d = (BL.Staff)dataGridView1.CurrentRow.DataBoundItem;
            if (dataGridView2.Columns["Remove"].Index == e.ColumnIndex)
            {
                DL.StaffDL.deleteStaff(d);
                DL.StaffDL.putStaffIntoFile();
                refresh();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
