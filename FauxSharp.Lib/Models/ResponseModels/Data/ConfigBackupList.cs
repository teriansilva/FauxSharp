using Newtonsoft.Json;
using System.Collections.Generic;

namespace FauxSharp.Lib.Models.ResponseModels.Data
{
    public class ConfigBackupList
    {

        [JsonProperty("backup_files")]
        public List<BackupFile> BackupFiles { get; set; }

    }

    public class BackupFile
    {

        [JsonProperty("filename")]
        public string Filename { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("filesize")]
        public int Filesize { get; set; }

    }

}
