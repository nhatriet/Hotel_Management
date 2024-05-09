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
            query = "select customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.address, rooms.roomNo, roomtypes.typedescription, roomtypes.numbersofbed, roomtypes.price" +
                " from customer inner join rooms on customer.roomid = rooms.roomid inner join roomtypes on roomtypes.typeid = rooms.typeid inner join book on customer.cid = book.cid" +
                " where book.ischeckedout = 0";
            DataSet ds = fn.getData(query);
            dgwCheckOut.DataSource = ds.Tables[0];
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            query = "select customer.cid, customer.cname, customer.mobile, customer.nationality, customer.gender, customer.dob, customer.idproof, customer.address, rooms.roomNo, roomtypes.typedescription, roomtypes.numbersofbed, roomtypes.price" +
                " from customer inner join rooms on customer.roomid = rooms.roomid inner join roomtypes on roomtypes.typeid = rooms.typeid inner join book on customer.cid = book.cid" +
                " where cname like '" + txtName.Text + "' and ischeckedout = 0";
            DataSet ds = fn.getData(query);
            dgwCheckOut.DataSource = ds.Tables[0];

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
                if (MessageBox.Show ("Bạn có chắc chắn không?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    String cdate = txtCheckOutDate.Text;
                    query = "update book set ischeckedout = 1, checkout = '" + cdate + "' where cid = " + id + " update rooms set booked = 0 where roomNo =  '" + txtRoom.Text + "'";
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
