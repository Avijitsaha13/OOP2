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
    public partial class UC_RemoveGuest : UserControl
    {
        function fn = new function();
        String query;
        public UC_RemoveGuest()
        {
            InitializeComponent();
        }

        private void UC_RemoveGuest_Load(object sender, EventArgs e)
        {
            DelLabel.Text = "How to DELETE?";
            DelLabel.ForeColor = Color.Blue;
            loadData();
        }
        public void loadData() //fetch the items from database and show in gridview
        {
            query = "select name as 'Name',contact_no as 'Contact Number',address as 'Address' from registration";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearchGuest_TextChanged(object sender, EventArgs e)
        {
            query = "select name,contact_no,address from registration where name like '%" + txtSearchGuest.Text + "%' ";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete Customer?", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string name = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                query = "delete from registration where name = '" + name + "' ";
                fn.setData(query);
                loadData();
            }
        }

        private void DelLabel_Click(object sender, EventArgs e)
        {
            DelLabel.ForeColor = Color.Red;
            DelLabel.Text = "*Click on Row to Delete the Customer.";
        }

        private void UC_RemoveGuest_Enter(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
