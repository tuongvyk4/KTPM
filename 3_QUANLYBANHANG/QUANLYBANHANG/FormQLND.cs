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
    public partial class FormQLND : Form
    {
        Boolean them;
        public FormQLND()
        {
            InitializeComponent();
            String sql = "select * from nguoidung";
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
            //lam trong suot
            this.panel.BackColor = Color.Transparent;
            //this.dataGridViewTK.BackgroundColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_trove_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewTK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy thứ tự record hiện hành
            int r = dataGridViewTK.CurrentCell.RowIndex;
            //lay gia tri tu luoi len cac text
            this.txt_taikhoan.Text = dataGridViewTK.Rows[r].Cells[0].Value.ToString();
            this.txt_matkhau.Text = dataGridViewTK.Rows[r].Cells[1].Value.ToString();
            //lay gia tri combobox Vai trò
            DataTable dt = new DataTable();
            Unity.OpenConnection();
            dt = Unity.getDatatable("select * from nguoidung");
            this.cbx_VT.DataSource = dt;
            this.cbx_VT.DisplayMember = "Vaitro";
            this.cbx_VT.ValueMember = "Vaitro";
            this.cbx_VT.Text = dataGridViewTK.Rows[r].Cells[2].Value.ToString();
            //đua trỏ
            this.txt_taikhoan.Focus();
        }

        private void btn_huybo_Click(object sender, EventArgs e)
        {
            //khoi tao lai cac text
            this.txt_taikhoan.ResetText();
            this.txt_matkhau.ResetText();
            this.cbx_VT.ResetText();
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

        private void FormQLND_Load(object sender, EventArgs e)
        {

        }

        private void btn_tailai_Click(object sender, EventArgs e)
        {
            String sql = "select * from nguoidung";
            LoadDB(sql);
            //khoi tao lai cac text
            this.cbx_VT.ResetText();
            this.txt_taikhoan.ResetText();
            this.txt_matkhau.ResetText();
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

        public void LoadDB(string sql)
        {
            Unity.OpenConnection();
            //truy xuất đến bản Khachang
            this.dataGridViewTK.DataSource = Unity.getDatatable(sql);
            this.dataGridViewTK.AutoResizeColumns();
            Unity.Close();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                //mở kế nối
                Unity.OpenConnection();
                //lấy thứ tự record hiện hành
                int r = dataGridViewTK.CurrentCell.RowIndex;
                //lấy thanhpho của record hiện hành
                string strtaikhoan = dataGridViewTK.Rows[r].Cells[0].Value.ToString();
                //câu lệnh SQL
                //string sql = "Delete From Chitiethoadon Where MaHD = '" + strmaHD + "'";
                string sql = "Delete From NguoiDung where taikhoan=N'" + strtaikhoan + "'";
                //MessageBox.Show("sql xóa: " + sql, "Cảnh báo", MessageBoxButtons.OK);
                Unity.Excute(sql);
                //MessageBox.Show("chại đến đây", "Cảnh báo", MessageBoxButtons.OK);
                String sqlload = "select * from NguoiDung";
                LoadDB(sqlload);
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                Unity.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi dữ liệu đã được dùng!", "Cảnh báo", MessageBoxButtons.OK);
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            them = true;
            //khoi tao lai cac text
            this.txt_taikhoan.ResetText();
            this.cbx_VT.ResetText();
            this.txt_matkhau.ResetText();
            //khong Cho thao tác trên nút Thêm/Sửa/Xóa/Trở về.
            this.btn_them.Enabled = false;
            this.btn_sua.Enabled = false;
            this.btn_xoa.Enabled = false;
            this.btn_trove.Enabled = false;
            //cho thao tác trên nút lưu, hũy
            this.btn_luu.Enabled = true;
            this.btn_huybo.Enabled = true;
            this.panel.Enabled = true;
            this.txt_taikhoan.Enabled = true;
            //đưa dữ liệu lên combo box
            //lấy thứ tự record hiện hành
            int r = dataGridViewTK.CurrentCell.RowIndex;
            //tải dữ liệu vào bảng VT
            DataTable dt = new DataTable();
            Unity.OpenConnection();
            dt = Unity.getDatatable("select * from Nguoidung");
            this.cbx_VT.DataSource = dt;
            this.cbx_VT.DisplayMember = "Vaitro";
            this.cbx_VT.ValueMember = "Vaitro";
            this.cbx_VT.Text = dataGridViewTK.Rows[r].Cells[2].Value.ToString();
            Unity.Close();
            //đua trỏ
            this.txt_taikhoan.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            them = false;
            this.btn_them.Enabled = false;
            this.btn_sua.Enabled = false;
            this.btn_xoa.Enabled = false;
            this.btn_trove.Enabled = false;
            this.txt_taikhoan.Enabled = false;
            //cho thao tác trên nút lưu, hũy
            this.btn_luu.Enabled = true;
            this.btn_huybo.Enabled = true;
            this.panel.Enabled = true;
            //đua trỏ
            this.txt_taikhoan.Focus();
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
                    string sql = "Insert into nguoidung values(" + "N'" + this.txt_taikhoan.Text.ToString() + "',N'" + this.txt_matkhau.Text.ToString() + "',N'" + this.cbx_VT.Text.ToString() + "')";
                    //MessageBox.Show("sql thêm: " + sql, "Cảnh báo", MessageBoxButtons.OK);
                    Unity.Excute(sql);
                    String sqlload = "select * from nguoidung";
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
                int r = dataGridViewTK.CurrentCell.RowIndex;
                string sql = "Update nguoidung set taikhoan = N'" + this.txt_taikhoan.Text.ToString() + "'," + "matkhau = N'" + this.txt_matkhau.Text.ToString() + "'," + "Vaitro = N'" + this.cbx_VT.Text.ToString() + "'where taikhoan=N'" + dataGridViewTK.Rows[r].Cells[0].Value.ToString() + "' AND matkhau =N'" + dataGridViewTK.Rows[r].Cells[1].Value.ToString() + "' AND Vaitro =N'" + dataGridViewTK.Rows[r].Cells[2].Value.ToString() + "'";
                //MessageBox.Show("sql sửa: " + sql, "Cảnh báo", MessageBoxButtons.OK);
                Unity.Excute(sql);
                String sqlload = "select * from nguoidung";
                LoadDB(sqlload);
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                Unity.Close();
            }
        }
    }
}
