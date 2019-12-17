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
    public class ServerStuff
    {
        TcpListener Server;
        Form1 f1;
        List<Player> players = new List<Player>();//doesnt include owner

        public void NewGame(Form1 form1)
        {
            f1 = form1;
            Server = new TcpListener(IPAddress.Any, 4545);
            Server.Start();
            HttpClient Client = new HttpClient();
            Client.DefaultRequestHeaders.Add("User-Agent", "_INSERT_NAME_HERE_");
            Client.BaseAddress = new Uri("https://ml-api.uk.ms");
            string query = $"?name={Uri.EscapeDataString("bob")}" +
                $"&extn={"82.40.195.153"}" +
                $"&intl={"192.168.0.27"}" +
                $"&type={Uri.EscapeDataString("ChaseTheAce")}" +
                $"&pass={false}";
            var request = new HttpRequestMessage(HttpMethod.Put, "/masterlist/create" + query);
            var response = Client.SendAsync(request).Result;
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
            players.Add(p);
        }

        
    }
}
