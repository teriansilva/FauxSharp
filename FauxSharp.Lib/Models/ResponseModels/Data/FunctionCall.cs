using System.Collections.Generic;
using Newtonsoft.Json;

namespace FauxSharp.Lib.Models.ResponseModels.Data
{
    public class FunctionCallReturn
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

    }

    public class FunctionCall
    {

        [JsonProperty("return")]
        public List<FunctionCallReturn> Return { get; set; }

    }
}
