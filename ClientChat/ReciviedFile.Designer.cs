namespace ClientChat
{
    partial class ReciviedFile
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
            this.lbl_filename = new System.Windows.Forms.LinkLabel();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Century Gothic", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbl_date.Location = new System.Drawing.Point(0, 55);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(112, 13);
            this.lbl_date.TabIndex = 14;
            this.lbl_date.Text = "2019/08/11 11:11:11 AM";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.lbl_name);
            this.panel1.Controls.Add(this.lbl_filename);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 54);
            this.panel1.TabIndex = 13;
            // 
            // lbl_filename
            // 
            this.lbl_filename.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lbl_filename.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_filename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filename.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbl_filename.LinkColor = System.Drawing.Color.Black;
            this.lbl_filename.Location = new System.Drawing.Point(0, 0);
            this.lbl_filename.Name = "lbl_filename";
            this.lbl_filename.Size = new System.Drawing.Size(263, 54);
            this.lbl_filename.TabIndex = 14;
            this.lbl_filename.TabStop = true;
            this.lbl_filename.Text = "Tên file";
            this.lbl_filename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_filename.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_filename_LinkClicked);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Location = new System.Drawing.Point(0, 0);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(52, 13);
            this.lbl_name.TabIndex = 15;
            this.lbl_name.Text = "Người gửi";
            // 
            // ReciviedFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.panel1);
            this.Name = "ReciviedFile";
            this.Size = new System.Drawing.Size(341, 68);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.LinkLabel lbl_filename;
    }
}
