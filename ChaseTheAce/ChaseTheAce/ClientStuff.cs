using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;

namespace ChaseTheAce
{
    class ClientStuff
    {
        string name;
        TcpClient client;
        Form1 f1;
        public void setup(Form1 form1,string ip)
        {
            f1 = form1;
            name = Environment.UserName;
            client = new TcpClient();
            if (IPAddress.TryParse(f1.TBip.Text, out IPAddress ipaddress))
            {
                client.Connect(ipaddress, 4545);
            }
            Thread rd = new Thread(RecieveData);
            rd.Start();
            Send("UN:"+name);
            f1.MenuPanel.Hide();
            f1.WaitingPNL.Show();
            f1.Size = new System.Drawing.Size(429, 332);
            f1.PNLPlay.Location = new System.Drawing.Point(0, 0);
            f1.Text = ip + " " + name;
            f1.TBip.Clear();
        }
        public void Send(string message)
        {
            NetworkStream stream = client.GetStream();
            message= $"¬{message}`";
            Byte[] data = System.Text.Encoding.Unicode.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }
        string data;
        private void RecieveData()
        {
            NetworkStream stream = client.GetStream();
            Byte[] bytes = new byte[256];
            int i;
            while (true)
            {
                if ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    String responseData = String.Empty;
                    string DataBunched = System.Text.Encoding.Unicode.GetString(bytes, 0, i);
                    string[] messages = DataBunched.Split('¬').Where(x => string.IsNullOrWhiteSpace(x) == false && x != "¬").ToArray();
                    foreach (var msg in messages)
                    {
                        data = msg.Substring(0, msg.IndexOf("`"));
                        MessageBox.Show(data);
                        if (data.StartsWith("User:"))
                        {
                            var arr = data.Split(':');
                            f1.Invoke((MethodInvoker)delegate
                            {
                                f1.WaitingPlayers.Items.Add(arr[1]);
                            });
                        }
                    }
                }
            }
        }
    }
}
