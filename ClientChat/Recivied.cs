using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientChat
{
    public partial class Recivied : UserControl
    {
        public Recivied(string nguoigui, string messenger)
        {
            InitializeComponent();
            lbl_name.Text = nguoigui;
            lbl_messger.Text = messenger;
            lbl_date.Text = DateTime.Now.ToString();
        }
    }
}
