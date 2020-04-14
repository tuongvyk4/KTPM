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
    public partial class BackupAndRestoreCSDL : Form
    {
        //private SqlConnection con = new SqlConnection(@"Server = BADUY\SQLEXPRESS;database=banhang; user id = sa;password = 123456");

        public BackupAndRestoreCSDL()
        {
            InitializeComponent();
        }

 
        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txt_backupFileLoc.Text = dlg.SelectedPath;
                btn_backup.Enabled = true;
            }
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            string database = Unity.con.Database.ToString();
            try
            {
                if (txt_backupFileLoc.Text == string.Empty)
                {
                    MessageBox.Show("Chưa chọn nơi lưu CSDL");
                }
                else
                {
                    //mở kế nối
                    Unity.OpenConnection();
                    //string cmd = "BACKUP DATABASE [ " + database + "] TO DISK ='"+txt_backupFileLoc.Text+"\\"+"Database"+"-"+DateTime.Now.ToString("yyyy-mm-dd")+".bak'";
                    string cmd = "BACKUP DATABASE " + database + " TO DISK ='" + txt_backupFileLoc.Text + "\\" + "Database" + "-" + DateTime.Now.ToString("yyyy-mm-dd") + ".bak'";
                    //MessageBox.Show(cmd);
                    Unity.Excute(cmd);
                    //MessageBox.Show("chay toi day");
                    Unity.con.Close();
                    MessageBox.Show("Backup thành công.");
                    btn_backup.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_browse2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fopen = new OpenFileDialog();
            fopen.Filter = "SQL Server Backup file |*.bak";
            fopen.Title = "Database Restore";
            if (fopen.ShowDialog() == DialogResult.OK)
            {
                txt_RestoreFileLoc.Text = fopen.FileName;
                btn_restore.Enabled = true;
            }
        }

        private void btn_restore_Click(object sender, EventArgs e)
        {
            string database = Unity.con.Database.ToString();
            try
            {
                if (btn_restore.Text == string.Empty)
                {
                    MessageBox.Show("Chưa chọn file retore CSDL");
                }
                else
                {
                    //mở kế nối
                    Unity.OpenConnection();
                    //string cmd = "BACKUP DATABASE [ " + database + "] TO DISK ='"+txt_backupFileLoc.Text+"\\"+"Database"+"-"+DateTime.Now.ToString("yyyy-mm-dd")+".bak'";
                    string cmd = "restore database " + database + " from  DISK ='" + txt_RestoreFileLoc.Text +"'";
                    MessageBox.Show(cmd);
                    //Unity.Excute(cmd);
                    Unity.con.Close();
                    MessageBox.Show("Restore thành công.");
                    btn_restore.Enabled = false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
