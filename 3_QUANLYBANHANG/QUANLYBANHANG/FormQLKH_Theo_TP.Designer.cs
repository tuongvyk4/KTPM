namespace QUANLYBANHANG
{
    partial class FormQLKH_Theo_TP
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
            this.cbx_thanhpho = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewQLDMKH = new System.Windows.Forms.DataGridView();
            this.btn_xem = new System.Windows.Forms.Button();
            this.btn_trove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLDMKH)).BeginInit();
            this.SuspendLayout();
            // 
            // cbx_thanhpho
            // 
            this.cbx_thanhpho.FormattingEnabled = true;
            this.cbx_thanhpho.Location = new System.Drawing.Point(339, 37);
            this.cbx_thanhpho.Name = "cbx_thanhpho";
            this.cbx_thanhpho.Size = new System.Drawing.Size(141, 21);
            this.cbx_thanhpho.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 32;
            this.label4.Text = "Thành Phố";
            // 
            // dataGridViewQLDMKH
            // 
            this.dataGridViewQLDMKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewQLDMKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQLDMKH.Location = new System.Drawing.Point(31, 77);
            this.dataGridViewQLDMKH.Name = "dataGridViewQLDMKH";
            this.dataGridViewQLDMKH.Size = new System.Drawing.Size(629, 172);
            this.dataGridViewQLDMKH.TabIndex = 34;
            // 
            // btn_xem
            // 
            this.btn_xem.Location = new System.Drawing.Point(234, 294);
            this.btn_xem.Name = "btn_xem";
            this.btn_xem.Size = new System.Drawing.Size(75, 23);
            this.btn_xem.TabIndex = 36;
            this.btn_xem.Text = "Xem";
            this.btn_xem.UseVisualStyleBackColor = true;
            this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
            // 
            // btn_trove
            // 
            this.btn_trove.Location = new System.Drawing.Point(354, 294);
            this.btn_trove.Name = "btn_trove";
            this.btn_trove.Size = new System.Drawing.Size(67, 23);
            this.btn_trove.TabIndex = 40;
            this.btn_trove.Text = "Trở về";
            this.btn_trove.UseVisualStyleBackColor = true;
            this.btn_trove.Click += new System.EventHandler(this.btn_trove_Click);
            // 
            // FormQLKH_Theo_TP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 364);
            this.Controls.Add(this.btn_trove);
            this.Controls.Add(this.btn_xem);
            this.Controls.Add(this.dataGridViewQLDMKH);
            this.Controls.Add(this.cbx_thanhpho);
            this.Controls.Add(this.label4);
            this.Name = "FormQLKH_Theo_TP";
            this.Text = "FormQLKH_Theo_TP";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQLDMKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbx_thanhpho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewQLDMKH;
        private System.Windows.Forms.Button btn_xem;
        private System.Windows.Forms.Button btn_trove;
    }
}