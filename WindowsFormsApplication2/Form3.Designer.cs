namespace FTPFileMover
{
    partial class Form3
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
            this.label12 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(95, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(194, 105);
            this.label12.TabIndex = 28;
            this.label12.Text = "Backup Client File to FTP Server v1\r\n\r\nCopyright (C) 2018\r\n\r\nWritten By: ReugiTri" +
    "65\r\n\r\nHomepage: http://teknologika.net/";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(161, 158);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(71, 32);
            this.btnEdit.TabIndex = 29;
            this.btnEdit.Text = "CLOSE";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(392, 217);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label12);
            this.Name = "Form2";
            this.Text = "About Backup Client File to FTP Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnEdit;
    }
}