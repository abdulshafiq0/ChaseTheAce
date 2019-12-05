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
        public void setup(Form1 form1)
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
            f1.Text = f1.TBip.Text + " " + name;
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
