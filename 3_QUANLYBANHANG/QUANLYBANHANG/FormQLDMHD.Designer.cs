namespace QUANLYBANHANG
{
    partial class FormQLDMHD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel = new System.Windows.Forms.Panel();
            this.txt_ngaynhan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_DM = new System.Windows.Forms.Label();
            this.txt_maHD = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_trove = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_huybo = new System.Windows.Forms.Button();
            this.btn_tailai = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dataGridViewQLDMHD = new System.Windows.Forms.DataGridView();
            this.txt_ngaylap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_MaKH = new System.Windows.Forms.ComboBox();
            this.cbx_maNV = new System.Windows.Forms.ComboBox();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLDMHD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cbx_maNV);
            this.panel.Controls.Add(this.cbx_MaKH);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.txt_ngaylap);
            this.panel.Controls.Add(this.txt_ngaynhan);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.lbl_DM);
            this.panel.Controls.Add(this.txt_maHD);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(9, 8);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(626, 118);
            this.panel.TabIndex = 67;
            // 
            // txt_ngaynhan
            // 
            this.txt_ngaynhan.Location = new System.Drawing.Point(463, 53);
            this.txt_ngaynhan.Name = "txt_ngaynhan";
            this.txt_ngaynhan.Size = new System.Drawing.Size(141, 20);
            this.txt_ngaynhan.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(335, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Ngày nhận hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(335, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Ngày lập hóa đơn";
            // 
            // lbl_DM
            // 
            this.lbl_DM.AutoSize = true;
            this.lbl_DM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DM.Location = new System.Drawing.Point(19, 26);
            this.lbl_DM.Name = "lbl_DM";
            this.lbl_DM.Size = new System.Drawing.Size(90, 19);
            this.lbl_DM.TabIndex = 19;
            this.lbl_DM.Text = "Mã hóa đơn";
            // 
            // txt_maHD
            // 
            this.txt_maHD.Location = new System.Drawing.Point(147, 25);
            this.txt_maHD.Name = "txt_maHD";
            this.txt_maHD.Size = new System.Drawing.Size(141, 20);
            this.txt_maHD.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã khách hàng";
            // 
            // btn_trove
            // 
            this.btn_trove.Location = new System.Drawing.Point(568, 372);
            this.btn_trove.Name = "btn_trove";
            this.btn_trove.Size = new System.Drawing.Size(67, 23);
            this.btn_trove.TabIndex = 66;
            this.btn_trove.Text = "Trở về";
            this.btn_trove.UseVisualStyleBackColor = true;
            this.btn_trove.Click += new System.EventHandler(this.btn_trove_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(375, 372);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 23);
            this.btn_luu.TabIndex = 65;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(285, 372);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 64;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_huybo
            // 
            this.btn_huybo.Location = new System.Drawing.Point(472, 372);
            this.btn_huybo.Name = "btn_huybo";
            this.btn_huybo.Size = new System.Drawing.Size(75, 23);
            this.btn_huybo.TabIndex = 63;
            this.btn_huybo.Text = "Hủy bỏ";
            this.btn_huybo.UseVisualStyleBackColor = true;
            this.btn_huybo.Click += new System.EventHandler(this.btn_huybo_Click);
            // 
            // btn_tailai
            // 
            this.btn_tailai.Location = new System.Drawing.Point(9, 372);
            this.btn_tailai.Name = "btn_tailai";
            this.btn_tailai.Size = new System.Drawing.Size(75, 23);
            this.btn_tailai.TabIndex = 62;
            this.btn_tailai.Text = "Tải lại";
            this.btn_tailai.UseVisualStyleBackColor = true;
            this.btn_tailai.Click += new System.EventHandler(this.btn_tailai_Click_1);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(193, 372);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 61;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(100, 372);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 60;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dataGridViewQLDMHD
            // 
            this.dataGridViewQLDMHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQLDMHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQLDMHD.Location = new System.Drawing.Point(9, 144);
            this.dataGridViewQLDMHD.Name = "dataGridViewQLDMHD";
            this.dataGridViewQLDMHD.Size = new System.Drawing.Size(626, 211);
            this.dataGridViewQLDMHD.TabIndex = 59;
            this.dataGridViewQLDMHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQLDMHD_CellClick);
            // 
            // txt_ngaylap
            // 
            this.txt_ngaylap.Location = new System.Drawing.Point(463, 29);
            this.txt_ngaylap.Name = "txt_ngaylap";
            this.txt_ngaylap.Size = new System.Drawing.Size(141, 20);
            this.txt_ngaylap.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Mã nhân viên";
            // 
            // cbx_MaKH
            // 
            this.cbx_MaKH.FormattingEnabled = true;
            this.cbx_MaKH.Location = new System.Drawing.Point(147, 52);
            this.cbx_MaKH.Name = "cbx_MaKH";
            this.cbx_MaKH.Size = new System.Drawing.Size(141, 21);
            this.cbx_MaKH.TabIndex = 33;
            // 
            // cbx_maNV
            // 
            this.cbx_maNV.FormattingEnabled = true;
            this.cbx_maNV.Location = new System.Drawing.Point(147, 83);
            this.cbx_maNV.Name = "cbx_maNV";
            this.cbx_maNV.Size = new System.Drawing.Size(141, 21);
            this.cbx_maNV.TabIndex = 34;
            // 
            // FormQLDMHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 399);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btn_trove);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_huybo);
            this.Controls.Add(this.btn_tailai);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dataGridViewQLDMHD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormQLDMHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý danh mục hóa đơn";
            this.Load += new System.EventHandler(this.FormQLDMHD_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLDMHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.TextBox txt_ngaynhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_DM;
        private System.Windows.Forms.TextBox txt_maHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_trove;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_huybo;
        private System.Windows.Forms.Button btn_tailai;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dataGridViewQLDMHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ngaylap;
        private System.Windows.Forms.ComboBox cbx_maNV;
        private System.Windows.Forms.ComboBox cbx_MaKH;
    }
}