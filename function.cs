using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace HotelManagement
{
    internal class function
    {
/*        private string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=Hotel_Encrypt;Integrated Security=True";
*/
        public SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=MSI\\SQLEXPRESS;Initial Catalog=Hotel_Encrypt;Integrated Security=True";
            return con;
        }

        public DataSet getData(String query)
        {
            SqlConnection connection = getConnection();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(String query, String message)
        {
            SqlConnection connection = getConnection();
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public SqlDataReader getForCombo(String query)
        {
            SqlConnection connection = getConnection();
            SqlCommand cmd = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
    }
}
