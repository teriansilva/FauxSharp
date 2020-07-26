using Newtonsoft.Json;

namespace FauxSharp.Lib.Models.ResponseModels
{
    public class ApiResponseRoot {

        [JsonProperty("callid")]
        public string Callid { get; set; } 

        [JsonProperty("action")]
        public string Action { get; set; } 

        [JsonProperty("message")]
        public string Message { get; set; } 

        [JsonProperty("data")]
        public dynamic Data { get; set; }
    }

}
