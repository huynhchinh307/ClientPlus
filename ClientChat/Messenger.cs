using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;

namespace ClientChat
{
    public partial class Messenger : UserControl
    {
        static Messenger _obj;
        public string account;
        Socket client = Client.Instance.CLIENT;
        private byte[] data = new byte[1024];
        private int size = 1024;
        public Messenger()
        {
            InitializeComponent();
            panel_log.AutoScroll = true;

        }
        public void AddMessenger(string account)
        {
            this.account = account;
            lbl_Name.Text= "Tin nhắn: "+account;
            //Tắt tính năng gửi file cho server và public
            if(account.Equals("Server") || account.Equals("Public"))
            {
                btn_Attach.Enabled = false;
            }

        }
        public static Messenger Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Messenger();
                }
                return _obj;
            }
        }
        public void SetRecivide(string name, string mess)
        {
            Recivied recived = new Recivied(name, mess);
            panel_log.Invoke(new Action(() => panel_log.Controls.Add(recived)));
            panel_log.Invoke(new Action(() => panel_log.ScrollControlIntoView(recived)));
        }
        public void SetRecividePic(string fpath, string fname)
        {
            RePic recived = new RePic(fpath, fname);
            panel_log.Invoke(new Action(() => panel_log.Controls.Add(recived)));
            panel_log.Invoke(new Action(() => panel_log.ScrollControlIntoView(recived)));
        }
        public void SetRecivideFile(string name, string fname, string fpath)
        {
            ReciviedFile recived = new ReciviedFile(name, fname, fpath);
            panel_log.Invoke(new Action(() => panel_log.Controls.Add(recived)));
            panel_log.Invoke(new Action(() => panel_log.ScrollControlIntoView(recived)));
        }
        private void btn_Send_Click(object sender, EventArgs e)
        {
            if (txt_Text.Text != null)
            {
                byte[] message;
                if (txt_Text.Text.Equals("/exit"))
                {
                    message = Encoding.UTF8.GetBytes("m:"+Client.Instance.Account + ":Public:" + txt_Text.Text);
                    client.BeginSend(message, 0, message.Length, SocketFlags.None,
                                new AsyncCallback(SendData), client);
                    Application.Exit();
                }
                else
                {
                    message = Encoding.UTF8.GetBytes("m:" + Client.Instance.Account + ":" + account + ":" + txt_Text.Text);
                    //Tạo log gửi tin nhắn
                    Sent sent = new Sent();
                    sent.SetSent(txt_Text.Text);
                    panel_log.Controls.Add(sent);
                    panel_log.ScrollControlIntoView(sent);
                    txt_Text.Clear();
                    client.BeginSend(message, 0, message.Length, SocketFlags.None,
                                    new AsyncCallback(SendData), client);
                }
            }
        }
        void SendData(IAsyncResult iar)
        {
            Socket remote = (Socket)iar.AsyncState;
            int sent = remote.EndSend(iar);
        }
        public override bool Equals(Object obj)
        {
            var item = obj as Messenger;

            if (item == null)
            {
                return false;
            }

            return this.account.Equals(item.account);
        }
        public override string ToString()
        {
            return account;
        }

        private void btn_Attach_Click(object sender, EventArgs e)
        {
            FileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SendFile(fd.FileName);
            }
        }
        public void SendFile(string fName)
        {
            try
            {
                string path = "";
                fName = fName.Replace("\\", "/");
                /* Thao tác đang đọc file. */
                while (fName.IndexOf("/") > -1)
                {
                    path += fName.Substring(0, fName.IndexOf("/") + 1);
                    fName = fName.Substring(fName.IndexOf("/") + 1);
                }
                //Tạo ra mảng byte chứa tên file
                byte[] fNameByte = Encoding.ASCII.GetBytes(fName);
                /* Kiểm tra kích thước file */
                if (fNameByte.Length > 5000 * 1024)
                {
                    MessageBox.Show("Gửi file <=5MB thôi nhá ~_~ !!!");
                    return;
                }
                txt_Text.Text = "Đang upload file lên...";
                txt_Text.ReadOnly = true;
                //Tạo tiêu đề gửi
                string packetsend = "f:" + Client.Instance.Account + ":" + account + ":";
                byte[] fileData = File.ReadAllBytes(path + fName);
                byte[] clientData = new byte[204 + fNameByte.Length + fileData.Length];
                //Tạo gói packetinfo 200 file chứa packetsend
                string packetinfo = new string(' ', 200 - packetsend.Length);
                packetinfo += packetsend;
                byte[] packetinfobyte = Encoding.ASCII.GetBytes(packetinfo);
                byte[] fNameLen = BitConverter.GetBytes(fNameByte.Length);
                packetinfobyte.CopyTo(clientData, 0);
                fNameLen.CopyTo(clientData, 200);
                fNameByte.CopyTo(clientData, 204);
                fileData.CopyTo(clientData, 204 + fNameByte.Length);
                //Bắt đầu gửi file lên server
                client.BeginSend(clientData, 0, clientData.Length, SocketFlags.None,
                                   new AsyncCallback(SendData), client);
                txt_Text.Text = "";
                txt_Text.ReadOnly = false;
                //Tùy chỉnh hiển thị file
                string type = fName.Substring(fName.LastIndexOf(".") + 1);
                type = type.ToLower();
                //Nếu là hình
                if (type.Equals("png") || type.Equals("jpeg") || type.Equals("jpg") || type.Equals("gif"))
                {
                    //Thông báo dạng hình
                    SentPic sent = new SentPic(path, fName);
                    panel_log.Controls.Add(sent);
                    panel_log.ScrollControlIntoView(sent);
                }
                else
                {
                    //Thông báo dạng file
                    SentFile sent = new SentFile(fName, path);
                    panel_log.Controls.Add(sent);
                    panel_log.ScrollControlIntoView(sent);
                }
            }
            catch (Exception ex)
            {

            }

        }
    }
}
