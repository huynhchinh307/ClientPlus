using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientChat
{
    public partial class Client : Form
    {
        string pathRecivedFile = Path.GetDirectoryName(Application.ExecutablePath);
        static Client _obj;
        static Socket client;
        static string account;
        //Thông số gói tin
        byte[] data = new byte[1024*5000];
        int size = 1024*5000;
        private string path= Directory.GetCurrentDirectory();

        //Cấu hình cho phép di chuyển khi nhấn panel
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        public Client(string account,Socket client)
        {
            InitializeComponent();
            CLIENT = client;
            Account = account;
        }
        public static Client Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Client(account, client);
                }
                return _obj;
            }
        }
        public string Account
        {
            get { return account; }
            set { account = value; }
        }
        public Socket CLIENT
        {
            get { return client; }
            set { client = value; }
        }
        public Panel MessengerContainer
        {
            get { return panel_Messenger; }
            set { panel_Messenger = value; }
        }
        private void panel_move_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }


        void ReceiveData(IAsyncResult iar)
        {
            Socket remote = (Socket)iar.AsyncState;
            int recv = remote.EndReceive(iar);
            string stringData = Encoding.UTF8.GetString(data, 0, recv);
            string[] messagerstring = stringData.Split(':');
            //Xữ lý khi nhận packet online
            if (messagerstring[0].Equals("OnlinePacket"))
            {
                //xữ lý online client offline
                if (Data_listOnline.Items.Contains(messagerstring[1]))
                    Data_listOnline.Invoke(new Action(() => Data_listOnline.Items.Remove(messagerstring[1])));
                else
                    Data_listOnline.Invoke(new Action(() => Data_listOnline.Items.Add(messagerstring[1])));
            }
            else
            {
                //Xữ lý nếu gói nhận được là file
                if (messagerstring[0].Trim().Equals("f"))
                {
                    string packetsend = Encoding.UTF8.GetString(data, 0, 200);
                    messagerstring = packetsend.Split(':');
                    //Kiểm tra UI Messenger của người nhận tồn lại chưa
                    int i = 0;
                    for (i = 0; i < MessengerContainer.Controls.Count; i++)
                        if (MessengerContainer.Controls[i].ToString().Equals(messagerstring[1]))
                            break;
                    //Nếu chưa tồn tại tạo UI
                    Messenger messenger = new Messenger();
                    messenger.AddMessenger(messagerstring[1]);
                    if (i == MessengerContainer.Controls.Count)
                    {
                        messenger.Dock = DockStyle.Fill;
                        MessengerContainer.Invoke(new Action(() => MessengerContainer.Controls.Add(messenger)));
                    }
                    int fNameLen = BitConverter.ToInt32(data, 200);
                    string fName = Encoding.UTF8.GetString(data, 204, fNameLen);
                    BinaryWriter write = new BinaryWriter(File.Open(path + "/" + fName, FileMode.Append));
                    write.Write(data, 204 + fNameLen, recv - 204 - fNameLen);
                    write.Close();
                    //Tạo Recivied UI để hiển thị tin nhắn được nhận
                    foreach (Messenger c in MessengerContainer.Controls)
                    {
                        if (messenger.Equals(c))
                        {
                            //Tùy chỉnh hiển thị file
                            string type = fName.Substring(fName.LastIndexOf(".") + 1);
                            type = type.ToLower();
                            //Nếu là hình
                            if (type.Equals("png") || type.Equals("jpeg") || type.Equals("jpg") || type.Equals("gif"))
                                c.SetRecividePic(path, fName);
                            else
                                c.SetRecivideFile(messagerstring[1], fName, path);
                            break;
                        }
                    }
                }
                else
                {
                    //Xữ lý nếu gói nhận được là messger
                    string messagerfull = stringData.Substring(messagerstring[1].Length + 1 + messagerstring[2].Length + 1 + 2);
                    if(messagerstring[2].Equals("Public"))
                    {
                        Messenger messenger = new Messenger();
                        messenger.AddMessenger("Public");
                        foreach (Messenger c in MessengerContainer.Controls)
                        {
                            if (messenger.Equals(c))
                            {
                                c.SetRecivide(messagerstring[1], messagerfull);
                                break;
                            }
                        }
                    }
                    else
                    {
                        //Kiểm tra UI Messenger của người nhận tồn lại chưa
                        int i = 0;
                        for (i = 0; i < MessengerContainer.Controls.Count; i++)
                            if (MessengerContainer.Controls[i].ToString().Equals(messagerstring[1]))
                                break;
                        //Nếu chưa tồn tại tạo UI
                        Messenger messenger = new Messenger();
                        messenger.AddMessenger(messagerstring[1]);
                        if (i == MessengerContainer.Controls.Count)
                        {
                            messenger.Dock = DockStyle.Fill;
                            MessengerContainer.Invoke(new Action(() => MessengerContainer.Controls.Add(messenger)));
                        }
                        //Tạo Recivied UI để hiển thị tin nhắn được nhận
                        foreach (Messenger c in MessengerContainer.Controls)
                        {
                            if (messenger.Equals(c))
                            {
                                c.SetRecivide(messagerstring[1], messagerfull);
                                break;
                            }
                        }
                    }
                    
                }
            }
            //Tiếp tục nhận tin nhắn từ client
            remote.BeginReceive(data, 0, size, SocketFlags.None, new AsyncCallback(ReceiveData), remote);
        }
        private void Client_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            byte[] message = Encoding.UTF8.GetBytes("m:"+account + ":Public:/exit");
            client.BeginSend(message, 0, message.Length, SocketFlags.None,
                                new AsyncCallback(SendData), client);
            Application.Exit();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            _obj = this;
            conStatus.Text += account;
            //Tạo UI Messenger Public
            Messenger uc = new Messenger();
            uc.AddMessenger("Public");
            uc.Dock = DockStyle.Fill;
            MessengerContainer.Controls.Add(uc);
            
            Data_listOnline.Items.Add("Public");
            Data_listOnline.Items.Add("Server");
            client.BeginReceive(data, 0, size, SocketFlags.None, new AsyncCallback(ReceiveData), client);
        }

        private void btn_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        void SendData(IAsyncResult iar)
        {
            try
            {
                Socket remote = (Socket)iar.AsyncState;
                int sent = remote.EndSend(iar);

            }
            catch
            {
                conStatus.Invoke(new Action(() => conStatus.Text = "Mất kết nối tới server !!!"));
                //lstMesseger.Invoke(new Action(() => lstMesseger.Items.Add("Lost connecting to server !!!")));
            }
        }

        private void listOnline_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Data_listOnline_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < Data_listOnline.Items.Count; i++)
            {
                var rectangle = Data_listOnline.GetItemRectangle(i);
                if (rectangle.Contains(e.Location))
                {
                    Messenger messenger = new Messenger();
                    messenger.AddMessenger(Data_listOnline.Items[i].ToString());
                    if (!MessengerContainer.Controls.Equals(messenger))
                    {
                        messenger.Dock = DockStyle.Fill;
                        MessengerContainer.Controls.Add(messenger);
                    }
                    MessengerContainer.Controls[MessengerContainer.Controls.IndexOf(messenger)].BringToFront();
                }
            }
        }
    }
}
