using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Resturant_management_system
{
    class function
    {
        protected SqlConnection getConnection()

        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =AVI;database = cafe; integrated security =True";
            return con;
        }
        public DataSet getData(String query)

        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd); // to store data
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public void setData(String query) //insert the data into database
        {
            SqlConnection con = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data Processed Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
