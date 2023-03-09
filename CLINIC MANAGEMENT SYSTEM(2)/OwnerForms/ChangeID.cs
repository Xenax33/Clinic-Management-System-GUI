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
    public partial class ChangeID : Form
    {
        public ChangeID()
        {
            InitializeComponent();
        }

        private void ChangeID_Load(object sender, EventArgs e)
        {
            label1.Text = BL.NameBL.Name + " CLINIC MANAGEMENT SYSTEM";
            textBox1.Text = DL.MUsersDL.getOwner().Username;
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
                DL.MUsersDL.ChangeOwnerID(username, newpass);
                MessageBox.Show("ID Has Been Updated.");
                DL.MUsersDL.writeData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Visible = false;
        }
    }
}
