using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pet_Shop_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }




        private void addCash1_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addCustomer1.Visible = false;
            addEmployee1.Visible = false;
            addProduct1.Visible = false;
            addCash1.Visible = false;

        }

        private void buttonCustomers_Click_1(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addCustomer1.Visible = true;
            addEmployee1.Visible = false;
            addProduct1.Visible = false;
            addCash1.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addCustomer1.Visible = false;
            addEmployee1.Visible = true;
            addProduct1.Visible = false;
            addCash1.Visible = false;
        }


        private void buttonProducts_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addCustomer1.Visible = false;
            addEmployee1.Visible = false;
            addProduct1.Visible = true;
            addCash1.Visible = false;
        }

        private void buttonCash_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addCustomer1.Visible = false;
            addEmployee1.Visible = false;
            addProduct1.Visible = false;
            addCash1.Visible = true;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to log out?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Hide();

            }

        }
        private void labelexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
