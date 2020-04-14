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
    public partial class ExportExcel : Form
    {
        public ExportExcel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sql = "select * from ThanhPho";
            LoadDB(sql);
        }

        //hiển thị dữ liệu
        public void LoadDB(string sql)
        {
            Unity.OpenConnection();
            //truy xuất đến bản Khachang
            this.dataGridView1.DataSource = Unity.getDatatable(sql);
            this.dataGridView1.AutoResizeColumns();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //Tạo đối tượng Excel
            xls.Application app = new xls.Application();
            xls.Workbook wb = app.Workbooks.Add(Type.Missing);
            xls.Worksheet ws = null;
            ws = wb.Sheets["Sheet1"];
            ws = wb.ActiveSheet;
            ws.Name = "Data";

            //Gán dòng đầu tiên của file excel là tiêu đề của header datagrid
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                ws.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            //đưa dữ liệu từng dòng datagrid vào excel
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++) //bỏ hàng cuối null trong datagrid
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    ws.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    //MessageBox.Show(dataGridView1.Rows[i].Cells[j].Value.ToString());
                }
            }

            //tạo savedialog để lưu trữ
            var savedialog = new SaveFileDialog();
            savedialog.FileName = "Output";
            savedialog.DefaultExt = ".xlsx";
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                wb.SaveAs(savedialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, xls.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            wb.Close(true);//Thoát khỏi excel
            app.Quit();//Thoát khỏi excel
        }

    }
}
