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
    public partial class FormQLDMKH : Form
    {
        Boolean them;
        public FormQLDMKH()
        {
            InitializeComponent();
            String sql = "select * from Khachhang";
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

        private void btn_tailai_Click(object sender, EventArgs e)
        {
            String sql = "select * from Khachhang";
            LoadDB(sql);
            //khoi tao lai cac text
            this.txt_diachi.ResetText();
            this.txt_dienthoai.ResetText();
            this.txt_maKH.ResetText();
            this.txt_tencongty.ResetText();
            this.cbx_thanhpho.ResetText();
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

        //hiển thị dữ liệu
        public void LoadDB(string sql)
        {
            Unity.OpenConnection();
            //truy xuất đến bản Khachang
            this.dataGridViewQLDMKH.DataSource = Unity.getDatatable(sql);
            this.dataGridViewQLDMKH.AutoResizeColumns();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            them = true;
            //khoi tao lai cac text
            this.txt_diachi.ResetText();
            this.txt_dienthoai.ResetText();
            this.txt_maKH.ResetText();
            this.txt_tencongty.ResetText();
            this.cbx_thanhpho.ResetText();
            //khong Cho thao tác trên nút Thêm/Sửa/Xóa/Trở về.
            this.btn_them.Enabled = false;
            this.btn_sua.Enabled = false;
            this.btn_xoa.Enabled = false;
            this.btn_trove.Enabled = false;
            //cho thao tác trên nút lưu, hũy
            this.btn_luu.Enabled = true;
            this.btn_huybo.Enabled = true;
            this.panel.Enabled = true;
            this.txt_maKH.Enabled = true;
            //đưa dữ liệu lên combo box
            //tải dữ liệu vào bảng
            DataTable dt = new DataTable();
            Unity.OpenConnection();
            dt = Unity.getDatatable("select * from ThanhPho");
            this.cbx_thanhpho.DataSource = dt;
            //this.cbx_thanhpho.DisplayMember = "TenThanhPho";
            this.cbx_thanhpho.DisplayMember = "ThanhPho";
            this.cbx_thanhpho.ValueMember = "ThanhPho";
            //đua trỏ
            this.txt_maKH.Focus();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            them = false;
            //lấy thứ tự record hiện hành
            //int r = dataGridViewQLDMKH.CurrentCell.RowIndex;
            //lay gia tri tu luoi len cac text
            //this.txt_maKH.Text = dataGridViewQLDMKH.Rows[r].Cells[0].Value.ToString();
            //this.txt_diachi.Text = dataGridViewQLDMKH.Rows[r].Cells[2].Value.ToString();
            //this.txt_dienthoai.Text = dataGridViewQLDMKH.Rows[r].Cells[4].Value.ToString();
            //this.txt_tencongty.Text = dataGridViewQLDMKH.Rows[r].Cells[1].Value.ToString();
            //this.cbx_thanhpho.Text = dataGridViewQLDMKH.Rows[r].Cells[3].Value.ToString();
            //khong Cho thao tác trên nút Thêm/Sửa/Xóa/Trở về.
            this.btn_them.Enabled = false;
            this.btn_sua.Enabled = false;
            this.btn_xoa.Enabled = false;
            this.btn_trove.Enabled = false;
            this.txt_maKH.Enabled = false;
            //cho thao tác trên nút lưu, hũy
            this.btn_luu.Enabled = true;
            this.btn_huybo.Enabled = true;
            this.panel.Enabled = true;
            //đua trỏ
            this.txt_maKH.Focus();
        }

        private void dataGridViewQLDMKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //lấy thứ tự record hiện hành
            int r = dataGridViewQLDMKH.CurrentCell.RowIndex;
            //lay gia tri tu luoi len cac text
            this.txt_maKH.Text = dataGridViewQLDMKH.Rows[r].Cells[0].Value.ToString();
            this.txt_diachi.Text = dataGridViewQLDMKH.Rows[r].Cells[2].Value.ToString();
            this.txt_dienthoai.Text = dataGridViewQLDMKH.Rows[r].Cells[4].Value.ToString();
            this.txt_tencongty.Text = dataGridViewQLDMKH.Rows[r].Cells[1].Value.ToString();
            //this.txt_maKH.Enabled = false;
            //tải dữ liệu vào bảng
            DataTable dt = new DataTable();
            Unity.OpenConnection();
            dt = Unity.getDatatable("select * from ThanhPho");
            this.cbx_thanhpho.DataSource = dt;
            this.cbx_thanhpho.DisplayMember = "ThanhPho";
            this.cbx_thanhpho.ValueMember = "ThanhPho";
            //đua trỏ
            this.cbx_thanhpho.Text = dataGridViewQLDMKH.Rows[r].Cells[3].Value.ToString();
            this.txt_maKH.Focus();
            
         
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                //mở kế nối
                Unity.OpenConnection();
                //lấy thứ tự record hiện hành
                int r = dataGridViewQLDMKH.CurrentCell.RowIndex;
                //lấy thanhpho của record hiện hành
                string strmaKH = dataGridViewQLDMKH.Rows[r].Cells[0].Value.ToString();
                //câu lệnh SQL
                string sql = "Delete From Khachhang Where MaKH = '" + strmaKH + "'";
                //MessageBox.Show("sql xóa: " + sql, "Cảnh báo", MessageBoxButtons.OK);
                Unity.Excute(sql);
                //MessageBox.Show("chại đến đây", "Cảnh báo", MessageBoxButtons.OK);
                String sqlload = "select * from Khachhang";
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
                    string sql = "Insert into KhachHang values(" + "N'" + this.txt_maKH.Text.ToString() + "',N'" + this.txt_tencongty.Text.ToString() + "',N'" + this.txt_diachi.Text.ToString() + "',N'" + this.cbx_thanhpho.Text.ToString() +"',N'" + this.txt_dienthoai.Text.ToString() + "')";
                    //MessageBox.Show("sql thêm: " + sql, "Cảnh báo", MessageBoxButtons.OK);
                    Unity.Excute(sql);
                    String sqlload = "select * from Khachhang";
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
                int r = dataGridViewQLDMKH.CurrentCell.RowIndex;
                //lấy thanhpho của record hiện hành
                string strMaKH = dataGridViewQLDMKH.Rows[r].Cells[0].Value.ToString();
                string sql = "Update KhachHang set MaKH = N'" + this.txt_maKH.Text.ToString() + "',"+"TenCty = N'" + this.txt_tencongty.Text.ToString() + "',"+"Diachi = N'" + this.txt_diachi.Text.ToString() + "',"+"ThanhPho = N'" + this.cbx_thanhpho.Text.ToString() + "',"+"Dienthoai = N'" + this.txt_dienthoai.Text.ToString() + "'where MaKH='" + strMaKH + "'";
                Unity.Excute(sql);
                String sqlload = "select * from Khachhang";
                LoadDB(sqlload);
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                Unity.Close();
            }
        }

        private void btn_huybo_Click(object sender, EventArgs e)
        {
            //khoi tao lai cac text
            this.txt_diachi.ResetText();
            this.txt_dienthoai.ResetText();
            this.txt_maKH.ResetText();
            this.txt_tencongty.ResetText();
            this.cbx_thanhpho.ResetText();
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

        private void FormQLDMKH_Load(object sender, EventArgs e)
        {

        }
    }
}
