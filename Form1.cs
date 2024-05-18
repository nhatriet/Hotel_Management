using HotelManagement.All_User_Control;
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
            string password = txtPassword.Text;
            if (username != String.Empty || password != String.Empty)
            {
                SqlConnection con = fn.getConnection();
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_Login", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Thêm tham số đầu vào
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@pass", password);

                // Thêm tham số output
                SqlParameter role = new SqlParameter("@roleid", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(role);

                // Thực thi stored procedure
                cmd.ExecuteNonQuery();
                int roleid = Int32.Parse(cmd.Parameters["@roleid"].Value.ToString());
                con.Close();
                if (roleid != 0)
                {
                    labelError.Visible = false;
                    Dashboard dash = new Dashboard(roleid);
                    
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
