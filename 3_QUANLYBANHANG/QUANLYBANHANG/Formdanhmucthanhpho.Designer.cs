namespace QUANLYBANHANG
{
    partial class Formdanhmucthanhpho
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewDM = new System.Windows.Forms.DataGridView();
            this.lbl_DM = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDM)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Trở về";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewDM
            // 
            this.dataGridViewDM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDM.Location = new System.Drawing.Point(21, 64);
            this.dataGridViewDM.Name = "dataGridViewDM";
            this.dataGridViewDM.Size = new System.Drawing.Size(324, 172);
            this.dataGridViewDM.TabIndex = 8;
            // 
            // lbl_DM
            // 
            this.lbl_DM.AutoSize = true;
            this.lbl_DM.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DM.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_DM.Location = new System.Drawing.Point(72, 20);
            this.lbl_DM.Name = "lbl_DM";
            this.lbl_DM.Size = new System.Drawing.Size(256, 24);
            this.lbl_DM.TabIndex = 7;
            this.lbl_DM.Text = "DANH MỤC THÀNH PHỐ";
            // 
            // Formdanhmucthanhpho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QUANLYBANHANG.Properties.Resources.Costa_Rica_Beach;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(368, 279);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewDM);
            this.Controls.Add(this.lbl_DM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Formdanhmucthanhpho";
            this.Text = "Danh mục Thành Phố";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formdanhmucthanhpho_FormClosing);
            this.Load += new System.EventHandler(this.Formdanhmucthanhpho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewDM;
        private System.Windows.Forms.Label lbl_DM;
    }
}