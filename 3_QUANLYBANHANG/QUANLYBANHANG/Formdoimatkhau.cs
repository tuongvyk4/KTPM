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
    public partial class Formdoimatkhau : Form
    {
        public Formdoimatkhau()
        {
            InitializeComponent();
            this.label1.BackColor = Color.Transparent;
            this.label2.BackColor = Color.Transparent;
            this.label3.BackColor = Color.Transparent;
            this.label4.BackColor = Color.Transparent;
            this.label5.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_taikhoan.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập tên tài khoản!", "Cảnh báo", MessageBoxButtons.OK);
                txt_taikhoan.Focus();
            }
            else if (txt_matkhau.Text.Trim() =="")
            {
                MessageBox.Show("Chưa nhập mật khẩu!", "Cảnh báo", MessageBoxButtons.OK);
                txt_matkhau.Focus();
            }
            else if (txt_matkhaumoi.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu mới!", "Cảnh báo", MessageBoxButtons.OK);
                txt_matkhaumoi.Focus();
            }
            else if (txt_matkhaumoilaplai.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập mật khẩu mới nhập lại!", "Cảnh báo", MessageBoxButtons.OK);
                txt_matkhaumoilaplai.Focus();
            }
            else
            {
                //String userName ="nbduy";
                //String passWord = "123456";
                //changePassword(userName, passWord);

                //Doc du lieu
                if (Check(txt_taikhoan.Text,txt_matkhau.Text) == true)
                {
                        if (txt_matkhaumoi.Text.Trim() == txt_matkhaumoilaplai.Text.Trim())
                        {
                            MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK);
                            //xu ly cap nhat mat khau
                            string sql = "Update nguoidung set matkhau = N'" + this.txt_matkhaumoi.Text.ToString() + "'where taikhoan=N'" + this.txt_taikhoan.Text.ToString()+ "'";
                            Unity.OpenConnection();
                            MessageBox.Show("sql capnhat: " + sql, "Cảnh báo", MessageBoxButtons.OK);
                            Unity.Excute(sql);
                            Unity.Close();
                            //String userName ="nbduy";
                            //String passWord = "123456";

                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu mới không trùng nhau!", "Cảnh báo", MessageBoxButtons.OK);
                        }
                }
                else
                {
                    MessageBox.Show("Không tồn tại tài khoản này!", "Cảnh báo", MessageBoxButtons.OK);
                    txt_taikhoan.Focus();
                }
            }
        }

        private Boolean Check(String taikhoan, String matkhau)
        {
            Unity.OpenConnection();
            string sql = "select * from NguoiDung where taikhoan = '" + taikhoan + "' and matkhau = '" + matkhau + "'";
            //MessageBox.Show("cau lenh: "+sql);
            DataTable data = Unity.getDatatable(sql);

            if (data.Rows.Count <= 0)  //gọi hàm getTable từ lớp có giá trị truyền vào là chuỗi lênh select để lấy thông tin từ bảng nếu có số dòng <= 0 thì:
            {
                Unity.Close();
                return false;
            }
            else  //nếu số dòng lấy được > 0 thì :
            {
                Unity.Close();
                return true;
            }
        }

        private void Formdoimatkhau_Load(object sender, EventArgs e)
        {

        }

        /*
        private void changePassword(String taikhoan, String matkhau)
        {
            if (txt_taikhoan.Text.Trim() == taikhoan)
            {
                if (txt_matkhau.Text.Trim() == matkhau)
                {
                    if (txt_matkhaumoi.Text.Trim() == txt_matkhaumoilaplai.Text.Trim())
                    {
                        MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới không trùng nhau!", "Cảnh báo", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu!", "Cảnh báo", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Không tồn tại tài khoản này!", "Cảnh báo", MessageBoxButtons.OK);
                txt_taikhoan.Focus();
            }
        }
         */
    }
}
