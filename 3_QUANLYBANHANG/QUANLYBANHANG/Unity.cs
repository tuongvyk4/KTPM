using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Windows.Forms;
namespace QUANLYBANHANG
{
    class Unity
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        public static SqlDataAdapter da;

     
        //Hàm mở kết nối tới Database
        public static void OpenConnection()
        {
            
            string sql = @"Data Source=ADMIN\SQLEXPRESS;Initial Catalog=banhang;Integrated Security=True";
            try
            {
                con = new SqlConnection(sql);
                con.Open();
            }
            catch (SqlException e)
            {
            }
        }

        //Hàm đóng kết nối
        public static void Close()
        {
            con.Close();
        }

        //tạo hàm Datatable để lấy dữ liệu từ sqlAdapter hiển thị lên bảng
        public static DataTable getDatatable(string sql)
        {
            cmd = new SqlCommand(sql, con);
            da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataTable table = new DataTable();
            da.Fill(table);
            return table;
        }

         //tạo hàm execute để thêm, sửa, xóa
        public static void Excute(string sql)
        {
            cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
        }

    }
}
