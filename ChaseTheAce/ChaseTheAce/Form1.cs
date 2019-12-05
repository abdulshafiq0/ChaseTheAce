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

namespace ChaseTheAce
{
    public partial class Form1 : Form
    {
        ClientStuff cp = new ClientStuff();
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNnewgame_Click(object sender, EventArgs e)
        {
            ServerStuff s = new ServerStuff();
            Thread NG = new Thread(() => s.NewGame(this));
            NG.Start();
        }

        private void IpJoinGame_Click(object sender, EventArgs e)
        {
            cp.setup(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MenuPanel.Location = new Point(10, 10);
            MenuPanel.BringToFront();
            SetUpCards();
        }

    }
}
