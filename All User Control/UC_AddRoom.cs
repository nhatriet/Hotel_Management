﻿using System;
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
    public partial class UC_AddRoom : UserControl
    {
        private string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=Hotel_Encrypt;Integrated Security=True";

        function fn = new function();

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;

        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void LoadRoomData()
        {
            this.showComboBox();
            string query = "select * from RoomView";
            /* SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgwAddRoom.DataSource = table;*/
            DataSet ds = fn.getData(query);
            dgwAddRoom.DataSource = ds.Tables[0];
           
        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            LoadRoomData();
        }

        public void showComboBox()
        {
            conn = fn.getConnection();
            conn.Open();

            cmd = new SqlCommand("select typeid, typedescription from roomtypes", conn);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable table = new DataTable();
            da.Fill(table);
            txtRoomType.DataSource = table;
            txtRoomType.DisplayMember = "typedescription";
            txtRoomType.ValueMember = "typeid";
            conn.Close(); 
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text != "" && txtRoomType.Text != "" && txtPrice.Text != "")
            {
                String roomno = txtRoomNo.Text;
                String typedescription = txtRoomType.SelectedItem.ToString();
                Int64 price = Int64.Parse(txtPrice.Text);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand("AddRoom", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        command.Parameters.AddWithValue("@RoomNo", roomno);
                        command.Parameters.AddWithValue("@TypeDescription", typedescription);
                        command.Parameters.AddWithValue("@Price", price);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();
                        connection.Close();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Đã thêm phòng.");
                            UC_AddRoom_Load(this, null);
                            clearAll();
                        }
                        else
                        {
                            MessageBox.Show("Xin vui lòng điền đầy đủ thông tin!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
        }

        public void clearAll()
        {
            txtRoomNo.Clear();
            txtRoomType.SelectedIndex = -1;
            txtPrice.Clear();
        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this, null);
        }
    }

    // ====================================

    /*public partial class UC_AddRoom : UserControl
    {
        function fn = new function();

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;

        String query;
        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds = fn.getData(query);
            dgwAddRoom.DataSource = ds.Tables[0];
            this.showComboBox();
        }

        public void showComboBox()
        {
            conn = fn.getConnection();
            conn.Open();
            cmd = new SqlCommand("select * from roomtypes, conn");
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;

            DataTable table = new DataTable();
            da.Fill(table);
            txtRoomType.DataSource = table;
            txtRoomType.DisplayMember = "typedescription";
            txtRoomType.ValueMember = "typeid";
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomNo.Text != "" && txtRoomType.Text != "" && txtPrice.Text != "")
            {
                String roomno = txtRoomNo.Text;
                String type = txtRoomType.Text;
                Int64 price = Int64.Parse(txtPrice.Text);

                query = "insert into rooms (roomNo, roomType, price) values " +
                    "('" + roomno + "','" + type + "', " + price + ")";

                fn.setData(query, "Đã thêm phòng");

                *//*fn.setData("sp_ins_rooms", new List<SqlParameter>()
                {
                    new SqlParameter("@roomNo", roomno),
                    new SqlParameter("@booked", 0),
                    new SqlParameter("@typeid", )
                })*//*

                UC_AddRoom_Load(this, null);
                clearAll();
            }
            else
            {
                MessageBox.Show("Xin vui lòng điền đầy đủ thông tin!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void clearAll()
        {
            txtRoomNo.Clear();
            txtRoomType.SelectedIndex = -1;
            txtPrice.Clear();
        }

        private void UC_AddRoom_Leave(object sender, EventArgs e)
        {
            clearAll();
        }

        private void UC_AddRoom_Enter(object sender, EventArgs e)
        {
            UC_AddRoom_Load(this, null);
        }
    }*/
}
