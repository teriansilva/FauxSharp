using Newtonsoft.Json;

namespace FauxSharp.Models.ResponseModels.Data
{
    public class ConfigBackup
    {

        [JsonProperty("backup_config_file")]
        public string BackupConfigFile { get; set; }

    }
}
