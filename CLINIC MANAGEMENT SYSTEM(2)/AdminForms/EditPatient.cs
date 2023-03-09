using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLINIC_MANAGEMENT_SYSTEM_2_.BL;

namespace CLINIC_MANAGEMENT_SYSTEM_2_.AdminForms
{
    public partial class EditPatient : Form
    {
        private int num;
        public EditPatient(BL.MUserBL mUser)
        {
            InitializeComponent();
            textBox1.Text = mUser.Username;
            num =  DL.MUsersDL.getPatientNumber(mUser);
        }

        private void EditPatient_Load(object sender, EventArgs e)
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
            if (flag)
            {
                DL.MUsersDL.UpdatePatient(num, username, newpass);
                DL.MUsersDL.writeData();
                MessageBox.Show("Patient Has Been Updated.");
                this.Close();
            }
        }
    }
}
