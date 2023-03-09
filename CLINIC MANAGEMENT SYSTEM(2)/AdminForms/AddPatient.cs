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
    public partial class AddPatient : Form
    {
        public AddPatient()
        {
            InitializeComponent();
        }

        private void AddPatient_Load(object sender, EventArgs e)
        {
            label1.Text = BL.NameBL.Name + " CLINIC MANAGEMENT SYSTEM";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string newpass = textBox2.Text;
            bool flag = false;
            for (int i = 0; i < newpass.Length; i++)
            {
                if (newpass[i] == '!' || newpass[i] == '@' || newpass[i] == '#' || newpass[i] == '$' || newpass[i] == '%' || newpass[i] == '^' || newpass[i] == '&' || newpass[i] == '*' || newpass[i] == '(' || newpass[i] == ')')
                {
                    flag = true;
                }
            }
            if (flag == false)
            {
                label4.Text = "Password Must Contain Special Characters";
                label4.Visible = true;
            }
            else if (flag)
            {
                string role = "Patient";
                BL.MUserBL mUser = new BL.MUserBL(username, newpass, role);
                DL.MUsersDL.AddUser(mUser);
                DL.MUsersDL.writeData();
                MessageBox.Show("Patient Has Been Added.");
                this.Close();
            }
        }
    }
}
