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
    public partial class Formdanhmucnhanvien : Form
    {
        public Formdanhmucnhanvien()
        {
            InitializeComponent();
            this.showData("Select MaNV , Holot, Ten, Diachi, Dienthoai from nhanvien");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //hiển thị dữ liệu
        public void showData(string sql)
        {
            Unity.OpenConnection();
            //truy xuất đến bản Khachang
            dataGridViewDM.DataSource = Unity.getDatatable(sql);
            dataGridViewDM.AutoResizeColumns();
           // dataGridViewDM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void Formdanhmucnhanvien_Load(object sender, EventArgs e)
        {
            int chiso = Convert.ToInt32(this.Text);
            Console.WriteLine("Chỉ số: "+chiso);
        }

        private void Formdanhmucnhanvien_FormClosing(object sender, FormClosingEventArgs e)
        {
            Unity.Close();
        }
    }
}
