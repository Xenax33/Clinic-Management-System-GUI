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
    public partial class StaffAdd : Form
    {
        public StaffAdd()
        {
            InitializeComponent();
        }

        private void StaffAdd_Load(object sender, EventArgs e)
        {
            label1.Text = BL.NameBL.Name + " CLINIC MANAGEMENT SYSTEM";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, role;
            double salary = double.Parse(textBox2.Text);
            name = textBox1.Text;
            if (radioButton1.Checked)
            {
                role = "Nurse";
            }
            else
            {
                role = "Cleaner";
            }
            BL.Staff staff = new BL.Staff(name, salary, role);
            DL.StaffDL.addStaff(staff);
            DL.StaffDL.putStaffIntoFile();
            MessageBox.Show(role + " Has Been Added.");
            this.Close();
            this.Visible = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Visible = false;
            DL.StaffDL.putStaffIntoFile();

        }
    }
}
