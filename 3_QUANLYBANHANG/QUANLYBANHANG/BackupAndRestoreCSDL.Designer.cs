namespace QUANLYBANHANG
{
    partial class BackupAndRestoreCSDL
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_backupFileLoc = new System.Windows.Forms.TextBox();
            this.btn_backup = new System.Windows.Forms.Button();
            this.btn_browse1 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txt_RestoreFileLoc = new System.Windows.Forms.TextBox();
            this.btn_restore = new System.Windows.Forms.Button();
            this.btn_browse2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_backupFileLoc);
            this.groupBox3.Controls.Add(this.btn_backup);
            this.groupBox3.Controls.Add(this.btn_browse1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(41, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(697, 95);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Database Backup";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Location";
            // 
            // txt_backupFileLoc
            // 
            this.txt_backupFileLoc.Enabled = false;
            this.txt_backupFileLoc.Location = new System.Drawing.Point(121, 38);
            this.txt_backupFileLoc.Name = "txt_backupFileLoc";
            this.txt_backupFileLoc.Size = new System.Drawing.Size(442, 26);
            this.txt_backupFileLoc.TabIndex = 8;
            // 
            // btn_backup
            // 
            this.btn_backup.Enabled = false;
            this.btn_backup.Location = new System.Drawing.Point(598, 50);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Size = new System.Drawing.Size(93, 30);
            this.btn_backup.TabIndex = 7;
            this.btn_backup.Text = "Backup";
            this.btn_backup.UseVisualStyleBackColor = true;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // btn_browse1
            // 
            this.btn_browse1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_browse1.Location = new System.Drawing.Point(598, 13);
            this.btn_browse1.Name = "btn_browse1";
            this.btn_browse1.Size = new System.Drawing.Size(93, 31);
            this.btn_browse1.TabIndex = 6;
            this.btn_browse1.Text = "Browse..";
            this.btn_browse1.UseVisualStyleBackColor = true;
            this.btn_browse1.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txt_RestoreFileLoc);
            this.groupBox4.Controls.Add(this.btn_restore);
            this.groupBox4.Controls.Add(this.btn_browse2);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(41, 145);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(697, 95);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Database Restore";
            // 
            // txt_RestoreFileLoc
            // 
            this.txt_RestoreFileLoc.Enabled = false;
            this.txt_RestoreFileLoc.Location = new System.Drawing.Point(121, 38);
            this.txt_RestoreFileLoc.Name = "txt_RestoreFileLoc";
            this.txt_RestoreFileLoc.Size = new System.Drawing.Size(442, 26);
            this.txt_RestoreFileLoc.TabIndex = 8;
            // 
            // btn_restore
            // 
            this.btn_restore.Enabled = false;
            this.btn_restore.Location = new System.Drawing.Point(598, 50);
            this.btn_restore.Name = "btn_restore";
            this.btn_restore.Size = new System.Drawing.Size(93, 30);
            this.btn_restore.TabIndex = 7;
            this.btn_restore.Text = "Restore";
            this.btn_restore.UseVisualStyleBackColor = true;
            this.btn_restore.Click += new System.EventHandler(this.btn_restore_Click);
            // 
            // btn_browse2
            // 
            this.btn_browse2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_browse2.Location = new System.Drawing.Point(598, 13);
            this.btn_browse2.Name = "btn_browse2";
            this.btn_browse2.Size = new System.Drawing.Size(93, 31);
            this.btn_browse2.TabIndex = 6;
            this.btn_browse2.Text = "Browse..";
            this.btn_browse2.UseVisualStyleBackColor = true;
            this.btn_browse2.Click += new System.EventHandler(this.btn_browse2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Backup Path";
            // 
            // BackupAndRestoreCSDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 271);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Name = "BackupAndRestoreCSDL";
            this.Text = "Sao lưu và phục hồi CSDL";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_backupFileLoc;
        private System.Windows.Forms.Button btn_backup;
        private System.Windows.Forms.Button btn_browse1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_RestoreFileLoc;
        private System.Windows.Forms.Button btn_restore;
        private System.Windows.Forms.Button btn_browse2;
        private System.Windows.Forms.Label label5;
    }
}