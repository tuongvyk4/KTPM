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
    public partial class FormQLKH_Theo_TP : Form
    {
        public FormQLKH_Theo_TP()
        {
            InitializeComponent();
            //đưa dữ liệu lên combo box
            //tải dữ liệu vào bảng
            DataTable dt = new DataTable();
            Unity.OpenConnection();
            dt = Unity.getDatatable("select TenThanhPho from ThanhPho");
            this.cbx_thanhpho.DataSource = dt;
            //this.cbx_thanhpho.DisplayMember = "TenThanhPho";
            this.cbx_thanhpho.DisplayMember = "TenThanhPho";
            this.cbx_thanhpho.ValueMember = "TenThanhPho";
            //đua trỏ
        }

        private void btn_trove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //hiển thị dữ liệu
        public void LoadDB(string sql)
        {
            Unity.OpenConnection();
            //truy xuất đến bản Khachang
            this.dataGridViewQLDMKH.DataSource = Unity.getDatatable(sql);
            this.dataGridViewQLDMKH.AutoResizeColumns();
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            //String sql = "select * from Khachhang kh, ThanhPho tp where kh.ThanhPho = tp.ThanhPho AND tp.TenThanhPho = "+cbx_thanhpho.Text;
            String sql = "select TenThanhPho as 'Tên Thành Phố' from ThanhPho";
            LoadDB(sql);
        }

       
    }
}
