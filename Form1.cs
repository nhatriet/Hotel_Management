using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HotelManagement
{
    public partial class Form1 : Form
    {
        function fn = new function();
        String query;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtUsername.Text;
            if (username != String.Empty || password != String.Empty)
            {
                SqlConnection con = fn.getConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_Login", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm tham số đầu vào
                cmd.Parameters.Add(new SqlParameter("@username", SqlDbType.VarChar, 50)).Value = username;
                cmd.Parameters.Add(new SqlParameter("@pass", SqlDbType.VarChar, 250)).Value = password;

                // Thêm tham số output
                SqlParameter outUsernameParam = new SqlParameter("@out_username", SqlDbType.VarChar, 50)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outUsernameParam);

                SqlParameter outPasswordParam = new SqlParameter("@out_password", SqlDbType.VarChar, 50)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outPasswordParam);

                // Thực thi stored procedure
                cmd.ExecuteNonQuery();

                fn.username = outUsernameParam.Value.ToString();
                fn.password = outPasswordParam.Value.ToString();
                con.Close();
                if (outUsernameParam != null)
                {
                    labelError.Visible = false;
                    Dashboard dash = new Dashboard();
                    this.Hide();
                    dash.Show();
                }
                else
                {
                    labelError.Visible = true;
                    txtPassword.Clear();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
