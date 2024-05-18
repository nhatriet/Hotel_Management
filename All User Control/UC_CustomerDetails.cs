using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace HotelManagement.All_User_Control
{
    public partial class UC_CustomerDetails : UserControl
    {
        function fn = new function();
        String SP;
        public UC_CustomerDetails()
        {
            InitializeComponent();
        }
        private void txtSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtSearchBy.SelectedIndex == 0)
            {
                SP = "AllCustomDetails";
                getRecord(SP);
            }
            else if (txtSearchBy.SelectedIndex == 1)
            {
                SP = "InHotelCustomer";
                getRecord(SP);
            }
            else if (txtSearchBy.SelectedIndex == 2)
            {
                SP = "CheckoutCustomer";
                getRecord(SP);
            }
        }

        private void getRecord(String SP)
        {
            SqlConnection con = fn.getConnection();
            
            SqlCommand cmd = new SqlCommand(SP, con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dgwCustomerDetail.DataSource = ds.Tables[0];
        }
    }
}
