using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

    public class GatewayInstance
    {
        
        [JsonExtensionData]
        private IDictionary<string, JToken> _additionalData;
        [JsonIgnore]
        public Gateway GatewayStatusData => JsonConvert.DeserializeObject<Gateway>(_additionalData.FirstOrDefault().Value.ToString());
        [JsonIgnore]
        public string GatewayIp => _additionalData.FirstOrDefault().Key;
    }

    public class GatewayStatus
    {
        [JsonProperty("gateway_status")]

        public GatewayInstance GatewayInstance { get; set; }

    }

}
