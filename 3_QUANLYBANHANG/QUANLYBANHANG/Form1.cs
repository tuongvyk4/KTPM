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
    public partial class Form1 : Form
    {
        public static string quyen; //phân quyền
        public Form1()
        {
            InitializeComponent();
            lbl_qlbh.BackColor = Color.Transparent;
            groupBox1.BackColor = Color.Transparent;

        }

              private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dl = MessageBox.Show("Bạn có muốn thoát ứng dụng không?", "Thông báo", MessageBoxButtons.OKCancel);
            if (dl == DialogResult.OK)
            {
                Application.Exit();
            }
        }

              private void Form1_FormClosing(object sender, FormClosingEventArgs e)
              {
                  Application.Exit();
              }

              private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
              {
                  Form frm = new Formdoimatkhau();
                  frm.ShowDialog();
              }

              private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
              {
                  Form dmkh = new Formdanhmuckhachhang();
                  dmkh.ShowDialog();
              }

              private void danhMụcThànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
              {
                  Form dmkh = new Formdanhmucthanhpho();
                  dmkh.ShowDialog();
              }

              private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
              {
                  Form dmkh = new Formdanhmucnhanvien();
                  dmkh.ShowDialog();
              }

              private void danhMụcSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
              {
                  Form dmkh = new Formdanhmucsanpham();
                  dmkh.ShowDialog();
              }

              private void danhMụcHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
              {
                  Form dmkh = new Formdanhmuchoadon();
                  dmkh.ShowDialog();
              }

              private void danhMụcChiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
              {
                  Form dmkh = new Formdanhmucchitiethoadon();
                  dmkh.ShowDialog();
              }

              private void danhMụcThànhPhốToolStripMenuItem1_Click(object sender, EventArgs e)
              {
                  Form dmkh = new FormQLDMTP();
                  dmkh.ShowDialog();
              }

              private void danhMụcKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
              {
                  Form dmkh = new FormQLDMKH();
                  dmkh.ShowDialog();
              }

              private void danhMụcNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
              {
                  Form dmkh = new FormQLDMNV();
                  dmkh.ShowDialog();
              }

              private void danhMụcSảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
              {
                  Form dmkh = new FormQLDMSP();
                  dmkh.ShowDialog();
              }

              private void danhMụcHóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
              {
                  Form dmkh = new FormQLDMHD();
                  dmkh.ShowDialog();
              }

              private void danhMụcChiTiếtHóaĐơnToolStripMenuItem1_Click(object sender, EventArgs e)
              {
                  Form dmkh = new FormQLDMCTHD();
                  dmkh.ShowDialog();
              }

              private void Form1_Load(object sender, EventArgs e)
              {
                  lbl_qlbh.BackColor = Color.Transparent;
                  groupBox1.BackColor = Color.Transparent;
                  
                  if (quyen == "U")
                  {
                      //tắt chức năng quan lý người dùng
                      //quảnLýNgườiDùngToolStripMenuItem.Enabled = false;
                      //ẩn chức năng quan lý người dùng
                      quảnLýNgườiDùngToolStripMenuItem.Visible = false;
                  }
              }

              private void tácGiảToolStripMenuItem_Click(object sender, EventArgs e)
              {
                  MessageBox.Show("Người thực hiện: Nguyễn Bá Duy.\nĐiện thoại: 0983.877750","Thông tin tác giả!",MessageBoxButtons.OK);
              }

              private void quảnLýNgườiDùngToolStripMenuItem_Click(object sender, EventArgs e)
              {
                  Form dmkh = new FormQLND();
                  dmkh.ShowDialog();
              }

              private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
              {
                  TKDS_KH dmkh = new TKDS_KH();
                  dmkh.ShowDialog();
              }

              private void danhSáchNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
              {
                  TKDS_NV dmkh = new TKDS_NV();
                  dmkh.ShowDialog();
              }

              private void kháchHàngTheoThànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
              {
                  FormQLKH_Theo_TP dmkh = new FormQLKH_Theo_TP();
                  dmkh.ShowDialog();
              }

              private void importExcelToolStripMenuItem_Click(object sender, EventArgs e)
              {
                  FrmExporttoexcel dmkh = new FrmExporttoexcel();
                  dmkh.ShowDialog();
              }

              private void exportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
              {
                  ExportExcel dmkh = new ExportExcel();
                  dmkh.ShowDialog();
              }

              private void backupVàRestoreCSDLToolStripMenuItem_Click(object sender, EventArgs e)
              {
                  BackupAndRestoreCSDL dmkh = new BackupAndRestoreCSDL();
                  dmkh.ShowDialog();
              }
             
    }
}
