namespace ClientChat
{
    partial class Messenger
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
            this.lbl_Name = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel_log = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Attach = new System.Windows.Forms.Button();
            this.txt_Text = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbl_Name.Location = new System.Drawing.Point(3, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(71, 16);
            this.lbl_Name.TabIndex = 6;
            this.lbl_Name.Text = "Tin nhắn: ";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel12.Location = new System.Drawing.Point(6, 19);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(333, 7);
            this.panel12.TabIndex = 7;
            // 
            // panel_log
            // 
            this.panel_log.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel_log.Location = new System.Drawing.Point(6, 33);
            this.panel_log.Name = "panel_log";
            this.panel_log.Size = new System.Drawing.Size(341, 294);
            this.panel_log.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.btn_Attach);
            this.panel2.Controls.Add(this.txt_Text);
            this.panel2.Controls.Add(this.btn_Send);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.ForeColor = System.Drawing.Color.Cornsilk;
            this.panel2.Location = new System.Drawing.Point(0, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 50);
            this.panel2.TabIndex = 10;
            // 
            // btn_Attach
            // 
            this.btn_Attach.BackColor = System.Drawing.Color.Transparent;
            this.btn_Attach.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Attach.Image = global::ClientChat.Properties.Resources.attachment;
            this.btn_Attach.Location = new System.Drawing.Point(213, 3);
            this.btn_Attach.Name = "btn_Attach";
            this.btn_Attach.Size = new System.Drawing.Size(32, 42);
            this.btn_Attach.TabIndex = 2;
            this.btn_Attach.UseVisualStyleBackColor = false;
            this.btn_Attach.Click += new System.EventHandler(this.btn_Attach_Click);
            // 
            // txt_Text
            // 
            this.txt_Text.Location = new System.Drawing.Point(3, 3);
            this.txt_Text.Multiline = true;
            this.txt_Text.Name = "txt_Text";
            this.txt_Text.Size = new System.Drawing.Size(204, 42);
            this.txt_Text.TabIndex = 1;
            this.txt_Text.Text = "Trò chuyện với mọi người?";
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Send.Image = global::ClientChat.Properties.Resources.send_mail;
            this.btn_Send.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Send.Location = new System.Drawing.Point(251, 4);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(81, 43);
            this.btn_Send.TabIndex = 0;
            this.btn_Send.Text = "Send";
            this.btn_Send.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // Messenger
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_log);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.lbl_Name);
            this.Name = "Messenger";
            this.Size = new System.Drawing.Size(350, 379);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Attach;
        private System.Windows.Forms.TextBox txt_Text;
        private System.Windows.Forms.Button btn_Send;
        public System.Windows.Forms.FlowLayoutPanel panel_log;
    }
}
