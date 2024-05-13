using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            query = "Select * from PaymentInfo";
            DataSet ds = fn.getData(query);
            dgwCheckOut.DataSource = ds.Tables[0];
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            string CName = txtName.Text.Trim();
            query = "SELECT * FROM PaymentInfo WHERE cname LIKE '" + CName + "'";
            // query = "Select * from PaymentInfo where cname like '" + txtName.Text + "'";
            DataSet ds = fn.getData(query);
            dgwCheckOut.DataSource = ds.Tables[0];
            UC_CheckOut_Load(this, null);
        }
        int id;
        private void dgwCheckOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwCheckOut.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
            {
                id = int.Parse(dgwCheckOut.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtCName.Text = dgwCheckOut.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtRoom.Text = dgwCheckOut.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
        
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtCName.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    int @CustomerId = id;
                    String @CDate = txtCheckOutDate.Text;
                    String @RoomNumber = txtRoom.Text;
                    query = $"EXEC Updatecheckout {@CustomerId}, '{@CDate}', '{@RoomNumber}'";
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
    }
}