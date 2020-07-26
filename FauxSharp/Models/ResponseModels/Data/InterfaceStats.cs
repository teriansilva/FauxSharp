using Newtonsoft.Json;

namespace FauxSharp.Models.ResponseModels.Data
{
    public class InterfaceStatsData
    {

        [JsonProperty("inpkts")]
        public int Inpkts { get; set; }

        [JsonProperty("inbytes")]
        public int Inbytes { get; set; }

        [JsonProperty("outpkts")]
        public int Outpkts { get; set; }

        [JsonProperty("outbytes")]
        public int Outbytes { get; set; }

        [JsonProperty("inerrs")]
        public int Inerrs { get; set; }

        [JsonProperty("outerrs")]
        public int Outerrs { get; set; }

        [JsonProperty("collisions")]
        public int Collisions { get; set; }

        [JsonProperty("inmcasts")]
        public int Inmcasts { get; set; }

        [JsonProperty("outmcasts")]
        public int Outmcasts { get; set; }

        [JsonProperty("unsuppproto")]
        public int Unsuppproto { get; set; }

        [JsonProperty("mtu")]
        public int Mtu { get; set; }

    }

    public class InterfaceStats
    {

        [JsonProperty("stats")]
        public InterfaceStatsData Stats { get; set; }

    }
}
