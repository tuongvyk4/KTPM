using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using xls = Microsoft.Office.Interop.Excel; //import thư viện
namespace QUANLYBANHANG
{
    public partial class FrmExporttoexcel : Form
    {
        public FrmExporttoexcel()
        {
            InitializeComponent();
        }

        //tạo 1 bảng tạm chứa dữ liệu file xecel
        private DataTable oTbl;
        //1 file chứa thông tin file import
        private String filename;

        //Method đọc dữ liệu xls vào oDtb
        private void readExcel()
        {
            filename = textBox.Text;
            if (filename == null)
            {
                MessageBox.Show("Chưa chọn file Excel");
            }
            else
            {
                //Tạo đối tượng Excel
                xls.Application Excelapp = new xls.Application();
                xls.Workbook wb = Excelapp.Workbooks.Add(Type.Missing);

                //kiểm tra xem có mở được đối tượng file Excel không
                try
                {   
                    Excelapp.Workbooks.Open(filename);
                }
                catch
                {
                    MessageBox.Show("Không thể mở file chứa dữ liệu");
                }

                //tạo cấu trúc cho oTbl
                oTbl = new DataTable();
                oTbl.Columns.Add("A", typeof(string));//tạo 1 cột A có kiểu dữ liệu string
                oTbl.Columns.Add("B", typeof(string));//tạo 1 cột B có kiểu dữ liệu string
               // oTbl.Columns.Add("C", typeof(string));//tạo 1 cột C có kiểu dữ liệu string
               // oTbl.Columns.Add("D", typeof(string));//tạo 1 cột D có kiểu dữ liệu string
                
                //đọc dữ liệu file excel
                foreach (xls.Worksheet wSheet in Excelapp.Worksheets)
                {
                    //tạo một datarow để lấy dữ liệu cho từng dòng
                    DataRow dr;
                    //Đọc từng dòng của sheet excel
                    long i =1;
                    try
                    {
                        do
                        {
                            if (wSheet.Range["A" + i].Value == null && wSheet.Range["B" + i].Value == null && wSheet.Range["C" + i].Value == null && wSheet.Range["D" + i].Value == null)
                            {
                                break; //nếu dùng cuối cùng của sheetdata thì dừng lại
                            }
                            dr = oTbl.NewRow(); //datarow có kiểu dữ liệu cùng với oTbl
                            dr["A"] = wSheet.Range["A" + i].Value;
                            dr["B"] = wSheet.Range["B" + i].Value;
                           // dr["C"] = wSheet.Range["C" + i].Value;
                           // dr["D"] = wSheet.Range["D" + i].Value;
                            oTbl.Rows.Add(dr);
                            i++;
                        }
                        while (true);
                    }
                    catch
                    {
                        MessageBox.Show("có lỗi khi thực hiện");
                    }

                }
                wb.Close(true);//Thoát khỏi excel
                Excelapp.Quit(); //Thoát khỏi excel
            }
        }
                

        private void ImportExcel_Load(object sender, EventArgs e)
        {

        }

       //hàm đưa dữ liệu từ datagrid vào SQL
        public void them()
        {
            //mở kế nối
            Unity.OpenConnection();
            //======================
            for (int i = 1; i < dataGridView1.RowCount - 1; i++) //bỏ qua i= 0 là title của dadagridview
            {
                //câu lệnh SQl
                String sql = "Insert into ThanhPho values(N'" + dataGridView1.Rows[i].Cells["A"].Value + "',N'" + dataGridView1.Rows[i].Cells["B"].Value + "')";
                MessageBox.Show(sql);
                Unity.Excute(sql);
                MessageBox.Show("Thêm dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK);
            }

            //======================
            //đóng kết nối
            Unity.Close();
        }


        private void btn_import1_Click(object sender, EventArgs e)
        {
            them();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //tạo đối tượng mở tập tin
            OpenFileDialog fdialog = new OpenFileDialog();
            //chỉ ra đuôi lọc
            fdialog.Filter = "Các tệp Excel|*.xls;*.xlsx"; // chỉ lấy các định dạng này
            fdialog.FilterIndex = 1; // trỏ vào vị trí đầu tiên của bộ lọc
            fdialog.RestoreDirectory = true; //nhớ đường dẫn của lần truy cập trước
            fdialog.Multiselect = false; // không cho phép chọn nhiều file cùng 1 lúc
            fdialog.Title = "Chọn file Excel";

            if (fdialog.ShowDialog() == DialogResult.OK)
            {
                //set giá trị cho textbox filename
                textBox.Text = fdialog.FileName;
                //thực thi method readexcel
                readExcel();
                //đổ dữ liệu vào DataGrid
                if (oTbl != null)
                {
                    dataGridView1.DataSource = oTbl;
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu");
                }
            }
        }

    }
}
