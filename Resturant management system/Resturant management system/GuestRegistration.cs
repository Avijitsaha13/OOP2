using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Resturant_management_system
{
    public partial class GuestRegistration : Form
    {
        function fn = new function();
        String query;
        public GuestRegistration()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("data source = AVI;database = cafe; integrated security = True ");

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {



                query = "insert into registration values('" + txtName.Text + "', '" + txtPassword.Text + "',  " + txtContact.Text + ",'" + txtAddress.Text + "');";
                fn.setData(query);
                clearAll();
                MessageBox.Show("Registration Confirmed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);





            }
            catch
            {
                MessageBox.Show("Please give a valid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);



            }

        }
        public void clearAll()
        {

            txtName.Clear();
            txtPassword.Clear();
            txtContact.Clear();
            txtAddress.Clear();




        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to exit the application?", "Exit Window", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnGuestLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            GuestLogin gl = new GuestLogin();
            this.Hide();
            gl.Show();
        }
    }
}
