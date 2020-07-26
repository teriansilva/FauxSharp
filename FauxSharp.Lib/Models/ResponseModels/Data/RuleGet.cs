using System.Collections.Generic;
using Newtonsoft.Json;

namespace FauxSharp.Lib.Models.ResponseModels.Data
{
    public class Rule
    {

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("rule")]
        public string RuleName { get; set; }

        [JsonProperty("evaluations")]
        public string Evaluations { get; set; }

        [JsonProperty("packets")]
        public string Packets { get; set; }

        [JsonProperty("bytes")]
        public string Bytes { get; set; }

        [JsonProperty("states")]
        public string States { get; set; }

        [JsonProperty("inserted")]
        public string Inserted { get; set; }

        [JsonProperty("statecreations")]
        public string Statecreations { get; set; }

    }

    public class RuleGet
    {

        [JsonProperty("rules")]
        public List<Rule> Rules { get; set; }

    }
}
