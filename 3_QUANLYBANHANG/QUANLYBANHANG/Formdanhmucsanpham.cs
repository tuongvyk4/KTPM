using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QUANLYBANHANG
{
    public partial class Formdanhmucsanpham : Form
    {
        public Formdanhmucsanpham()
        {
            InitializeComponent();
            this.showData("Select TenSp , donvitinh, dongia from sanpham");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formdanhmucsanpham_FormClosing(object sender, FormClosingEventArgs e)
        {
            Unity.Close();
        }

        //hiển thị dữ liệu
        public void showData(string sql)
        {
            Unity.OpenConnection();
            //truy xuất đến bản Khachang
            dataGridViewDM.DataSource = Unity.getDatatable(sql);
            dataGridViewDM.AutoResizeColumns();
           // dataGridViewDM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void Formdanhmucsanpham_Load(object sender, EventArgs e)
        {

        }
    }
}
