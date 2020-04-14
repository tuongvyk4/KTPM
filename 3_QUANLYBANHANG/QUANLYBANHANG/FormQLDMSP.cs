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
    public partial class FormQLDMSP : Form
    {
        Boolean them;
        public FormQLDMSP()
        {
            InitializeComponent();
            String sql = "select * from sanpham";
            LoadDB(sql);
            //không cho cthao tác trên nút lưu, hũy
            btn_luu.Enabled = false;
            btn_huybo.Enabled = false;
            panel.Enabled = false;
            //Cho thao tác trên nút Thêm/Sửa/Xóa/Trở về.
            this.btn_them.Enabled = true;
            this.btn_sua.Enabled = true;
            this.btn_xoa.Enabled = true;
            this.btn_trove.Enabled = true;
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
            this.dataGridViewQLDMSP.DataSource = Unity.getDatatable(sql);
            this.dataGridViewQLDMSP.AutoResizeColumns();
        }

        private void FormQLDMSP_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewQLDMSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy thứ tự record hiện hành
            int r = dataGridViewQLDMSP.CurrentCell.RowIndex;
            //lay gia tri tu luoi len cac text
            this.txt_maSP.Text = dataGridViewQLDMSP.Rows[r].Cells[0].Value.ToString();
            this.txt_tensp.Text = dataGridViewQLDMSP.Rows[r].Cells[1].Value.ToString();
            this.txt_dvt.Text = dataGridViewQLDMSP.Rows[r].Cells[2].Value.ToString();
            this.txt_dongia.Text = dataGridViewQLDMSP.Rows[r].Cells[3].Value.ToString();
            //đua trỏ
            this.txt_maSP.Focus();
        }

        private void btn_huybo_Click(object sender, EventArgs e)
        {
            //khoi tao lai cac text
            this.txt_maSP.ResetText();
            this.txt_tensp.ResetText();
            this.txt_dongia.ResetText();
            this.txt_dvt.ResetText();
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

        private void btn_them_Click(object sender, EventArgs e)
        {
            them = true;
            //khoi tao lai cac text
            this.txt_maSP.ResetText();
            this.txt_tensp.ResetText();
            this.txt_dvt.ResetText();
            this.txt_dongia.ResetText();
            //khong Cho thao tác trên nút Thêm/Sửa/Xóa/Trở về.
            this.btn_them.Enabled = false;
            this.btn_sua.Enabled = false;
            this.btn_xoa.Enabled = false;
            this.btn_trove.Enabled = false;
            //cho thao tác trên nút lưu, hũy
            this.btn_luu.Enabled = true;
            this.btn_huybo.Enabled = true;
            this.panel.Enabled = true;
            this.txt_maSP.Enabled = true;
            //đua trỏ
            this.txt_maSP.Focus();
        }

        private void btn_tailai_Click(object sender, EventArgs e)
        {
            String sql = "select * from SanPham";
            LoadDB(sql);
            //khoi tao lai cac text
            this.txt_maSP.ResetText();
            this.txt_tensp.ResetText();
            this.txt_dvt.ResetText();
            this.txt_dongia.ResetText();
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

        private void btn_sua_Click(object sender, EventArgs e)
        {
            them = false;
            this.btn_them.Enabled = false;
            this.btn_sua.Enabled = false;
            this.btn_xoa.Enabled = false;
            this.btn_trove.Enabled = false;
            this.txt_maSP.Enabled = false;
            //cho thao tác trên nút lưu, hũy
            this.btn_luu.Enabled = true;
            this.btn_huybo.Enabled = true;
            this.panel.Enabled = true;
            //đua trỏ
            this.txt_maSP.Focus();
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
                    string sql = "Insert into SanPham values(" + "N'" + this.txt_maSP.Text.ToString() + "',N'" + this.txt_tensp.Text.ToString() + "',N'" + this.txt_dvt.Text.ToString() + "',N'" + this.txt_dongia.Text.ToString()+"','null'"+")";
                    MessageBox.Show("sql thêm: " + sql, "Cảnh báo", MessageBoxButtons.OK);
                    Unity.Excute(sql);
                    String sqlload = "select * from SanPham";
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
                int r = dataGridViewQLDMSP.CurrentCell.RowIndex;
                //lấy thanhpho của record hiện hành
                string strMaSP = dataGridViewQLDMSP.Rows[r].Cells[0].Value.ToString();
                string sql = "Update SanPham set MaSP = N'" + this.txt_maSP.Text.ToString() + "'," + "TenSP = N'" + this.txt_tensp.Text.ToString() + "'," + "Donvitinh = N'" + this.txt_dvt.Text.ToString() + "'," + "Dongia = N'" + this.txt_dongia.Text.ToString() + "',Hinh = 'null' where MaSP='" + strMaSP + "'";
                MessageBox.Show("chuoi: " + sql.ToString(), "Cảnh báo", MessageBoxButtons.OK);
                Unity.Excute(sql);
                String sqlload = "select * from SanPham";
                LoadDB(sqlload);
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                Unity.Close();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                //mở kế nối
                Unity.OpenConnection();
                //lấy thứ tự record hiện hành
                int r = dataGridViewQLDMSP.CurrentCell.RowIndex;
                //lấy thanhpho của record hiện hành
                string strmaSP = dataGridViewQLDMSP.Rows[r].Cells[0].Value.ToString();
                //câu lệnh SQL
                string sql = "Delete From SanPham Where MaSP = '" + strmaSP + "'";
                //MessageBox.Show("sql xóa: " + sql, "Cảnh báo", MessageBoxButtons.OK);
                Unity.Excute(sql);
                //MessageBox.Show("chại đến đây", "Cảnh báo", MessageBoxButtons.OK);
                String sqlload = "select * from SanPham";
                LoadDB(sqlload);
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                Unity.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi dữ liệu đã được dùng!", "Cảnh báo", MessageBoxButtons.OK);
            }
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
