using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Dashboard : Form
    {
        private int roleid;
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(int roleid)
        {
            InitializeComponent();
            this.roleid = roleid;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddRoom1.Visible = false;
            uC_CustomerRes1.Visible = false;
            uC_CheckOut1.Visible = false;
            uC_CustomerDetails1.Visible = false;
            uC_Employee1.Visible = false;
            if (roleid == 1)
            {
                btnAddRoom.PerformClick();
            }
            else if (roleid == 2)
            {
                btnCustomerRes.PerformClick();
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (roleid == 1)
            {
                PanelMoving.Left = btnAddRoom.Left + 50;
                uC_AddRoom1.Visible = true;
                uC_AddRoom1.BringToFront();
            }
        }

        private void btnCustomerRes_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnCustomerRes.Left + 60;
            uC_CustomerRes1.Visible = true;
            uC_CustomerRes1.BringToFront();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnCheckout.Left + 60;
            uC_CheckOut1.Visible = true;
            uC_CheckOut1.BringToFront();
        }

        private void btnCustomerDetail_Click(object sender, EventArgs e)
        {
            PanelMoving.Left = btnCustomerDetail.Left + 60;
            uC_CustomerDetails1.Visible = true;
            uC_CustomerDetails1.BringToFront();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            if (roleid == 1)
            {
                PanelMoving.Left = btnEmployee.Left + 60;
                uC_Employee1.Visible = true;
                uC_Employee1.BringToFront();
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn đăng xuất?", "Thông tin", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Form1 frmLogin = new Form1();
                frmLogin.Show();
            }
            else if (result == DialogResult.No)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }

        }

        private void uC_Employee1_Load(object sender, EventArgs e)
        {

        }
    }
}