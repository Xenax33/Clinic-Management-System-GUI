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
    public partial class NameChange : Form
    {
        public NameChange()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NameChange_Load(object sender, EventArgs e)
        {
            label1.Text = BL.NameBL.Name + " CLINIC MANAGEMENT SYSTEM";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BL.NameBL.Name = textBox1.Text;
            BL.NameBL.putNameInFile();
            this.Close();
            this.Visible = false;
        }
    }
}
