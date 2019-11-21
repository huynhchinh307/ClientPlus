namespace ClientChat
{
    partial class SentFile
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_date = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFileName = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_date.Location = new System.Drawing.Point(78, 55);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(112, 13);
            this.lbl_date.TabIndex = 12;
            this.lbl_date.Text = "2019/08/11 11:11:11 AM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lblFileName);
            this.panel1.Location = new System.Drawing.Point(78, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 54);
            this.panel1.TabIndex = 11;
            // 
            // lblFileName
            // 
            this.lblFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.LinkColor = System.Drawing.Color.Black;
            this.lblFileName.Location = new System.Drawing.Point(0, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(263, 54);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.TabStop = true;
            this.lblFileName.Text = "Tên file";
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFileName.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblFileName_LinkClicked);
            // 
            // SentFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.panel1);
            this.Name = "SentFile";
            this.Size = new System.Drawing.Size(341, 68);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lblFileName;
    }
}
