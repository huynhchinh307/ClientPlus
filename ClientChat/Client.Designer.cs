namespace ClientChat
{
    partial class Client
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
            this.panel_move = new System.Windows.Forms.Panel();
            this.btn_mini = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.conStatus = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel_Messenger = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.Data_listOnline = new System.Windows.Forms.ListBox();
            this.panel_move.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_move
            // 
            this.panel_move.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel_move.Controls.Add(this.btn_mini);
            this.panel_move.Controls.Add(this.btn_Close);
            this.panel_move.Controls.Add(this.conStatus);
            this.panel_move.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_move.Location = new System.Drawing.Point(0, 0);
            this.panel_move.Name = "panel_move";
            this.panel_move.Size = new System.Drawing.Size(477, 37);
            this.panel_move.TabIndex = 0;
            this.panel_move.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_move_MouseDown);
            // 
            // btn_mini
            // 
            this.btn_mini.FlatAppearance.BorderSize = 0;
            this.btn_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mini.Image = global::ClientChat.Properties.Resources.minimize1;
            this.btn_mini.Location = new System.Drawing.Point(392, 3);
            this.btn_mini.Name = "btn_mini";
            this.btn_mini.Size = new System.Drawing.Size(38, 31);
            this.btn_mini.TabIndex = 4;
            this.btn_mini.UseVisualStyleBackColor = true;
            this.btn_mini.Click += new System.EventHandler(this.btn_mini_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Image = global::ClientChat.Properties.Resources.error;
            this.btn_Close.Location = new System.Drawing.Point(436, 1);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(38, 33);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // conStatus
            // 
            this.conStatus.AutoSize = true;
            this.conStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conStatus.ForeColor = System.Drawing.Color.MistyRose;
            this.conStatus.Location = new System.Drawing.Point(12, 9);
            this.conStatus.Name = "conStatus";
            this.conStatus.Size = new System.Drawing.Size(47, 16);
            this.conStatus.TabIndex = 2;
            this.conStatus.Text = "Chat: ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label22.Location = new System.Drawing.Point(390, 125);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(51, 16);
            this.label22.TabIndex = 5;
            this.label22.Text = "Online";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel12.Location = new System.Drawing.Point(354, 144);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(120, 10);
            this.panel12.TabIndex = 6;
            // 
            // panel_Messenger
            // 
            this.panel_Messenger.Location = new System.Drawing.Point(3, 44);
            this.panel_Messenger.Name = "panel_Messenger";
            this.panel_Messenger.Size = new System.Drawing.Size(350, 379);
            this.panel_Messenger.TabIndex = 7;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ClientChat.Properties.Resources.messenger;
            this.pictureBox5.Location = new System.Drawing.Point(381, 65);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(70, 57);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 3;
            this.pictureBox5.TabStop = false;
            // 
            // Data_listOnline
            // 
            this.Data_listOnline.FormattingEnabled = true;
            this.Data_listOnline.Location = new System.Drawing.Point(354, 160);
            this.Data_listOnline.MultiColumn = true;
            this.Data_listOnline.Name = "Data_listOnline";
            this.Data_listOnline.Size = new System.Drawing.Size(120, 264);
            this.Data_listOnline.TabIndex = 0;
            this.Data_listOnline.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Data_listOnline_MouseClick);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(477, 437);
            this.Controls.Add(this.Data_listOnline);
            this.Controls.Add(this.panel_Messenger);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.panel_move);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.panel_move.ResumeLayout(false);
            this.panel_move.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_move;
        private System.Windows.Forms.Label conStatus;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel_Messenger;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_mini;
        private System.Windows.Forms.ListBox Data_listOnline;
    }
}