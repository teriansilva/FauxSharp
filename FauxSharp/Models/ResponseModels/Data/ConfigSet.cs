using Newtonsoft.Json;

namespace FauxSharp.Models.ResponseModels.Data
{
    public class ConfigSet
    {

        [JsonProperty("do_backup")]
        public bool DoBackup { get; set; }

        [JsonProperty("do_reload")]
        public bool DoReload { get; set; }

        [JsonProperty("previous_config_file")]
        public string PreviousConfigFile { get; set; }

    }
}
