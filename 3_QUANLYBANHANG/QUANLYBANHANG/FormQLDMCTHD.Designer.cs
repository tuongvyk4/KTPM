namespace QUANLYBANHANG
{
    partial class FormQLDMCTHD
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
            this.cbx_maSP = new System.Windows.Forms.ComboBox();
            this.cbx_MaHD = new System.Windows.Forms.ComboBox();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_DM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_trove = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_huybo = new System.Windows.Forms.Button();
            this.btn_tailai = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.dataGridViewQLDMCTHD = new System.Windows.Forms.DataGridView();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLDMCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.Controls.Add(this.cbx_maSP);
            this.panel.Controls.Add(this.cbx_MaHD);
            this.panel.Controls.Add(this.txt_soluong);
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.lbl_DM);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(182, 10);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(306, 118);
            this.panel.TabIndex = 76;
            // 
            // cbx_maSP
            // 
            this.cbx_maSP.FormattingEnabled = true;
            this.cbx_maSP.Location = new System.Drawing.Point(147, 55);
            this.cbx_maSP.Name = "cbx_maSP";
            this.cbx_maSP.Size = new System.Drawing.Size(141, 21);
            this.cbx_maSP.TabIndex = 34;
            // 
            // cbx_MaHD
            // 
            this.cbx_MaHD.FormattingEnabled = true;
            this.cbx_MaHD.Location = new System.Drawing.Point(147, 19);
            this.cbx_MaHD.Name = "cbx_MaHD";
            this.cbx_MaHD.Size = new System.Drawing.Size(141, 21);
            this.cbx_MaHD.TabIndex = 33;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(147, 89);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(141, 20);
            this.txt_soluong.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 27;
            this.label4.Text = "Số lượng";
            // 
            // lbl_DM
            // 
            this.lbl_DM.AutoSize = true;
            this.lbl_DM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DM.Location = new System.Drawing.Point(19, 16);
            this.lbl_DM.Name = "lbl_DM";
            this.lbl_DM.Size = new System.Drawing.Size(90, 19);
            this.lbl_DM.TabIndex = 19;
            this.lbl_DM.Text = "Mã hóa đơn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã sản phẩm";
            // 
            // btn_trove
            // 
            this.btn_trove.Location = new System.Drawing.Point(584, 361);
            this.btn_trove.Name = "btn_trove";
            this.btn_trove.Size = new System.Drawing.Size(67, 23);
            this.btn_trove.TabIndex = 75;
            this.btn_trove.Text = "Trở về";
            this.btn_trove.UseVisualStyleBackColor = true;
            this.btn_trove.Click += new System.EventHandler(this.btn_trove_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(391, 361);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 23);
            this.btn_luu.TabIndex = 74;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(301, 361);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 73;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_huybo
            // 
            this.btn_huybo.Location = new System.Drawing.Point(488, 361);
            this.btn_huybo.Name = "btn_huybo";
            this.btn_huybo.Size = new System.Drawing.Size(75, 23);
            this.btn_huybo.TabIndex = 72;
            this.btn_huybo.Text = "Hủy bỏ";
            this.btn_huybo.UseVisualStyleBackColor = true;
            this.btn_huybo.Click += new System.EventHandler(this.btn_huybo_Click);
            // 
            // btn_tailai
            // 
            this.btn_tailai.Location = new System.Drawing.Point(25, 361);
            this.btn_tailai.Name = "btn_tailai";
            this.btn_tailai.Size = new System.Drawing.Size(75, 23);
            this.btn_tailai.TabIndex = 71;
            this.btn_tailai.Text = "Tải lại";
            this.btn_tailai.UseVisualStyleBackColor = true;
            this.btn_tailai.Click += new System.EventHandler(this.btn_tailai_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(209, 361);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 70;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(116, 361);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 69;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dataGridViewQLDMCTHD
            // 
            this.dataGridViewQLDMCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQLDMCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQLDMCTHD.Location = new System.Drawing.Point(25, 134);
            this.dataGridViewQLDMCTHD.Name = "dataGridViewQLDMCTHD";
            this.dataGridViewQLDMCTHD.Size = new System.Drawing.Size(626, 211);
            this.dataGridViewQLDMCTHD.TabIndex = 68;
            this.dataGridViewQLDMCTHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQLDMCTHD_CellClick);
            // 
            // FormQLDMCTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 405);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btn_trove);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_huybo);
            this.Controls.Add(this.btn_tailai);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dataGridViewQLDMCTHD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormQLDMCTHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý chi tiết hóa đơn";
            this.Load += new System.EventHandler(this.FormQLDMCTHD_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLDMCTHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ComboBox cbx_maSP;
        private System.Windows.Forms.ComboBox cbx_MaHD;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_DM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_trove;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_huybo;
        private System.Windows.Forms.Button btn_tailai;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dataGridViewQLDMCTHD;
    }
}