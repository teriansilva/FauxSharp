using Newtonsoft.Json;

namespace FauxSharp.Models.ResponseModels.Data
{
    public class ConfigGet
    {
        [JsonProperty("config_file")]
        public string ConfigFile { get; set; }

        [JsonProperty("config")]
        public ConfigGetConfig Config { get; set; }
    }

    public class ConfigGetConfig
    {

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("staticroutes")]
        public string Staticroutes { get; set; }

        [JsonProperty("snmpd")]
        public Snmpd Snmpd { get; set; }

        [JsonProperty("shaper")]
        public string Shaper { get; set; }

        [JsonProperty("installedpackages")]
        public dynamic InstalledPackages { get; set; }
    }

    public class Snmpd
    {

        [JsonProperty("syscontact")]
        public string Syscontact { get; set; }

        [JsonProperty("rocommunity")]
        public string Rocommunity { get; set; }

        [JsonProperty("syslocation")]
        public string Syslocation { get; set; }
    }

}
