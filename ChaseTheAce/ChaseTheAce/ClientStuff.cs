using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

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
            Send("UN:"+name);
            f1.MenuPanel.Hide();
            f1.PNLPlay.Show();
            f1.Size = new System.Drawing.Size(650, 450);
            f1.PNLPlay.Location = new System.Drawing.Point(0, 0);
            f1.Text = ip + " " + name;
            f1.TBip.Clear();
        }
        private void Send(string message)
        {
            NetworkStream stream = client.GetStream();
            message= $"¬{message}`";
            Byte[] data = System.Text.Encoding.Unicode.GetBytes(message);
            stream.Write(data, 0, data.Length);
        }
    }
}
