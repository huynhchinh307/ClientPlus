using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ClientChat
{
    public partial class RePic : UserControl
    {
        string fpath;
        public RePic(string fpath, string fname)
        {
            InitializeComponent();
            lbl_date.Text = DateTime.Now.ToString();
            pic.ImageLocation = fpath;
            this.fpath = fpath;
            lblImgName.Text = fname;
        }

        private void lblImgName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(fpath);
        }
    }
}
