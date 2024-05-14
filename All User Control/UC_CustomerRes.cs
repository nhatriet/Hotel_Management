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

namespace HotelManagement.All_User_Control
{
    public partial class UC_CustomerRes : UserControl
    {
        private string connectionString = @"Data Source=MSI\\MSSQLSERVERTH;Initial Catalog=Hotel_Encrypt;Integrated Security=True";

        function fn = new function();

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;

        String query;

        public UC_CustomerRes()
        {
            InitializeComponent();
        }

        private void UC_CustomerRes_Load(object sender, EventArgs e)
        {
            this.showCboRoomType();
        }

        public void showCboRoomType()
        {
            conn = fn.getConnection();
            conn.Open();
           
            cmd = new SqlCommand("select * from vw_showCboRoomType_UC_CustomerRes", conn);
            da = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();
            da.Fill(table);
            txtRoomType.DataSource = table;
            txtRoomType.DisplayMember = "typedescription";
            txtRoomType.ValueMember = "typeid";

            conn.Close();
        }

        private void txtRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)txtRoomType.SelectedItem;

            if (selectedRow != null)
            {
                int typeId = Convert.ToInt32(selectedRow["typeid"]);
                showCboRoomNo(typeId);

                conn = fn.getConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand($"select price from roomtypes where typeid = '{typeId}'",conn);
                var result = cmd.ExecuteScalar();
                if (result != null)
                {
                    price = Convert.ToInt32(result);
                    txtPrice.Text = result.ToString();
                }

                conn.Close();
            }
        }

        public void showCboRoomNo(int typeId)
        {
            conn = fn.getConnection();
            conn.Open();

            cmd = new SqlCommand("sp_showCboRoomNo_UC_CustomerRes", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("typeId", typeId);

            da = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();
            da.Fill(table);
            txtRoomNo.DataSource = table;
            txtRoomNo.DisplayMember = "roomNo";
            txtRoomNo.ValueMember = "roomid";

            conn.Close();
        }
        int rid;
        int rNo;
        int price;
        private void btnAllotCustomer_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPhone.Text != "" && txtNationality.Text != "" && txtGender.Text != "" && txtDOB.Text != "" && txtIDProof.Text != "" && txtAddress.Text != "" && txtCheckin.Text != "" && txtPrice.Text != "")
            {
                String name = txtName.Text;
                String mobile = txtPhone.Text;
                String nationality = txtNationality.Text;
                String gender = txtGender.Text;
                String dob = txtDOB.Text;
                String idproof = txtIDProof.Text;
                String address = txtAddress.Text;
                String checkin = txtCheckin.Text;

                conn = fn.getConnection();
                conn.Open();
                SqlCommand cmd = new SqlCommand("AddCustomer", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cname", name);
                cmd.Parameters.AddWithValue("@mobile", mobile);
                cmd.Parameters.AddWithValue("@nationality", nationality);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@dob", dob);
                cmd.Parameters.AddWithValue("@idproof", idproof);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@checkindate", checkin);
                cmd.Parameters.AddWithValue("@roomid", rid);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Số phòng " + txtRoomNo.Text + " đăng ký khách hàng thành công", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearAll();
            }
            else
            {
                MessageBox.Show("Xin vui lòng điền đầy đủ thông tin!", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public void clearAll()
        {
            txtName.Clear();
            txtPhone.Clear();
            txtNationality.Clear();
            txtGender.SelectedIndex = -1;
            txtDOB.ResetText();
            txtIDProof.Clear();
            txtAddress.Clear();
            txtCheckin.ResetText();
            txtPrice.Clear();
        }

        private void UC_CustomerRes_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void txtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView selectedRow = (DataRowView)txtRoomNo.SelectedItem;

            if (selectedRow != null)
            {
                rid = Convert.ToInt32(selectedRow["roomid"]);
                rNo = Convert.ToInt32(selectedRow["roomNo"]);
            }
        }
    }
}
