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
    public partial class AddManager : Form
    {
        public AddManager()
        {
            InitializeComponent();
        }

        private void AddManager_Load(object sender, EventArgs e)
        {
            label1.Text = BL.NameBL.Name + " CLINIC MANAGEMENT SYSTEM";
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, username, password;
            double salary = double.Parse(textBox2.Text);
            name = textBox1.Text;
            username = textBox3.Text;
            password = textBox4.Text;
            BL.Managers manager = new BL.Managers(name, salary, username, password);
            DL.ManagersDL.AddManager(manager);
            DL.ManagersDL.PutManagersIntoFile();
            MessageBox.Show("Manager Has Been Added.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Visible = false;
        }
    }
}
