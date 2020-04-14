namespace QUANLYBANHANG
{
    partial class FormQLDMTP
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
            this.btn_them = new System.Windows.Forms.Button();
            this.dataGridViewQLDMTP = new System.Windows.Forms.DataGridView();
            this.lbl_DM = new System.Windows.Forms.Label();
            this.txt_thanhpho = new System.Windows.Forms.TextBox();
            this.txt_tenthanhpho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_tailai = new System.Windows.Forms.Button();
            this.btn_huybo = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.btn_trove = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLDMTP)).BeginInit();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(145, 310);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(75, 23);
            this.btn_them.TabIndex = 21;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // dataGridViewQLDMTP
            // 
            this.dataGridViewQLDMTP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQLDMTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQLDMTP.Location = new System.Drawing.Point(27, 113);
            this.dataGridViewQLDMTP.Name = "dataGridViewQLDMTP";
            this.dataGridViewQLDMTP.Size = new System.Drawing.Size(405, 172);
            this.dataGridViewQLDMTP.TabIndex = 20;
            // 
            // lbl_DM
            // 
            this.lbl_DM.AutoSize = true;
            this.lbl_DM.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DM.Location = new System.Drawing.Point(19, 26);
            this.lbl_DM.Name = "lbl_DM";
            this.lbl_DM.Size = new System.Drawing.Size(80, 19);
            this.lbl_DM.TabIndex = 19;
            this.lbl_DM.Text = "Thành Phố";
            // 
            // txt_thanhpho
            // 
            this.txt_thanhpho.Location = new System.Drawing.Point(147, 25);
            this.txt_thanhpho.Name = "txt_thanhpho";
            this.txt_thanhpho.Size = new System.Drawing.Size(186, 20);
            this.txt_thanhpho.TabIndex = 22;
            // 
            // txt_tenthanhpho
            // 
            this.txt_tenthanhpho.Location = new System.Drawing.Point(147, 52);
            this.txt_tenthanhpho.Name = "txt_tenthanhpho";
            this.txt_tenthanhpho.Size = new System.Drawing.Size(186, 20);
            this.txt_tenthanhpho.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tên Thành Phố";
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(265, 310);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(75, 23);
            this.btn_sua.TabIndex = 25;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_tailai
            // 
            this.btn_tailai.Location = new System.Drawing.Point(27, 310);
            this.btn_tailai.Name = "btn_tailai";
            this.btn_tailai.Size = new System.Drawing.Size(75, 23);
            this.btn_tailai.TabIndex = 26;
            this.btn_tailai.Text = "Tải lại";
            this.btn_tailai.UseVisualStyleBackColor = true;
            this.btn_tailai.Click += new System.EventHandler(this.btn_tailai_Click);
            // 
            // btn_huybo
            // 
            this.btn_huybo.Location = new System.Drawing.Point(145, 339);
            this.btn_huybo.Name = "btn_huybo";
            this.btn_huybo.Size = new System.Drawing.Size(75, 23);
            this.btn_huybo.TabIndex = 27;
            this.btn_huybo.Text = "Hủy bỏ";
            this.btn_huybo.UseVisualStyleBackColor = true;
            this.btn_huybo.Click += new System.EventHandler(this.btn_huybo_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(265, 339);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(75, 23);
            this.btn_xoa.TabIndex = 28;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(27, 339);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 23);
            this.btn_luu.TabIndex = 29;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // btn_trove
            // 
            this.btn_trove.Location = new System.Drawing.Point(365, 317);
            this.btn_trove.Name = "btn_trove";
            this.btn_trove.Size = new System.Drawing.Size(67, 45);
            this.btn_trove.TabIndex = 30;
            this.btn_trove.Text = "Trở về";
            this.btn_trove.UseVisualStyleBackColor = true;
            this.btn_trove.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.txt_tenthanhpho);
            this.panel.Controls.Add(this.lbl_DM);
            this.panel.Controls.Add(this.txt_thanhpho);
            this.panel.Controls.Add(this.label1);
            this.panel.Location = new System.Drawing.Point(50, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(351, 92);
            this.panel.TabIndex = 31;
            // 
            // FormQLDMTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 391);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btn_trove);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_huybo);
            this.Controls.Add(this.btn_tailai);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.btn_them);
            this.Controls.Add(this.dataGridViewQLDMTP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormQLDMTP";
            this.Text = "Quản lý danh mục thành phố";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormQLDMTP_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLDMTP)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.DataGridView dataGridViewQLDMTP;
        private System.Windows.Forms.Label lbl_DM;
        private System.Windows.Forms.TextBox txt_thanhpho;
        private System.Windows.Forms.TextBox txt_tenthanhpho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_tailai;
        private System.Windows.Forms.Button btn_huybo;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Button btn_trove;
        private System.Windows.Forms.Panel panel;
    }
}