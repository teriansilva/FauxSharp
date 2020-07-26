using Newtonsoft.Json;

namespace FauxSharp.Models.ResponseModels.Data
{
    public class ConfigRestore
    {

        [JsonProperty("config_file")]
        public string ConfigFile { get; set; }

    }
}
