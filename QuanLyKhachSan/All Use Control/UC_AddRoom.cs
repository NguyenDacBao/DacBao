﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.All_Use_Control
{
    public partial class UC_AddRoom : UserControl
    {
        function fn = new function();
        string query;

        public UC_AddRoom()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void UC_AddRoom_Load(object sender, EventArgs e)
        {
            query = "select * from rooms";
            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (txtRoomno.Text != "" && txtRoomType.Text != "" && txtgiuong.Text!=""&& txtPrice.Text != "")
            {
                String roomno = txtRoomno.Text;
                String type = txtRoomType.Text;
                string bed = txtgiuong.Text;
                Int64 price = Int64.Parse(txtPrice.Text);


                query = "insert into rooms (roomNo,roomtype,bed , price) values('" + roomno + "','" + type + "','"+bed+"','" + price + "')";
                fn.setData(query, "Đã Thêm Phòng");

                UC_AddRoom_Load(this, null);
                clearAll();
            }
        }
        public void clearAll()
        {
            txtRoomno.Clear();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}