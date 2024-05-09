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
        function fn = new function();
        String query;

        public UC_CustomerRes()
        {
            InitializeComponent();
        }
        public void setComboBox(String qurery, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);
            while (sdr.Read())
            {
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                } 
            }
            sdr.Close();
        }

        private void btnAllotCustomer_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPhone.Text != "" && txtNationality.Text != "" && txtGender.Text != "" && txtDOB.Text != "" && txtIDProof.Text != "" && txtAddress.Text != "" && txtCheckin.Text != "" && txtPrice.Text != "")
            {
                String name = txtName.Text;
                Int64 mobile = Int64.Parse(txtPhone.Text);
                String nationality = txtNationality.Text;
                String gender = txtGender.Text;
                String dob = txtDOB.Text;
                String idproof = txtIDProof.Text;
                String address = txtAddress.Text;
                String checkin = txtCheckin.Text;

                query = "insert into customer (cname, mobile, nationality, gender, dob, idproof, address, checkin, roomid) values " +
                    "('" + name + "'," + mobile + ",'" + nationality + "', '" + gender + "','" + dob + "','" + idproof + "','" + address + "','" + checkin + "','" + rid + ") update rooms set booked = 'YES' where roomNo = '" + txtRoomNo.Text + "'";
                fn.setData(query, "Số phòng " + txtRoomNo.Text + " đăng ký khách hàng thành công");
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
            txtBed.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtRoomType.SelectedIndex = -1;
            txtPrice.Clear();
        }

        private void txtBed_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNo.SelectedIndex = -1;
            txtRoomNo.Items.Clear();
            txtPrice.Clear();
        }

        private void txtRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtRoomNo.Items.Clear();
            query = "select roomNo from rooms where bed = '" + txtBed.Text + "' and roomType = '" + txtRoomType.Text + "' and booked = 'NO'";
            setComboBox(query, txtRoomNo);
        }

        int rid;
        private void txtRoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            query = "select price, roomid from rooms where roomNo = '" + txtRoomNo.Text + "'";
            DataSet ds = fn.getData(query);
            txtPrice.Text = ds.Tables[0].Rows[0][0].ToString();
            rid = int.Parse(ds.Tables[0].Rows[0][1].ToString());
        }

        private void UC_CustomerRes_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
