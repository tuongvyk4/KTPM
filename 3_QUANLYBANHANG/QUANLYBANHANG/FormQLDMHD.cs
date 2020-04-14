using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUANLYBANHANG
{
    public partial class FormQLDMHD : Form
    {
        Boolean them;
        public FormQLDMHD()
        {
            InitializeComponent();
            String sql = "select * from HoaDon";
            LoadDB(sql);
            //không cho cthao tác trên nút lưu, hũy
            this.btn_luu.Enabled = false;
            this.btn_huybo.Enabled = false;
            this.panel.Enabled = false;
            //Cho thao tác trên nút Thêm/Sửa/Xóa/Trở về.
            this.btn_them.Enabled = true;
            this.btn_sua.Enabled = true;
            this.btn_xoa.Enabled = true;
            this.btn_trove.Enabled = true;
        }

        private void dataGridViewQLDMHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy thứ tự record hiện hành
            int r = dataGridViewQLDMHD.CurrentCell.RowIndex;
            //lay gia tri tu luoi len cac text
            this.txt_maHD.Text = dataGridViewQLDMHD.Rows[r].Cells[0].Value.ToString();
            //lay gia tri combobox KH + NV
            //tải dữ liệu vào bảng KH
            DataTable dt = new DataTable();
            Unity.OpenConnection();
            dt = Unity.getDatatable("select * from KhachHang");
            this.cbx_MaKH.DataSource = dt;
            this.cbx_MaKH.DisplayMember = "MaKH";
            this.cbx_MaKH.ValueMember = "MaKH";
            this.cbx_MaKH.Text = dataGridViewQLDMHD.Rows[r].Cells[1].Value.ToString();
            //tải dữ liệu vào bảng NV
            DataTable dt1 = new DataTable();
            Unity.OpenConnection();
            dt1 = Unity.getDatatable("select * from NhanVien");
            this.cbx_maNV.DataSource = dt1;
            this.cbx_maNV.DisplayMember = "MaNV";
            this.cbx_maNV.ValueMember = "MaNV";
            this.cbx_maNV.Text = dataGridViewQLDMHD.Rows[r].Cells[2].Value.ToString();
            //lay gia tri tu luoi len cac text
            this.txt_ngaylap.Text = dataGridViewQLDMHD.Rows[r].Cells[3].Value.ToString();
            this.txt_ngaynhan.Text = dataGridViewQLDMHD.Rows[r].Cells[4].Value.ToString();
            //đua trỏ
            this.txt_maHD.Focus();
        }

        private void btn_tailai_Click(object sender, EventArgs e)
        {
            String sql = "select * from Hoadon";
            LoadDB(sql);
            //khoi tao lai cac text
            this.txt_maHD.ResetText();
            this.txt_ngaylap.ResetText();
            this.txt_ngaynhan.ResetText();
            this.cbx_MaKH.ResetText();
            this.cbx_maNV.ResetText();
            //không cho cthao tác trên nút lưu, hũy
            this.btn_luu.Enabled = false;
            this.btn_huybo.Enabled = false;
            this.panel.Enabled = false;
            //Cho thao tác trên nút Thêm/Sửa/Xóa/Trở về.
            this.btn_them.Enabled = true;
            this.btn_sua.Enabled = true;
            this.btn_xoa.Enabled = true;
            this.btn_trove.Enabled = true;
        }

        //hiển thị dữ liệu
        public void LoadDB(string sql)
        {
            Unity.OpenConnection();
            //truy xuất đến bản Khachang
            this.dataGridViewQLDMHD.DataSource = Unity.getDatatable(sql);
            this.dataGridViewQLDMHD.AutoResizeColumns();
        }

        private void FormQLDMHD_Load(object sender, EventArgs e)
        {

        }

        private void btn_trove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_huybo_Click(object sender, EventArgs e)
        {
            //khoi tao lai cac text
            this.txt_maHD.ResetText();
            this.txt_ngaylap.ResetText();
            this.txt_ngaynhan.ResetText();
            this.cbx_MaKH.ResetText();
            this.cbx_maNV.ResetText();
            //cho thao tác trên nút thêm/sửa/xóa/trở về
            this.btn_them.Enabled = true;
            this.btn_sua.Enabled = true;
            this.btn_xoa.Enabled = true;
            this.btn_trove.Enabled = true;
            //Cho thao tác lưu, hủy và panel;
            this.btn_luu.Enabled = false;
            this.btn_huybo.Enabled = false;
            this.panel.Enabled = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            them = true;
            
            //khoi tao lai cac text
            this.txt_maHD.ResetText();
            this.txt_ngaylap.ResetText();
            this.txt_ngaynhan.ResetText();
            this.cbx_MaKH.ResetText();
            this.cbx_maNV.ResetText();
            //khong Cho thao tác trên nút Thêm/Sửa/Xóa/Trở về.
            this.btn_them.Enabled = false;
            this.btn_sua.Enabled = false;
            this.btn_xoa.Enabled = false;
            this.btn_trove.Enabled = false;
            //cho thao tác trên nút lưu, hũy
            this.btn_luu.Enabled = true;
            this.btn_huybo.Enabled = true;
            this.panel.Enabled = true;
            this.txt_maHD.Enabled = true;
            //đưa dữ liệu lên combo box
            //lấy thứ tự record hiện hành
            int r = dataGridViewQLDMHD.CurrentCell.RowIndex;
            //tải dữ liệu vào bảng KH
            DataTable dt = new DataTable();
            Unity.OpenConnection();
            dt = Unity.getDatatable("select * from KhachHang");
            this.cbx_MaKH.DataSource = dt;
            this.cbx_MaKH.DisplayMember = "MaKH";
            this.cbx_MaKH.ValueMember = "MaKH";
            this.cbx_MaKH.Text = dataGridViewQLDMHD.Rows[r].Cells[1].Value.ToString();
            //tải dữ liệu vào bảng NV
            DataTable dt1 = new DataTable();
            Unity.OpenConnection();
            dt1 = Unity.getDatatable("select * from NhanVien");
            this.cbx_maNV.DataSource = dt1;
            this.cbx_maNV.DisplayMember = "MaNV";
            this.cbx_maNV.ValueMember = "MaNV";
            this.cbx_maNV.Text = dataGridViewQLDMHD.Rows[r].Cells[2].Value.ToString();
            //đua trỏ
            this.txt_maHD.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            them = false;
            this.btn_them.Enabled = false;
            this.btn_sua.Enabled = false;
            this.btn_xoa.Enabled = false;
            this.btn_trove.Enabled = false;
            this.txt_maHD.Enabled = false;
            //cho thao tác trên nút lưu, hũy
            this.btn_luu.Enabled = true;
            this.btn_huybo.Enabled = true;
            this.panel.Enabled = true;
            //đua trỏ
            this.txt_maHD.Focus();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                //mở kế nối
                Unity.OpenConnection();
                //lấy thứ tự record hiện hành
                int r = dataGridViewQLDMHD.CurrentCell.RowIndex;
                //lấy thanhpho của record hiện hành
                string strmaHD = dataGridViewQLDMHD.Rows[r].Cells[0].Value.ToString();
                //câu lệnh SQL
                string sql = "Delete From HoaDon Where MaHD = '" + strmaHD + "'";
                //MessageBox.Show("sql xóa: " + sql, "Cảnh báo", MessageBoxButtons.OK);
                Unity.Excute(sql);
                //MessageBox.Show("chại đến đây", "Cảnh báo", MessageBoxButtons.OK);
                String sqlload = "select * from HoaDon";
                LoadDB(sqlload);
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                Unity.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi dữ liệu đã được dùng!", "Cảnh báo", MessageBoxButtons.OK);
            }
        }

        private void btn_tailai_Click_1(object sender, EventArgs e)
        {
            String sql = "select * from HoaDon";
            LoadDB(sql);
            //khoi tao lai cac text
            this.txt_maHD.ResetText();
            this.txt_ngaylap.ResetText();
            this.txt_ngaynhan.ResetText();
            this.cbx_maNV.ResetText();
            this.cbx_MaKH.ResetText();
            //không cho cthao tác trên nút lưu, hũy
            this.btn_luu.Enabled = false;
            this.btn_huybo.Enabled = false;
            this.panel.Enabled = false;
            //Cho thao tác trên nút Thêm/Sửa/Xóa/Trở về.
            this.btn_them.Enabled = true;
            this.btn_sua.Enabled = true;
            this.btn_xoa.Enabled = true;
            this.btn_trove.Enabled = true;
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            //mở kế nối
            Unity.OpenConnection();
            // MessageBox.Show("Biến thêm: " + them.ToString(), "Cảnh báo", MessageBoxButtons.OK);
            if (them)
            {
                try
                {
                    string sql = "Insert into HoaDon values(" + "N'" + this.txt_maHD.Text.ToString() + "',N'" + this.cbx_MaKH.Text.ToString() + "',N'" + this.cbx_maNV.Text.ToString() + "',N'" + this.txt_ngaylap.Text.ToString() + "',N'" + this.txt_ngaynhan.Text.ToString() + "')";
                    //MessageBox.Show("sql thêm: " + sql, "Cảnh báo", MessageBoxButtons.OK);
                    Unity.Excute(sql);
                    String sqlload = "select * from HoaDon";
                    LoadDB(sqlload);
                    MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                    Unity.Close();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Lỗi!", "Cảnh báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                //lấy thứ tự record hiện hành
                int r = dataGridViewQLDMHD.CurrentCell.RowIndex;
                //lấy thanhpho của record hiện hành
                string strMaHD = dataGridViewQLDMHD.Rows[r].Cells[0].Value.ToString();
                string sql = "Update HoaDon set MaHD = N'" + this.txt_maHD.Text.ToString() + "'," + "MaKH = N'" + this.cbx_MaKH.Text.ToString() + "'," + "MaNV = N'" + this.cbx_maNV.Text.ToString() + "'," + "NgaylapHD = N'" + this.txt_ngaylap.Text.ToString() + "'," + "Ngaynhanhang = N'" + this.txt_ngaynhan.Text.ToString() + "'where MaHD='" + strMaHD + "'";
                Unity.Excute(sql);
                String sqlload = "select * from HoaDon";
                LoadDB(sqlload);
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                Unity.Close();
            }
        }
    }
}
