namespace QUANLYBANHANG
{
    partial class Formdanhmuckhachhang
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
            this.lbl_DM = new System.Windows.Forms.Label();
            this.dataGridViewDM = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDM)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_DM
            // 
            this.lbl_DM.AutoSize = true;
            this.lbl_DM.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DM.Location = new System.Drawing.Point(57, 47);
            this.lbl_DM.Name = "lbl_DM";
            this.lbl_DM.Size = new System.Drawing.Size(276, 24);
            this.lbl_DM.TabIndex = 4;
            this.lbl_DM.Text = "DANH MỤC KHÁCH HÀNG";
            this.lbl_DM.Click += new System.EventHandler(this.lbl_DM_Click);
            // 
            // dataGridViewDM
            // 
            this.dataGridViewDM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDM.Location = new System.Drawing.Point(37, 101);
            this.dataGridViewDM.Name = "dataGridViewDM";
            this.dataGridViewDM.Size = new System.Drawing.Size(324, 172);
            this.dataGridViewDM.TabIndex = 5;
            this.dataGridViewDM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDM_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Trở về";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Formdanhmuckhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 328);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewDM);
            this.Controls.Add(this.lbl_DM);
            this.Name = "Formdanhmuckhachhang";
            this.Text = "Danh mục khách hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formdanhmuckhachhang_FormClosing);
            this.Load += new System.EventHandler(this.Formdanhmuckhachhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DM;
        private System.Windows.Forms.DataGridView dataGridViewDM;
        private System.Windows.Forms.Button button1;
    }
}