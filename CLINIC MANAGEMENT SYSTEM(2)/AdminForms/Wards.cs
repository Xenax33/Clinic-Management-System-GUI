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
    public partial class Wards : Form
    {
        public Wards()
        {
            InitializeComponent();
        }

        private void AddWard_Load(object sender, EventArgs e)
        {
            label1.Text = BL.NameBL.Name + " CLINIC MANAGEMENT SYSTEM";
            dataGridView1.DataSource = DL.WardsDL.GetWards();
        }

        public void refresh()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DL.WardsDL.GetWards();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            refresh();
            DL.WardsDL.putWardsIntoFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Visible = false;
            DL.WardsDL.putWardsIntoFile();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WardAdd add = new WardAdd();
            add.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            BL.WardBL ward = (BL.WardBL)dataGridView1.CurrentRow.DataBoundItem;
            if (dataGridView1.Columns["Delete"].Index == e.ColumnIndex)
            {
                DL.WardsDL.deleteWard(e.RowIndex);
                DL.WardsDL.putWardsIntoFile();
                refresh();
            }
        }
    }
}
