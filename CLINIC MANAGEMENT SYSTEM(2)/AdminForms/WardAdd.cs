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
    public partial class WardAdd : Form
    {
        public WardAdd()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            int rooms;
            double cost, expenses;
            name = textBox1.Text;
            rooms = int.Parse(textBox4.Text);
            cost = double.Parse(textBox2.Text);
            expenses = double.Parse(textBox3.Text);
            int performed = 0;
            BL.WardBL ward = new BL.WardBL(name, performed, rooms, cost, expenses);
            DL.WardsDL.addWard(ward);
            DL.WardsDL.putWardsIntoFile();
            MessageBox.Show("Ward has been added.");
            this.Close();
            this.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Visible = false;
        }

        private void WardAdd_Load(object sender, EventArgs e)
        {

        }
    }
}
