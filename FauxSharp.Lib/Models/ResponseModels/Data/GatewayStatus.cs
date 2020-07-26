using Newtonsoft.Json;

namespace FauxSharp.Lib.Models.ResponseModels.Data
{
    public class Gateway
    {

        [JsonProperty("monitorip")]
        public string Monitorip { get; set; }

        [JsonProperty("srcip")]
        public string Srcip { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("delay")]
        public string Delay { get; set; }

        [JsonProperty("stddev")]
        public string Stddev { get; set; }

        [JsonProperty("loss")]
        public string Loss { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

    }

    public class GatewayStatus
    {

        [JsonProperty("gateway_status")]
        public Gateway Status { get; set; }

    }
}
