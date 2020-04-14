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
    public partial class FormQLDMTP : Form
    {
        Boolean them;
        public FormQLDMTP()
        {
            InitializeComponent();
            this.showData("Select ThanhPho , TenThanhPho from ThanhPho");
            txt_tenthanhpho.ResetText();
            txt_thanhpho.ResetText();
            btn_luu.Enabled = false;
            btn_huybo.Enabled = false;
            panel.Enabled = false;
        }

        private void FormQLDMTP_FormClosing(object sender, FormClosingEventArgs e)
        {
            Unity.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //hiển thị dữ liệu
        public void showData(string sql)
        {
            Unity.OpenConnection();
            //truy xuất đến bản Khachang
            dataGridViewQLDMTP.DataSource = Unity.getDatatable(sql);
            dataGridViewQLDMTP.AutoResizeColumns();
           
            //dataGridViewQLDMTP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void btn_tailai_Click(object sender, EventArgs e)
        {
            this.showData("Select ThanhPho , TenThanhPho from ThanhPho");
            txt_tenthanhpho.ResetText();
            txt_thanhpho.ResetText();
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

        private void btn_sua_Click(object sender, EventArgs e)
        {
            //kich hoat bien sửa
            them = false;
            //Cho thao tác lưu, hủy và panel;
            this.btn_luu.Enabled = true;
            this.btn_huybo.Enabled = true;
            this.panel.Enabled = true;
            //không cho thao tác trên nút thêm/sửa/xóa/trở về
            this.btn_them.Enabled = false;
            this.btn_sua.Enabled = false;
            this.btn_xoa.Enabled = false;
            this.btn_trove.Enabled = false;
            //đưa trỏ đến txtThanhPho
            this.txt_thanhpho.Focus();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            them = true;
            //xóa trống đối tượng 
            this.txt_tenthanhpho.ResetText();
            this.txt_thanhpho.ResetText();
            //Cho thao tác lưu, hủy và panel;
            this.btn_luu.Enabled = true;
            this.btn_huybo.Enabled = true;
            this.panel.Enabled = true;
            //không cho thao tác trên nút thêm/sửa/xóa/trở về
            this.btn_them.Enabled = false;
            this.btn_sua.Enabled = false;
            this.btn_xoa.Enabled = false;
            this.btn_trove.Enabled = false;
            //đưa trỏ đến txtThanhPho
            this.txt_thanhpho.Focus();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                //mở kế nối
                Unity.OpenConnection();
                //lấy thứ tự record hiện hành
                int r = dataGridViewQLDMTP.CurrentCell.RowIndex;
                //lấy thanhpho của record hiện hành
                string strThanhPho = dataGridViewQLDMTP.Rows[r].Cells[0].Value.ToString();
                //câu lệnh SQL
                string sql = "Delete From ThanhPho Where ThanhPho = '" + strThanhPho + "'";
                Unity.Excute(sql);
                this.showData("Select ThanhPho , TenThanhPho from ThanhPho");
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK);
                Unity.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi dữ liệu đã được dùng!", "Cảnh báo", MessageBoxButtons.OK);
            }

        }

        private void btn_huybo_Click(object sender, EventArgs e)
        {
            //xóa trống đối tượng 
            this.txt_tenthanhpho.ResetText();
            this.txt_thanhpho.ResetText();
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

        private void btn_luu_Click(object sender, EventArgs e)
        {
            //mở kế nối
            Unity.OpenConnection();
            MessageBox.Show("Biến thêm: "+them.ToString(), "Cảnh báo", MessageBoxButtons.OK);
            if (them)
            {
                try
                {
                    string sql = "Insert into ThanhPho values(" + "N'" + this.txt_thanhpho.Text.ToString() + "',N'" + this.txt_tenthanhpho.Text.ToString() + "')";
                    //MessageBox.Show("sql thêm: " + sql, "Cảnh báo", MessageBoxButtons.OK);
                    Unity.Excute(sql);
                    this.showData("Select ThanhPho , TenThanhPho from ThanhPho");
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
                int r = dataGridViewQLDMTP.CurrentCell.RowIndex;
                //lấy thanhpho của record hiện hành
                string strThanhPho = dataGridViewQLDMTP.Rows[r].Cells[0].Value.ToString();
                string sql = "Update ThanhPho set TenThanhPho = N'" + this.txt_tenthanhpho.Text.ToString() + "' where ThanhPho='" + strThanhPho + "'";
                Unity.Excute(sql);
                this.showData("Select ThanhPho , TenThanhPho from ThanhPho");
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
                Unity.Close();
            }

        }
    }
}
