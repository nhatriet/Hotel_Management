using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HotelManagement.All_User_Control
{
    public partial class UC_CheckOut : UserControl
    {
        function fn = new function();
        String query;
        public UC_CheckOut()
        {
            InitializeComponent();
        }

        private void UC_CheckOut_Load(object sender, EventArgs e)
        {
            //SP = "InHotelCustomer";
            //getRecord(SP); 
            query = $"EXEC PaymentInfo";
            DataSet ds = fn.getData(query);
            dgwCheckOut.DataSource = ds.Tables[0];
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //string CName = txtName.Text.Trim();
            //query = $"EXEC PaymentInfo '{@CName}'";

            //DataSet ds = fn.getData(query);
            //dgwCheckOut.DataSource = ds.Tables[0];
            UC_CheckOut_Load(this, null);
        }
        //int id;
        private void dgwCheckOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwCheckOut.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
            {
                txtCName.Text = dgwCheckOut.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtRoom.Text = dgwCheckOut.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
        int id;
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtCName.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    //int @CustomerId = id;
                    string @CName = txtCName.Text;
                    String @CDate = txtCheckOutDate.Text;
                    String @RoomNumber = txtRoom.Text;
                    query = $"EXEC Updatecheckout '{@CName}','{@CDate}', '{@RoomNumber}'";
                    fn.setData(query, "Thanh toán thành công");
                    UC_CheckOut_Load(this, null);
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("Không có khách hàng để lựa chọn", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void clearAll()
        {
            txtCName.Clear();
            txtName.Clear();
            txtRoom.Clear();
            txtCheckOutDate.ResetText();
        }

        private void UC_CheckOut_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

            string @CName = txtCName.Text.Trim();
            query = $"exec View_Invoices {@CName}";
            try
            {
                SqlDataReader reader = fn.getForCombo(query);
                StringBuilder sb = new StringBuilder();

                // Thêm tiêu đề hóa đơn
                sb.AppendLine("***************************");
                sb.AppendLine("         HÓA ĐƠN          ");
                sb.AppendLine("***************************");
                sb.AppendLine();
                while (reader.Read())
                {
                    sb.AppendLine($"Số phòng       : {reader["roomNo"]}");
                    sb.AppendLine($"Tên khách hàng : {reader["cname"]}");
                    sb.AppendLine($"Số điện thoại  : {reader["mobile"]}");
                    sb.AppendLine($"Quốc tịch      : {reader["nationality"]}");
                    sb.AppendLine($"Giới tính      : {reader["gender"]}");
                    sb.AppendLine($"Ngày sinh      : {reader["dob"]}");
                    sb.AppendLine($"CMND/CCCD      : {reader["idproof"]}");
                    sb.AppendLine($"Địa chỉ        : {reader["address"]}");
                    sb.AppendLine($"Ngày nhận phòng: {reader["checkindate"]}");
                    sb.AppendLine($"Ngày trả phòng : {reader["checkoutdate"]}");
                    sb.AppendLine($"Loại phòng     : {reader["typedescription"]}");
                    sb.AppendLine($"Giá phòng      : {reader["price"]}");
                    sb.AppendLine("***************************");
                    sb.AppendLine();
                }
                reader.Close();

                string filePath = "C:\\Users\\thanh\\OneDrive\\Tài liệu\\Workspace\\SecurityDatabase\\report.txt";
                File.WriteAllText(filePath, sb.ToString());
                MessageBox.Show("Dữ liệu đã được ghi ra file " + filePath, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}