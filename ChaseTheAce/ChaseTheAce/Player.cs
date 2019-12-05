using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.Sockets;

namespace ChaseTheAce
{
    class Player
    {
        public string name;
        public TcpClient client;
        public Card mycard;

        public void clientRD()
        {
            string data = "";
            NetworkStream RecieveDataStream = client.GetStream();
            byte[] bytes = new byte[256];
            int i;
            try
            {
                while (true)
                {
                    if ((i = RecieveDataStream.Read(bytes, 0, bytes.Length)) != 0)
                    {
                        string DataBunched = System.Text.Encoding.Unicode.GetString(bytes, 0, i);
                        string[] messages = DataBunched.Split('¬').Where(x => string.IsNullOrWhiteSpace(x) == false && x != "¬").ToArray();
                        foreach (var msg in messages)
                        {
                            data = msg.Substring(0, msg.IndexOf("`"));
                            RecivedData(data);
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }
        public void RecivedData(string data)
        {

        }
    }
}
