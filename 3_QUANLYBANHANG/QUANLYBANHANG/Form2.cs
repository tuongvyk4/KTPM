using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace QUANLYBANHANG
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            this.panel1.BackColor = Color.Transparent;
        }

        private bool validate()
        {
            if (txt_taikhoan.Text == "" || txt_matkhau.Text == "")
            {
                MessageBox.Show("Bạn phải điền đầy đủ các trường !");
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validate())  //kiểm tra dữ liệu k rỗng thì :
            { //khai báo chuỗi lệnh sql
                Unity.OpenConnection();
                string sql = "select * from NguoiDung where taikhoan = '" + txt_taikhoan.Text + "' and matkhau = '"+txt_matkhau.Text+"'";
                //MessageBox.Show("cau lenh: "+sql);
                DataTable data = Unity.getDatatable(sql);

                 if (data.Rows.Count <= 0)  //gọi hàm getTable từ lớp có giá trị truyền vào là chuỗi lênh select để lấy thông tin từ bảng nếu có số dòng <= 0 thì:
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu!");
                    Unity.Close();
                }
                else  //nếu số dòng lấy được > 0 thì :
                {
                    //lay dữ liệu quyền cho form 1 (main)
                    Form1.quyen = data.Rows[0][2].ToString().Trim();

                    MessageBox.Show("quyen: " + Form1.quyen);
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo!", MessageBoxButtons.OK);
                    Form1 f2 = new Form1();
                    this.Visible = false;
                    f2.ShowDialog();
                    Unity.Close();
                }
            //else
            //{
           //     MessageBox.Show("Sai thông tin đăng nhập!", "Cảnh báo!", MessageBoxButtons.OK);
            }
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dl = MessageBox.Show("Bạn có muốn thoát ứng dụng không?","Thông báo",MessageBoxButtons.OKCancel);
            //if (dl == DialogResult.Cancel)
            //{
            //   e.Cancel = true;
            //}
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
