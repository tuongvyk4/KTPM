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
    public partial class FormQLDMNV : Form
    {
        Boolean them;
        public FormQLDMNV()
        {
            InitializeComponent();
            String sql = "select * from NhanVien";
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

        //hiển thị dữ liệu
        public void LoadDB(string sql)
        {
            Unity.OpenConnection();
            //truy xuất đến bản Khachang
            this.dataGridViewQLDMNV.DataSource = Unity.getDatatable(sql);
            this.dataGridViewQLDMNV.AutoResizeColumns();
        }

        private void FormQLDMNV_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewQLDMNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy thứ tự record hiện hành
            int r = dataGridViewQLDMNV.CurrentCell.RowIndex;
            //lay gia tri tu luoi len cac text
            this.txt_maNV.Text = dataGridViewQLDMNV.Rows[r].Cells[0].Value.ToString();
            this.txt_holot.Text = dataGridViewQLDMNV.Rows[r].Cells[1].Value.ToString();
            this.txt_ten.Text = dataGridViewQLDMNV.Rows[r].Cells[2].Value.ToString();
            this.txt_ngaysinh.Text = dataGridViewQLDMNV.Rows[r].Cells[3].Value.ToString();
            this.txt_diachi.Text = dataGridViewQLDMNV.Rows[r].Cells[4].Value.ToString();
            this.txt_dienthoai.Text = dataGridViewQLDMNV.Rows[r].Cells[5].Value.ToString();
            //đua trỏ
            this.txt_maNV.Focus();
        }

        private void btn_huybo_Click(object sender, EventArgs e)
        {
            //khoi tao lai cac text
            this.txt_maNV.ResetText();
            this.txt_holot.ResetText();
            this.txt_ten.ResetText();
            this.txt_ngaysinh.ResetText();
            this.txt_diachi.ResetText();
            this.txt_dienthoai.ResetText();
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

        private void btn_tailai_Click(object sender, EventArgs e)
        {
            String sql = "select * from NhanVien";
            LoadDB(sql);
            //khoi tao lai cac text
            this.txt_maNV.ResetText();
            this.txt_holot.ResetText();
            this.txt_ten.ResetText();
            this.txt_ngaysinh.ResetText();
            this.txt_diachi.ResetText();
            this.txt_dienthoai.ResetText();
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

        private void btn_them_Click(object sender, EventArgs e)
        {
            them = true;
            //khoi tao lai cac text
            this.txt_maNV.ResetText();
            this.txt_holot.ResetText();
            this.txt_ten.ResetText();
            this.txt_ngaysinh.ResetText();
            this.txt_diachi.ResetText();
            this.txt_dienthoai.ResetText();
            //khong Cho thao tác trên nút Thêm/Sửa/Xóa/Trở về.
            this.btn_them.Enabled = false;
            this.btn_sua.Enabled = false;
            this.btn_xoa.Enabled = false;
            this.btn_trove.Enabled = false;
            //cho thao tác trên nút lưu, hũy
            this.btn_luu.Enabled = true;
            this.btn_huybo.Enabled = true;
            this.panel.Enabled = true;
            this.txt_maNV.Enabled = true;
            //đua trỏ
            this.txt_maNV.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            them = false;
            this.btn_them.Enabled = false;
            this.btn_sua.Enabled = false;
            this.btn_xoa.Enabled = false;
            this.btn_trove.Enabled = false;
            this.txt_maNV.Enabled = false;
            //cho thao tác trên nút lưu, hũy
            this.btn_luu.Enabled = true;
            this.btn_huybo.Enabled = true;
            this.panel.Enabled = true;
            //đua trỏ
            this.txt_maNV.Focus();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                //mở kế nối
                Unity.OpenConnection();
                //lấy thứ tự record hiện hành
                int r = dataGridViewQLDMNV.CurrentCell.RowIndex;
                //lấy thanhpho của record hiện hành
                string strmaNV = dataGridViewQLDMNV.Rows[r].Cells[0].Value.ToString();
                //câu lệnh SQL
                string sql = "Delete From nhanvien Where MaNV = '" + strmaNV + "'";
                //MessageBox.Show("sql xóa: " + sql, "Cảnh báo", MessageBoxButtons.OK);
                Unity.Excute(sql);
                //MessageBox.Show("chại đến đây", "Cảnh báo", MessageBoxButtons.OK);
                String sqlload = "select * from Nhanvien";
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
                    string sql = "Insert into NhanVien values(" + "N'" + this.txt_maNV.Text.ToString() + "',N'" + this.txt_holot.Text.ToString() + "',N'" + this.txt_ten.Text.ToString() + "',N'" + this.txt_ngaysinh.Text.ToString() + "',N'" + this.txt_diachi.Text.ToString() + "',N'" + this.txt_dienthoai.Text.ToString() + "')";
                    MessageBox.Show("sql thêm: " + sql, "Cảnh báo", MessageBoxButtons.OK);
                    Unity.Excute(sql);
                    String sqlload = "select * from NhanVien";
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
                int r = dataGridViewQLDMNV.CurrentCell.RowIndex;
                //lấy thanhpho của record hiện hành
                string strMaNV = dataGridViewQLDMNV.Rows[r].Cells[0].Value.ToString();
                string sql = "Update NhanVien set MaNV = N'" + this.txt_maNV.Text.ToString() + "'," + "Holot = N'" + this.txt_holot.Text.ToString() + "'," + "Ten = N'" + this.txt_ten.Text.ToString() + "'," + "Ngaysinh = N'" + this.txt_ngaysinh.Text.ToString() + "',"  + "Diachi = N'" + this.txt_diachi.Text.ToString() +"',"+ "Dienthoai = N'" + this.txt_dienthoai.Text.ToString() + "'where MaNV='" + strMaNV + "'";
                MessageBox.Show("chuoi: " + sql.ToString(), "Cảnh báo", MessageBoxButtons.OK);
                Unity.Excute(sql);
                String sqlload = "select * from NhanVien";
                LoadDB(sqlload);
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                Unity.Close();
            }
        }

      

       
    }
}
