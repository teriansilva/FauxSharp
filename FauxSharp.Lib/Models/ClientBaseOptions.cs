using System;
using System.Text.RegularExpressions;

namespace FauxSharp.Lib.Models
{
    public class ClientBaseOptions
    {

        public ClientBaseOptions(string uri, string apiKey, string apiSecret, bool debug, bool insecure)
        {
            //simple validation
            Regex r = new Regex("^[a-zA-Z0-9]*$");

            if (!r.IsMatch(apiKey)
                || !apiKey.StartsWith("PFFA") 
                || apiKey.Length < 12 
                || apiKey.Length > 40
                || apiSecret.Length < 40
                || apiSecret.Length > 128
                )
            {
                throw new Exception("You are not complying with the FauxApi authentication specs. Please see https://github.com/ndejong/pfsense_fauxapi#api-authentication for more information");
            }

            Uri = uri;
            ApiKey = apiKey;
            ApiSecret = apiSecret;
            Debug = debug;
            Insecure = insecure;
        }
        public string Uri { get; }
        public string ApiKey { get;}
        public string ApiSecret { get;}
        public bool Debug { get;}
        public bool Insecure { get;}
    };
}
