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
    public partial class ViewPatients : Form
    {
        public ViewPatients()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Visible = false;
        }

        private void ViewPatients_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DL.MUsersDL.getPatients();
        }
    }
}
