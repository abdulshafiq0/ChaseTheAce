using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Drawing;


namespace ChaseTheAce
{
    public class ServerStuff
    {
        TcpListener Server;
        Form1 f1;
        Player Owner;
        List<Player> players = new List<Player>();//doesnt include owner
        List<Card> deck = new List<Card>();
        Random rnd = new Random();

        public void NewGame(Form1 form1)
        {
            f1 = form1;
            f1.Invoke((MethodInvoker)delegate
            {
                f1.Text = (Getipadress().ToString()) + " " + Environment.UserName;
                f1.MenuPanel.Hide();
            });
            Owner o = new Owner();
            o.name = Environment.UserName;
            o.f1 = form1;
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
        private void SetUpCards()
        {
            List<Card> cards = new List<Card>();
            for (int i = 2; i < 11; i++)
            {
                cards.Add(MakeCard($"{i}H", i));
                cards.Add(MakeCard($"{i}D", i));
                cards.Add(MakeCard($"{i}S", i));
                cards.Add(MakeCard($"{i}C", i));
            }
            cards.Add(MakeCard($"JH", 11));
            cards.Add(MakeCard($"JD", 11));
            cards.Add(MakeCard($"JS", 11));
            cards.Add(MakeCard($"JC", 11));
            cards.Add(MakeCard($"QH", 12));
            cards.Add(MakeCard($"QD", 12));
            cards.Add(MakeCard($"QS", 12));
            cards.Add(MakeCard($"QC", 12));
            cards.Add(MakeCard($"KH", 13));
            cards.Add(MakeCard($"KD", 13));
            cards.Add(MakeCard($"KS", 13));
            cards.Add(MakeCard($"KC", 13));
            cards.Add(MakeCard($"AH", 1));
            cards.Add(MakeCard($"AD", 1));
            cards.Add(MakeCard($"AS", 1));
            cards.Add(MakeCard($"AC", 1));
            while (cards.Count > 0)//shufle
            {
                Card a = cards[rnd.Next(0, cards.Count)];
                cards.Remove(a);
                deck.Add(a);
            }
        }
        private Card MakeCard(string name, int value)
        {
            Card c = new Card();
            c.name = name;
            c.value = value;
            c.pic = (Image)Properties.Resources.ResourceManager.GetObject($"_{name}");
            return c;
        }
    }
}
