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
    public partial class Formdanhmuckhachhang : Form
    {
        public Formdanhmuckhachhang()
        {
            InitializeComponent();
            //this.showData("Select MaKH as Mã Khách Hàng, TenCty as Tên Công Ty from KhachHang");
            this.showData("Select MaKH , TenCty from KhachHang");
        }

        //hiển thị dữ liệu
        public void showData(string sql)
        {
            Unity.OpenConnection();
            //truy xuất đến bản Khachang
            dataGridViewDM.DataSource = Unity.getDatatable(sql);
            dataGridViewDM.AutoResizeColumns();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formdanhmuckhachhang_Load(object sender, EventArgs e)
        {
            /*
            int intDM = Convert.ToInt32(this.Text);
            switch (intDM)
            {
                case 1:
                    lbl_DM.Text = "Danh mục Thành Phố";
                    dataGridViewDM.DataSource = Unity.getDatatable("Select ThanhPho, TenThanhPho from ThanhPho");
                    dataGridViewDM.AutoResizeColumns();
                    break;
                case 2:
                    lbl_DM.Text = "Danh mục Khách Hàng";
                    dataGridViewDM.DataSource = Unity.getDatatable("Select MaKH, TenCty from KhachHang");
                    dataGridViewDM.AutoResizeColumns();
                    break;
                case 3:
                    lbl_DM.Text = "Danh mục Nhân Viên";
                    dataGridViewDM.DataSource = Unity.getDatatable("Select MaNV, HoLot, Ten, Dienthoai from NhanVien");
                    dataGridViewDM.AutoResizeColumns();
                    break;
                case 4:
                    lbl_DM.Text = "Danh mục Sản Phẩm";
                    dataGridViewDM.DataSource = Unity.getDatatable("Select MaSP, TenSP, Donvitinh, Dongia from SanPham");
                    dataGridViewDM.AutoResizeColumns();
                    break;
                case 5:
                    lbl_DM.Text = "Danh mục Hóa Đơn";
                    dataGridViewDM.DataSource = Unity.getDatatable("Select MaHD, MaKH, MaNV from HoaDon");
                    dataGridViewDM.AutoResizeColumns();
                    break;
                case 6:
                    lbl_DM.Text = "Danh mục Chi Tiết Hóa Đơn";
                    dataGridViewDM.DataSource = Unity.getDatatable("Select * from ChiTietHoaDon");
                    dataGridViewDM.AutoResizeColumns();
                    break;
                default:
                    break;
            } */
        }

        private void dataGridViewDM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_DM_Click(object sender, EventArgs e)
        {

        }

        private void Formdanhmuckhachhang_FormClosing(object sender, FormClosingEventArgs e)
        {
            Unity.Close();
        }
           
      
    }
}
