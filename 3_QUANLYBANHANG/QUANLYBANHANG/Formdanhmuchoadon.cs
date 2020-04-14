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
    public partial class Formdanhmuchoadon : Form
    {
        public Formdanhmuchoadon()
        {
            InitializeComponent();
            this.showData("Select MaHD , MaKH, MaNV from Hoadon");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formdanhmuchoadon_FormClosing(object sender, FormClosingEventArgs e)
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
            //dataGridViewDM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void Formdanhmuchoadon_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewDM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
