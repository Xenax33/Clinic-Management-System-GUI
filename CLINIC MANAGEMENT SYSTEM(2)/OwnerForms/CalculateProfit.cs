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
    public partial class CalculateProfit : Form
    {
        public CalculateProfit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double electricity = double.Parse(textBox1.Text);
            double water = double.Parse(textBox2.Text);
            double gas = double.Parse(textBox3.Text);
            double other = double.Parse(textBox4.Text);
            double bills = electricity + water + gas + other;
            double total = DL.DoctorsDL.getProfit() - DL.ManagersDL.getSalaries() - DL.StaffDL.getSalaries() + DL.WardsDL.getProfit() - bills;
            if (total >=0)
            {
                label6.Text = "Profit: ";
                label6.Visible = true;
                label7.Text = "" + total;
                label7.Visible = true;
            }
            else
            {
                label6.Text = "Loss: ";
                label6.Visible = true;
                label7.Text = "" + total*-1;
                label7.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Visible = false;

        }

        private void CalculateProfit_Load(object sender, EventArgs e)
        {
            label1.Text = BL.NameBL.Name + " CLINIC MANAGEMENT SYSTEM";
        }
    }
}
