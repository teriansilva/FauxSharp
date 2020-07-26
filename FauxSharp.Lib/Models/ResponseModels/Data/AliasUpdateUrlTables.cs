using Newtonsoft.Json;
using System.Collections.Generic;

namespace FauxSharp.Lib.Models.ResponseModels.Data
{
    public class Bruteforceblocker
    {

        [JsonProperty("url")] 
        public string Url { get; set; }

        [JsonProperty("status")] 
        public List<string> Status { get; set; }

    }

    public class Updates
    {

        [JsonProperty("bruteforceblocker")] 
        public Bruteforceblocker Bruteforceblocker { get; set; }

    }

    public class AliasUpdateUrlTables
    {

        [JsonProperty("updates")] 
        public Updates Updates { get; set; }

    }
}