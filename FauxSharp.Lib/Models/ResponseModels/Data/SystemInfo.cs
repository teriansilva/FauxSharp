using System.Collections.Generic;
using Newtonsoft.Json;

namespace FauxSharp.Models.ResponseModels.Data
{
    public class Platform
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("descr")]
        public string Descr { get; set; }

    }

    public class Sys
    {

        [JsonProperty("platform")]
        public Platform Platform { get; set; }

        [JsonProperty("serial_no")]
        public string SerialNo { get; set; }

        [JsonProperty("device_id")]
        public string DeviceId { get; set; }

    }

    public class PfsenseVersion
    {

        [JsonProperty("product_version_string")]
        public string ProductVersionString { get; set; }

        [JsonProperty("product_version")]
        public string ProductVersion { get; set; }

        [JsonProperty("product_version_patch")]
        public string ProductVersionPatch { get; set; }

    }

    public class PfsenseRemoteVersion
    {

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("installed_version")]
        public string InstalledVersion { get; set; }

        [JsonProperty("pkg_version_compare")]
        public string PkgVersionCompare { get; set; }

    }

    public class CpuType
    {

        [JsonProperty("cpu_model")]
        public string CpuModel { get; set; }

        [JsonProperty("cpu_count")]
        public string CpuCount { get; set; }

        [JsonProperty("logic_cpu_count")]
        public string LogicCpuCount { get; set; }

        [JsonProperty("cpu_freq")]
        public string CpuFreq { get; set; }

    }

    public class Bios
    {

        [JsonProperty("vendor")]
        public string Vendor { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

    }

    public class SystemInfoData
    {

        [JsonProperty("sys")]
        public Sys Sys { get; set; }

        [JsonProperty("pfsense_version")]
        public PfsenseVersion PfsenseVersion { get; set; }

        [JsonProperty("pfsense_remote_version")]
        public PfsenseRemoteVersion PfsenseRemoteVersion { get; set; }

        [JsonProperty("os_verison")]
        public string OsVerison { get; set; }

        [JsonProperty("cpu_type")]
        public CpuType CpuType { get; set; }

        [JsonProperty("kernel_pti_status")]
        public string KernelPtiStatus { get; set; }

        [JsonProperty("mds_mitigation")]
        public string MdsMitigation { get; set; }

        [JsonProperty("bios")]
        public Bios Bios { get; set; }

    }

    public class SystemInfo
    {

        [JsonProperty("info")]
        public SystemInfoData Info { get; set; }

    }
}
