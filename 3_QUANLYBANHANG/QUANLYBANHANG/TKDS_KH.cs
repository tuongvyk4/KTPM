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
    public partial class TKDS_KH : Form
    {
        public TKDS_KH()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void TKDS_KH_Load(object sender, EventArgs e)
        {
            CryReport.CRPKhachHang cr = new CryReport.CRPKhachHang();
            SqlConnection myConnection = new SqlConnection(@"Server = BADUY\SQLEXPRESS;database=banhang; user id = sa;password = 123456");
            //String sql = "Select * from KhachHang where MaKH = 'ASC'";
            String sql = "Select * from KhachHang";

            DataSet Dataset1 = new DataSet();
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, myConnection);
            myDataAdapter.Fill(Dataset1, "KhachHang");
            cr.SetDataSource(Dataset1.Tables["KhachHang"]);

            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.Show();
        }
    }
}
