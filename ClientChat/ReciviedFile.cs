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
    public partial class ReciviedFile : UserControl
    {
        string fpath;
        public ReciviedFile(string nguoigui, string fname, string fpath)
        {
            InitializeComponent();
            lbl_name.Text = nguoigui;
            lbl_filename.Text = fname;
            this.fpath = fpath;
        }

        private void lbl_filename_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(fpath);
        }
    }
}
