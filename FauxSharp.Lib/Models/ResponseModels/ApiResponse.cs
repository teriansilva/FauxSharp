using System;
using Newtonsoft.Json;

namespace FauxSharp.Lib.Models.ResponseModels
{
    public class ApiResponse
    {

        [JsonProperty("callid")]
        public string Callid { get; set; } 

        [JsonProperty("action")]
        public string Action { get; set; } 

        [JsonProperty("message")]
        public string Message { get; set; } 

        [JsonProperty("data")]
        public dynamic Data { get; set; }
    }

    public class ApiResponseData<T>
    {
        public ApiResponseData(ApiResponse response)
        {
            Callid = response.Callid;
            Action = response.Action;
            Message = response.Message;
            Data = JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(response.Data));
        }

        [JsonProperty("callid")]
        public string Callid { get; set; } 

        [JsonProperty("action")]
        public string Action { get; set; } 

        [JsonProperty("message")]
        public string Message { get; set; } 

        [JsonProperty("data")]
        public T Data { get; set; }
    }

}
