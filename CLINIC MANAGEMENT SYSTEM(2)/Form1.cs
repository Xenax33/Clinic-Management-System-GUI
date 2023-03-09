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
using CLINIC_MANAGEMENT_SYSTEM_2_.DL;

namespace CLINIC_MANAGEMENT_SYSTEM_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            label4.Text = BL.NameBL.Name + " CLINIC MANAGEMENT SYSTEM";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string usernam = textBox3.Text;
                string passwor = maskedTextBox1.Text;
                if (DL.ManagersDL.checkManager(usernam, passwor))
                {
                    AdminMenu adminMenu = new AdminMenu();
                    adminMenu.Visible = true;
                    this.Visible = false;
                }
            }
            else
            {
                string username = textBox3.Text;
                string password = maskedTextBox1.Text;
                string role = DL.MUsersDL.checkData(username, password);
                if (role == "Owner")
                {
                    OwnerMenu owner = new OwnerMenu();
                    owner.Visible = true;
                    this.Visible = false;
                }
                else if (role == "Patient")
                {
                    PatientMenu patient = new PatientMenu();
                    patient.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("INVALID");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string usernam = textBox3.Text;
                string passwor = maskedTextBox1.Text;
                if (DL.ManagersDL.checkManager(usernam , passwor))
                {
                    AdminMenu adminMenu = new AdminMenu();
                    adminMenu.Visible = true;
                    this.Visible = false;
                }
            }
            else
            {
                string username = textBox3.Text;
                string password = maskedTextBox1.Text;
                string role = DL.MUsersDL.checkData(username, password);
                if (role == "Owner")
                {
                    OwnerMenu owner = new OwnerMenu();
                    owner.Visible = true;
                    this.Visible = false;
                }
                else if (role == "Patient")
                {
                    PatientMenu patient = new PatientMenu();
                    patient.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("INVALID");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string usernam = textBox3.Text;
                string passwor = maskedTextBox1.Text;
                if (DL.ManagersDL.checkManager(usernam, passwor))
                {
                    AdminMenu adminMenu = new AdminMenu();
                    adminMenu.Visible = true;
                    this.Visible = false;
                }
            }
            else
            {
                string username = textBox3.Text;
                string password = maskedTextBox1.Text;
                string role = DL.MUsersDL.checkData(username, password);
                if (role == "Owner")
                {
                    OwnerMenu owner = new OwnerMenu();
                    owner.Visible = true;
                    this.Visible = false;
                }
                else if (role == "Patient")
                {
                    PatientMenu patient = new PatientMenu();
                    patient.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("INVALID");
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
            this.Close();
        }
    }
}
