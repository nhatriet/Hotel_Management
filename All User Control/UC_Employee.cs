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
    public partial class UC_Employee : UserControl
    {

        function fn = new function();
        String query;

        public UC_Employee()
        {
            InitializeComponent();
        }

        private void UC_Employee_Load(object sender, EventArgs e)
        {
            getMaxID();
        }

        public void getMaxID()
        {
            query = "select max(eid) from employee";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 num = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                labelToSET.Text = (num + 1).ToString();
            }

        }

        private void btnRegistation_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtMobile.Text != "" && txtGender.Text != "" && txtEmail.Text != "" && txtUsername.Text != "" && txtPassword.Text != "")
            {
                String name = txtName.Text;
                Int64 mobile = Int64.Parse(txtMobile.Text);
                // String gender = txtGender.Text;
                int gender = txtGender.SelectedIndex;
                String email = txtEmail.Text;
                String username = txtUsername.Text;
                String pass = txtPassword.Text;

                query = $"exec sp_ins_employee '{name}', {mobile}, {gender}, '{email}', '{username}', '{pass}', 2";
                // query = "insert into employee (ename, mobile, gender, emailid, username, pass) values ('" + name + "'," + mobile + ",'" + gender + "','" + email + "','" + username + "','" + pass + "')";
                fn.setData(query, "Đăng ký nhân viên thành công!");

                clearAll();
                getMaxID();
            }
        }

        public void clearAll()
        {
            txtName.Clear();
            txtMobile.Clear();
            txtGender.SelectedIndex = -1;
            txtUsername.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
        }

        private void tabEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabEmployee.SelectedIndex == 1)
            {
                setEmployee(dgwEmployeeDetail);
            }
            else if (tabEmployee.SelectedIndex == 2)
            {
                setEmployee(dgwDeleteEmployee);
            }
        }

        public void setEmployee(DataGridView dgv)
        {
            query = "exec sp_sel_employee";
            DataSet ds = fn.getData(query);
            dgv.DataSource = ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (MessageBox.Show("Bạn có chắc chắn không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    query = "delete from employee where eid = " + txtID.Text + "";
                    fn.setData(query, "Thông tin nhân viên đã được xóa");
                    tabEmployee_SelectedIndexChanged(this, null);
                }
            }
        }

        private void UC_Employee_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}