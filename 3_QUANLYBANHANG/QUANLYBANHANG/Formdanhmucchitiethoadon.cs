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
    public partial class Formdanhmucchitiethoadon : Form
    {
        public Formdanhmucchitiethoadon()
        {
            InitializeComponent();
            this.showData("Select MaHD , MasP, Soluong from Chitiethoadon");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formdanhmucchitiethoadon_FormClosing(object sender, FormClosingEventArgs e)
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

        private void Formdanhmucchitiethoadon_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewDM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
