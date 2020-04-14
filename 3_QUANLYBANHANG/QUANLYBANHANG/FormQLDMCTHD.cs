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
    public partial class FormQLDMCTHD : Form
    {
        Boolean them;
        public FormQLDMCTHD()
        {
            InitializeComponent();
            String sql = "select * from Chitiethoadon";
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

        private void btn_trove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewQLDMCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy thứ tự record hiện hành
            int r = dataGridViewQLDMCTHD.CurrentCell.RowIndex;
            //lay gia tri tu luoi len cac text
            this.txt_soluong.Text = dataGridViewQLDMCTHD.Rows[r].Cells[2].Value.ToString();
            //lay gia tri combobox HD + SP
            //tải dữ liệu vào bảng HD
            DataTable dt = new DataTable();
            Unity.OpenConnection();
            dt = Unity.getDatatable("select * from HoaDon");
            this.cbx_MaHD.DataSource = dt;
            this.cbx_MaHD.DisplayMember = "MaHD";
            this.cbx_MaHD.ValueMember = "MaHD";
            this.cbx_MaHD.Text = dataGridViewQLDMCTHD.Rows[r].Cells[0].Value.ToString();
            //tải dữ liệu vào bảng SP
            DataTable dt1 = new DataTable();
            Unity.OpenConnection();
            dt1 = Unity.getDatatable("select * from SanPham");
            this.cbx_maSP.DataSource = dt1;
            this.cbx_maSP.DisplayMember = "MaSP";
            this.cbx_maSP.ValueMember = "MaSP";
            this.cbx_maSP.Text = dataGridViewQLDMCTHD.Rows[r].Cells[1].Value.ToString();
            //đua trỏ
            this.cbx_MaHD.Focus();
        }

        //hiển thị dữ liệu
        public void LoadDB(string sql)
        {
            Unity.OpenConnection();
            //truy xuất đến bản Khachang
            this.dataGridViewQLDMCTHD.DataSource = Unity.getDatatable(sql);
            this.dataGridViewQLDMCTHD.AutoResizeColumns();
        }

        private void FormQLDMCTHD_Load(object sender, EventArgs e)
        {

        }

        private void btn_tailai_Click(object sender, EventArgs e)
        {
            String sql = "select * from Chitiethoadon";
            LoadDB(sql);
            //khoi tao lai cac text
            this.cbx_MaHD.ResetText();
            this.cbx_maSP.ResetText();
            this.txt_soluong.ResetText();
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

        private void btn_huybo_Click(object sender, EventArgs e)
        {
            //khoi tao lai cac text
            this.cbx_MaHD.ResetText();
            this.cbx_maSP.ResetText();
            this.txt_soluong.ResetText();
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
            this.cbx_MaHD.ResetText();
            this.cbx_maSP.ResetText();
            this.txt_soluong.ResetText();
            //khong Cho thao tác trên nút Thêm/Sửa/Xóa/Trở về.
            this.btn_them.Enabled = false;
            this.btn_sua.Enabled = false;
            this.btn_xoa.Enabled = false;
            this.btn_trove.Enabled = false;
            //cho thao tác trên nút lưu, hũy
            this.btn_luu.Enabled = true;
            this.btn_huybo.Enabled = true;
            this.panel.Enabled = true;
            this.cbx_MaHD.Enabled = true;
            //đưa dữ liệu lên combo box
            //lấy thứ tự record hiện hành
            int r = dataGridViewQLDMCTHD.CurrentCell.RowIndex;
            //tải dữ liệu vào bảng HD
            DataTable dt = new DataTable();
            Unity.OpenConnection();
            dt = Unity.getDatatable("select * from HoaDon");
            this.cbx_MaHD.DataSource = dt;
            this.cbx_MaHD.DisplayMember = "MaHD";
            this.cbx_MaHD.ValueMember = "MaHD";
            this.cbx_MaHD.Text = dataGridViewQLDMCTHD.Rows[r].Cells[0].Value.ToString();
            Unity.Close();
            //tải dữ liệu vào bảng SP
            DataTable dt1 = new DataTable();
            Unity.OpenConnection();
            dt1 = Unity.getDatatable("select * from SanPham");
            this.cbx_maSP.DataSource = dt1;
            this.cbx_maSP.DisplayMember = "MaSP";
            this.cbx_maSP.ValueMember = "MaSP";
            this.cbx_maSP.Text = dataGridViewQLDMCTHD.Rows[r].Cells[1].Value.ToString();
            Unity.Close();
            //đua trỏ
            this.cbx_MaHD.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            them = false;
            this.btn_them.Enabled = false;
            this.btn_sua.Enabled = false;
            this.btn_xoa.Enabled = false;
            this.btn_trove.Enabled = false;
            this.cbx_MaHD.Enabled = false;
            //cho thao tác trên nút lưu, hũy
            this.btn_luu.Enabled = true;
            this.btn_huybo.Enabled = true;
            this.panel.Enabled = true;
            //đua trỏ
            this.cbx_MaHD.Focus();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                //mở kế nối
                Unity.OpenConnection();
                //lấy thứ tự record hiện hành
                int r = dataGridViewQLDMCTHD.CurrentCell.RowIndex;
                //lấy thanhpho của record hiện hành
                string strmaHD = dataGridViewQLDMCTHD.Rows[r].Cells[0].Value.ToString();
                //câu lệnh SQL
                //string sql = "Delete From Chitiethoadon Where MaHD = '" + strmaHD + "'";
                string sql = "Delete From Chitiethoadon where MaHD=N'" + dataGridViewQLDMCTHD.Rows[r].Cells[0].Value.ToString() + "' AND MaSP =N'" + dataGridViewQLDMCTHD.Rows[r].Cells[1].Value.ToString() + "' AND Soluong =N'" + dataGridViewQLDMCTHD.Rows[r].Cells[2].Value.ToString() + "'";
                //MessageBox.Show("sql xóa: " + sql, "Cảnh báo", MessageBoxButtons.OK);
                Unity.Excute(sql);
                //MessageBox.Show("chại đến đây", "Cảnh báo", MessageBoxButtons.OK);
                String sqlload = "select * from Chitiethoadon";
                LoadDB(sqlload);
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                Unity.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi dữ liệu đã được dùng!", "Cảnh báo", MessageBoxButtons.OK);
            }
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
                    string sql = "Insert into Chitiethoadon values(" + "N'" + this.cbx_MaHD.Text.ToString() + "',N'" + this.cbx_maSP.Text.ToString() + "',N'" + this.txt_soluong.Text.ToString() + "')";
                    //MessageBox.Show("sql thêm: " + sql, "Cảnh báo", MessageBoxButtons.OK);
                    Unity.Excute(sql);
                    String sqlload = "select * from Chitiethoadon";
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
                int r = dataGridViewQLDMCTHD.CurrentCell.RowIndex;
                //lấy thanhpho của record hiện hành
                string strMaHD = dataGridViewQLDMCTHD.Rows[r].Cells[0].Value.ToString();
                string sql = "Update Chitiethoadon set MaHD = N'" + this.cbx_MaHD.Text.ToString() + "'," + "MaSP = N'" + this.cbx_maSP.Text.ToString() + "'," + "Soluong = N'" + this.txt_soluong.Text.ToString() + "'where MaHD=N'" + dataGridViewQLDMCTHD.Rows[r].Cells[0].Value.ToString() + "' AND MaSP =N'" + dataGridViewQLDMCTHD.Rows[r].Cells[1].Value.ToString() + "' AND Soluong =N'" + dataGridViewQLDMCTHD.Rows[r].Cells[2].Value.ToString() + "'";
                MessageBox.Show("sql sửa: " + sql, "Cảnh báo", MessageBoxButtons.OK);
                Unity.Excute(sql);
                String sqlload = "select * from Chitiethoadon";
                LoadDB(sqlload);
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                Unity.Close();
            }
        }
        
    }
}
