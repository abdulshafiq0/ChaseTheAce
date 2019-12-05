using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;


namespace ChaseTheAce
{
    public class ServerStuff
    {
        TcpListener Server;
        Form1 f1;
        Player Owner;
        List<Player> players = new List<Player>();

        public void NewGame(Form1 form1)
        {
            f1 = form1;
            f1.Invoke((MethodInvoker)delegate
            {
                f1.Text = (Getipadress().ToString()) + " " + Environment.UserName;
                f1.MenuPanel.Hide();
            });
            Player p = new Player();
            p.name = Environment.UserName;
            Owner = p;
            Server = new TcpListener(IPAddress.Any, 4545);
            Server.Start();
            while (true)
            {
                TcpClient newcon = Server.AcceptTcpClient();
                Thread nu = new Thread(() => NewUser(newcon));
                nu.Start();
            }
        }
        private void NewUser(TcpClient client)
        {
            Player p = new Player();
            p.client = client;
            Thread rd = new Thread(p.clientRD);
            rd.Start();
            MessageBox.Show("someone joined");
            players.Add(p);
        }
        private IPAddress Getipadress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip;
                }
            }
            return null;
        }
    }
}
