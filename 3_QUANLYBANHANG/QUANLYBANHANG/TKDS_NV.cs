using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

//OKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK

namespace QUANLYBANHANG
{
    public partial class TKDS_NV : Form
    {
        public TKDS_NV()
        {
            InitializeComponent();
          

        }
        public string strconn = "Server = BADUY\\SQLEXPRESS;database=banhang; user id = sa;password = 123456";

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void TKDS_NV_Load(object sender, EventArgs e)
        {
            CryReport.CRPNhanVien cr = new CryReport.CRPNhanVien();
            SqlConnection myConnection = new SqlConnection(@"Server = BADUY\SQLEXPRESS;database=banhang; user id = sa;password = 123456");
            String sql = "Select * from NhanVien where MaNV = 1";
            //String sql = "Select * from NhanVien";

            DataSet Dataset1 = new DataSet();
            SqlDataAdapter myDataAdapter = new SqlDataAdapter(sql, myConnection);
            myDataAdapter.Fill(Dataset1, "NhanVien");
            cr.SetDataSource(Dataset1.Tables["NhanVien"]);

            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
            crystalReportViewer1.Show();
        }
    }
}
