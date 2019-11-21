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
    public partial class SentFile : UserControl
    {
        string fpath;
        public SentFile(string filename, string fpath)
        {
            InitializeComponent();

            lblFileName.Text = filename;
            this.fpath = fpath;
            lbl_date.Text = DateTime.Now.ToString();
        }
        private void lblFileName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(fpath);
        }
    }
}
