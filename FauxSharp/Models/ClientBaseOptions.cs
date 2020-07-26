using System;

namespace FauxSharp.Models
{
    public class ClientBaseOptions
    {

        public ClientBaseOptions(string uri, string apiKey, string apiSecret, bool debug, bool insecure)
        {
            Uri = uri;
            ApiKey = apiKey;
            ApiSecret = apiSecret;
            Debug = debug;
            Insecure = insecure;
        }
        public string Uri { get; set; }
        public string ApiKey { get; set; }
        public string ApiSecret { get; set; }
        public bool Debug { get; set; }
        public bool Insecure { get; set; }
    };
}
