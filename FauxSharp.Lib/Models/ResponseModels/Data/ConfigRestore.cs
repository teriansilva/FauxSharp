using Newtonsoft.Json;

namespace FauxSharp.Lib.Models.ResponseModels.Data
{
    public class ConfigBackup
    {

        [JsonProperty("backup_config_file")]
        public string BackupConfigFile { get; set; }

    }
}
