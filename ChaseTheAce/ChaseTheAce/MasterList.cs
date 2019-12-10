using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ChaseTheAce
{
    public static class MasterList
    {
        static HttpClient Client { get; set; }
        const string TYPE = "chasetheace";
        const string USERAGENT = "chasetheace";

        static Guid m_id = Guid.Empty;
        static int m_nonce = 0;

        public static LoadInfo()
        {
            try
            {
                var lines = File.ReadAllLines("masterlist.info");
                Guid.TryParse(lines[0], out m_id);
                int.TryParse(lines[1], out m_nonce);
            }
            catch
            {

            }
        }

        public static Guid Id {  get
            {
                if(m_id == Guid.Empty)
                {
                }

            } }

        static void createCheck()
        {
            if(Client == null)
            {
                Client = new HttpClient();
                Client.BaseAddress = new Uri("https://ml-api.uk.ms/");
                Client.DefaultRequestHeaders.Add("User-Agent", USERAGENT);
            }
        }

        public static async Task<MasterlistServer[]> GetServers()
        {
            createCheck();
            var request = new HttpRequestMessage(HttpMethod.Get, "/masterlist/servers");
            var response = await Client.SendAsync(request).ConfigureAwait(false);
            if(response.IsSuccessStatusCode)
            {
                var str = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                var parse = JsonConvert.DeserializeObject<MasterlistServer[]>(str);
                return parse;
            } else
            {
                var err = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                throw new InvalidOperationException("Could not get masterlist: " + err);
            }
        }



    }

    public class MasterlistServer
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("extIP")]
        public string ExternalIP { get; set; }
        [JsonProperty("intIP")]
        public string InternalIP { get; set; }
        [JsonProperty("type")]
        public string Game { get; set; }
        [JsonProperty("hasPw")]
        public bool Password { get; set; }
        [JsonProperty("count", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(0)]
        public int CurrentPlayers { get; set; }
        [JsonProperty("max", DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate)]
        [DefaultValue(0)]
        public int MaximumPlayers { get; set; }

        public MasterlistServer(string name, string ext, string ipIn, string game, bool pass)
        {
            Name = name;
            ExternalIP = ext;
            InternalIP = ipIn;
            Game = game.ToLower();
            Password = pass;
            LastHeartBeat = DateTime.Now;
        }

        [JsonIgnore]
        public DateTime LastHeartBeat { get; set; }

        [JsonIgnore]
        public int Nonce { get; set; }
    }
}
