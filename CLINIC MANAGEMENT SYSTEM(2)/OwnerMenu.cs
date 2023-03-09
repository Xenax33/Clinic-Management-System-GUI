using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLINIC_MANAGEMENT_SYSTEM_2_.OwnerForms;
using CLINIC_MANAGEMENT_SYSTEM_2_.BL;
using CLINIC_MANAGEMENT_SYSTEM_2_.DL;

namespace CLINIC_MANAGEMENT_SYSTEM_2_
{
    public partial class OwnerMenu : Form
    {
        public OwnerMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OwnerMenu_Load(object sender, EventArgs e)
        {
            label1.Text = BL.NameBL.Name + " CLINIC MANAGEMENT SYSTEM";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Visible = true;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeID changeID = new ChangeID();
            changeID.Visible = true;
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            Form1 form1 = new Form1();
            form1.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            NameChange nameChange = new NameChange();
            nameChange.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CalculateProfit calculateProfit = new CalculateProfit();
            calculateProfit.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddManager addManager = new AddManager();
            addManager.Visible = true;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            ViewStaff viewStaff = new ViewStaff();
            viewStaff.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewWards wards = new ViewWards();
            wards.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ViewPatients viewPatients = new ViewPatients();
            viewPatients.Visible = true;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            ChangeID changeID = new ChangeID();
            changeID.Visible = true;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Close();
            Form1 form1 = new Form1();
            form1.Visible = true;
        }
    }
}
