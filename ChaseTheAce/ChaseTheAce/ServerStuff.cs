using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Drawing;
using System.Net.Http;


namespace ChaseTheAce
{
    class ServerStuff
    {
        TcpListener Server;
        Form1 f1;
        public List<Player> players = new List<Player>();

        public void NewGame(Form1 form1)
        {
            f1 = form1;
            Server = new TcpListener(IPAddress.Any, 4545);
            Server.Start();
            Thread AC = new Thread(AcceptClient);
            AC.Start();
        }
        private void AcceptClient()
        {
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
            p.Server = this;
            foreach(Player pl in players)
            {
                p.SendData("User:"+pl.name);
            }
            players.Add(p);
        }
    }
}
