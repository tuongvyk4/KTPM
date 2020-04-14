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
    public partial class Formdanhmucthanhpho : Form
    {
        public Formdanhmucthanhpho()
        {
            InitializeComponent();
            this.showData("Select Thanhpho , Tenthanhpho from thanhpho");
            this.lbl_DM.BackColor = Color.Transparent;
        }

        //hiển thị dữ liệu
        public void showData(string sql)
        {
            Unity.OpenConnection();
            //truy xuất đến bản Khachang
            dataGridViewDM.DataSource = Unity.getDatatable(sql);
            dataGridViewDM.AutoResizeColumns();
            //dataGridViewDM.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Formdanhmucthanhpho_FormClosing(object sender, FormClosingEventArgs e)
        {
            Unity.Close();
        }

        private void Formdanhmucthanhpho_Load(object sender, EventArgs e)
        {

        }
    }
}
