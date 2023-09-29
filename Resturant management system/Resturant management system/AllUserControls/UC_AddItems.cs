using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant_management_system.AllUserControls
{
    public partial class UC_AddItems : UserControl
    {
        function fn = new function();
        String query;


        public UC_AddItems()
        {
            InitializeComponent();
        }

        private void UC_AddItems_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                query = "insert into items (name,category,price) values ('" + txtItemName.Text + "','" + txtCategory.Text + "'," + txtPrice.Text + ")";
                fn.setData(query);
                clearAll();
            }
            catch
            {
                MessageBox.Show("Please fill all the required fields with valid input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clearAll()
        {
            txtCategory.SelectedIndex = -1;
            txtItemName.Clear();
            txtPrice.Clear();
        }
    }
}
