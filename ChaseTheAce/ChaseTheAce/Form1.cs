using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.Http;
namespace ChaseTheAce
{
    public partial class Form1 : Form
    {
        ClientStuff cp = new ClientStuff();
        Random rnd = new Random();
        List<Card> deck = new List<Card>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNnewgame_Click(object sender, EventArgs e)
        {
            ServerStuff s = new ServerStuff();
            s.NewGame(this);
            cp.setup(this, Getipadress());
        }

        private void IpJoinGame_Click(object sender, EventArgs e)
        {
            cp.setup(this,TBip.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(650, 375);
            MenuPanel.Location = new Point(10, 10);
            PNLPlay.Hide();
            SetUpCards();
            GetGame();
        }
        private void GetGame()
        {
            HttpClient Client = new HttpClient();
            Client.DefaultRequestHeaders.Add("User-Agent", "Chrome-chasetheace");
            Client.BaseAddress = new Uri("https://ml-api.uk.ms");
            string query = "masterlist/list?type=chasetheace";
            var request = new HttpRequestMessage(HttpMethod.Get, query);
            var response = Client.SendAsync(request).Result;
            MessageBox.Show(response.Content.ReadAsStringAsync().Result);
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
        private string Getipadress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            return null;
        }

    }
}
