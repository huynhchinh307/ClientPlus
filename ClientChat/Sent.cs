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
    public partial class Sent : UserControl
    {
        public Sent()
        {
            InitializeComponent();
        }
        public void SetSent(string messenger)
        {
            lbl_messger.Text = messenger;
            lbl_date.Text = DateTime.Now.ToString();
        }
    }
}
