using System.Collections.Generic;
using Newtonsoft.Json;

namespace FauxSharp.Models.ResponseModels.Data
{
    public class SystemStatsData
    {

        [JsonProperty("cpu")]
        public string Cpu { get; set; }

        [JsonProperty("mem")]
        public string Mem { get; set; }

        [JsonProperty("uptime")]
        public string Uptime { get; set; }

        [JsonProperty("pfstate")]
        public string Pfstate { get; set; }

        [JsonProperty("pfstatepercent")]
        public string Pfstatepercent { get; set; }

        [JsonProperty("temp")]
        public string Temp { get; set; }

        [JsonProperty("datetime")]
        public string Datetime { get; set; }

        [JsonProperty("cpufreq")]
        public string Cpufreq { get; set; }

        [JsonProperty("load_average")]
        public List<string> LoadAverage { get; set; }

        [JsonProperty("mbuf")]
        public string Mbuf { get; set; }

        [JsonProperty("mbufpercent")]
        public string Mbufpercent { get; set; }

    }

    public class SystemStats
    {

        [JsonProperty("stats")]
        public SystemStatsData Stats { get; set; }

    }
}
