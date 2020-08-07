using System.Collections.Generic;
using FauxSharp.Lib.Models.ResponseModels.Data.ConfigGetData;
using Newtonsoft.Json;

namespace FauxSharp.Lib.Models.ResponseModels.Data
{
    public class ConfigGet
    {
        [JsonProperty("config_file")] public string ConfigFile { get; set; }

        [JsonProperty("config")] public ConfigGetConfig Config { get; set; }
    }
}
namespace FauxSharp.Lib.Models.ResponseModels.Data.ConfigGetData
{
    public class Group
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("gid")]
        public string Gid { get; set; }

        [JsonProperty("member")]
        public List<string> Member { get; set; }

        [JsonProperty("priv")]
        public List<string> Priv { get; set; }
    }

    public class User
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("descr")]
        public string Descr { get; set; }

        [JsonProperty("scope")]
        public string Scope { get; set; }

        [JsonProperty("groupname")]
        public string Groupname { get; set; }

        [JsonProperty("bcrypt-hash")]
        public string BcryptHash { get; set; }

        [JsonProperty("uid")]
        public string Uid { get; set; }

        [JsonProperty("priv")]
        public List<string> Priv { get; set; }
    }

    public class Webgui
    {
        [JsonProperty("protocol")]
        public string Protocol { get; set; }

        [JsonProperty("loginautocomplete")]
        public string Loginautocomplete { get; set; }

        [JsonProperty("ssl-certref")]
        public string SslCertref { get; set; }
    }

    public class Bogons
    {
        [JsonProperty("interval")]
        public string Interval { get; set; }
    }

    public class System
    {
        [JsonProperty("optimization")]
        public string Optimization { get; set; }

        [JsonProperty("hostname")]
        public string Hostname { get; set; }

        [JsonProperty("domain")]
        public string Domain { get; set; }

        [JsonProperty("dnsserver")]
        public List<string> Dnsserver { get; set; }

        [JsonProperty("dnsallowoverride")]
        public string Dnsallowoverride { get; set; }

        [JsonProperty("group")]
        public List<Group> Group { get; set; }

        [JsonProperty("user")]
        public List<User> User { get; set; }

        [JsonProperty("nextuid")]
        public string Nextuid { get; set; }

        [JsonProperty("nextgid")]
        public string Nextgid { get; set; }

        [JsonProperty("timeservers")]
        public string Timeservers { get; set; }

        [JsonProperty("webgui")]
        public Webgui Webgui { get; set; }

        [JsonProperty("disablenatreflection")]
        public string Disablenatreflection { get; set; }

        [JsonProperty("disablesegmentationoffloading")]
        public string Disablesegmentationoffloading { get; set; }

        [JsonProperty("disablelargereceiveoffloading")]
        public string Disablelargereceiveoffloading { get; set; }

        [JsonProperty("ipv6allow")]
        public string Ipv6allow { get; set; }

        [JsonProperty("maximumtableentries")]
        public string Maximumtableentries { get; set; }

        [JsonProperty("powerd_ac_mode")]
        public string PowerdAcMode { get; set; }

        [JsonProperty("powerd_battery_mode")]
        public string PowerdBatteryMode { get; set; }

        [JsonProperty("powerd_normal_mode")]
        public string PowerdNormalMode { get; set; }

        [JsonProperty("bogons")]
        public Bogons Bogons { get; set; }

        [JsonProperty("enableserial")]
        public string Enableserial { get; set; }

        [JsonProperty("already_run_config_upgrade")]
        public string AlreadyRunConfigUpgrade { get; set; }
    }

    public class Wan
    {
        [JsonProperty("enable")]
        public string Enable { get; set; }

        [JsonProperty("if")]
        public string If { get; set; }

        [JsonProperty("mtu")]
        public string Mtu { get; set; }

        [JsonProperty("ipaddr")]
        public string Ipaddr { get; set; }

        [JsonProperty("ipaddrv6")]
        public string Ipaddrv6 { get; set; }

        [JsonProperty("subnet")]
        public string Subnet { get; set; }

        [JsonProperty("gateway")]
        public string Gateway { get; set; }

        [JsonProperty("blockpriv")]
        public string Blockpriv { get; set; }

        [JsonProperty("blockbogons")]
        public string Blockbogons { get; set; }

        [JsonProperty("dhcphostname")]
        public string Dhcphostname { get; set; }

        [JsonProperty("media")]
        public string Media { get; set; }

        [JsonProperty("mediaopt")]
        public string Mediaopt { get; set; }

        [JsonProperty("dhcp6-duid")]
        public string Dhcp6Duid { get; set; }

        [JsonProperty("dhcp6-ia-pd-len")]
        public string Dhcp6IaPdLen { get; set; }
    }

    public class Lan
    {
        [JsonProperty("enable")]
        public string Enable { get; set; }

        [JsonProperty("if")]
        public string If { get; set; }

        [JsonProperty("ipaddr")]
        public string Ipaddr { get; set; }

        [JsonProperty("subnet")]
        public string Subnet { get; set; }

        [JsonProperty("ipaddrv6")]
        public string Ipaddrv6 { get; set; }

        [JsonProperty("subnetv6")]
        public string Subnetv6 { get; set; }

        [JsonProperty("media")]
        public string Media { get; set; }

        [JsonProperty("mediaopt")]
        public string Mediaopt { get; set; }

        [JsonProperty("track6-interface")]
        public string Track6Interface { get; set; }

        [JsonProperty("track6-prefix-id")]
        public string Track6PrefixId { get; set; }
    }

    public class Interfaces
    {
        [JsonProperty("wan")]
        public Wan Wan { get; set; }

        [JsonProperty("lan")]
        public Lan Lan { get; set; }
    }

    public class Range
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }
    }

    public class Lan2
    {
        [JsonProperty("enable")]
        public string Enable { get; set; }

        [JsonProperty("range")]
        public Range Range { get; set; }
    }

    public class Dhcpd
    {
        [JsonProperty("lan")]
        public Lan2 Lan { get; set; }
    }

    public class Range2
    {
        [JsonProperty("from")]
        public string From { get; set; }

        [JsonProperty("to")]
        public string To { get; set; }
    }

    public class Lan3
    {
        [JsonProperty("enable")]
        public string Enable { get; set; }

        [JsonProperty("range")]
        public Range2 Range { get; set; }

        [JsonProperty("ramode")]
        public string Ramode { get; set; }

        [JsonProperty("rapriority")]
        public string Rapriority { get; set; }
    }

    public class Dhcpdv6
    {
        [JsonProperty("lan")]
        public Lan3 Lan { get; set; }
    }

    public class Snmpd
    {
        [JsonProperty("syslocation")]
        public string Syslocation { get; set; }

        [JsonProperty("syscontact")]
        public string Syscontact { get; set; }

        [JsonProperty("rocommunity")]
        public string Rocommunity { get; set; }
    }

    public class Ipv6nat
    {
        [JsonProperty("ipaddr")]
        public string Ipaddr { get; set; }
    }

    public class Diag
    {
        [JsonProperty("ipv6nat")]
        public Ipv6nat Ipv6nat { get; set; }
    }

    public class Syslog
    {
        [JsonProperty("filterdescriptions")]
        public string Filterdescriptions { get; set; }
    }

    public class Outbound
    {
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }

    public class Nat
    {
        [JsonProperty("outbound")]
        public Outbound Outbound { get; set; }
    }

    public class Source
    {
        [JsonProperty("network")]
        public string Network { get; set; }
    }

    public class Destination
    {
        [JsonProperty("any")]
        public string Any { get; set; }
    }

    public class Rule
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("ipprotocol")]
        public string Ipprotocol { get; set; }

        [JsonProperty("descr")]
        public string Descr { get; set; }

        [JsonProperty("interface")]
        public string Interface { get; set; }

        [JsonProperty("tracker")]
        public string Tracker { get; set; }

        [JsonProperty("source")]
        public Source Source { get; set; }

        [JsonProperty("destination")]
        public Destination Destination { get; set; }
    }

    public class Filter
    {
        [JsonProperty("rule")]
        public List<Rule> Rule { get; set; }
    }

    public class Item
    {
        [JsonProperty("minute")]
        public string Minute { get; set; }

        [JsonProperty("hour")]
        public string Hour { get; set; }

        [JsonProperty("mday")]
        public string Mday { get; set; }

        [JsonProperty("month")]
        public string Month { get; set; }

        [JsonProperty("wday")]
        public string Wday { get; set; }

        [JsonProperty("who")]
        public string Who { get; set; }

        [JsonProperty("command")]
        public string Command { get; set; }
    }

    public class Cron
    {
        [JsonProperty("item")]
        public List<Item> Item { get; set; }
    }

    public class Rrd
    {
        [JsonProperty("enable")]
        public string Enable { get; set; }
    }

    public class MonitorType
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("descr")]
        public string Descr { get; set; }

        [JsonProperty("options")]
        public object Options { get; set; }
    }

    public class LoadBalancer
    {
        [JsonProperty("monitor_type")]
        public List<MonitorType> MonitorType { get; set; }
    }

    public class Widgets
    {
        [JsonProperty("sequence")]
        public string Sequence { get; set; }

        [JsonProperty("period")]
        public string Period { get; set; }
    }

    public class Unbound
    {
        [JsonProperty("enable")]
        public string Enable { get; set; }

        [JsonProperty("dnssec")]
        public string Dnssec { get; set; }

        [JsonProperty("active_interface")]
        public string ActiveInterface { get; set; }

        [JsonProperty("outgoing_interface")]
        public string OutgoingInterface { get; set; }

        [JsonProperty("custom_options")]
        public string CustomOptions { get; set; }

        [JsonProperty("hideidentity")]
        public string Hideidentity { get; set; }

        [JsonProperty("hideversion")]
        public string Hideversion { get; set; }

        [JsonProperty("dnssecstripped")]
        public string Dnssecstripped { get; set; }
    }

    public class Revision
    {
        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public class Cert
    {
        [JsonProperty("refid")]
        public string Refid { get; set; }

        [JsonProperty("descr")]
        public string Descr { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("crt")]
        public string Crt { get; set; }

        [JsonProperty("prv")]
        public string Prv { get; set; }
    }

    public class Tab
    {
        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("active")]
        public string Active { get; set; }
    }

    public class Tabs
    {
        [JsonProperty("tab")]
        public List<Tab> Tab { get; set; }
    }

    public class Package
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("internal_name")]
        public string InternalName { get; set; }

        [JsonProperty("descr")]
        public string Descr { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("category")]
        public string Category { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("required_version")]
        public string RequiredVersion { get; set; }

        [JsonProperty("configurationfile")]
        public string Configurationfile { get; set; }

        [JsonProperty("maintainer")]
        public string Maintainer { get; set; }

        [JsonProperty("tabs")]
        public Tabs Tabs { get; set; }
    }

    public class Menu
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("tooltiptext")]
        public string Tooltiptext { get; set; }

        [JsonProperty("section")]
        public string Section { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public class Installedpackages
    {
        [JsonProperty("package")]
        public List<Package> Package { get; set; }

        [JsonProperty("menu")]
        public List<Menu> Menu { get; set; }
    }

    public class ConfigGetConfig
    {
        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("lastchange")]
        public string Lastchange { get; set; }

        [JsonProperty("system")]
        public System System { get; set; }

        [JsonProperty("interfaces")]
        public Interfaces Interfaces { get; set; }

        [JsonProperty("staticroutes")]
        public string Staticroutes { get; set; }

        [JsonProperty("dhcpd")]
        public Dhcpd Dhcpd { get; set; }

        [JsonProperty("dhcpdv6")]
        public Dhcpdv6 Dhcpdv6 { get; set; }

        [JsonProperty("snmpd")]
        public Snmpd Snmpd { get; set; }

        [JsonProperty("diag")]
        public Diag Diag { get; set; }

        [JsonProperty("syslog")]
        public Syslog Syslog { get; set; }

        [JsonProperty("nat")]
        public Nat Nat { get; set; }

        [JsonProperty("filter")]
        public Filter Filter { get; set; }

        [JsonProperty("shaper")]
        public string Shaper { get; set; }

        [JsonProperty("ipsec")]
        public string Ipsec { get; set; }

        [JsonProperty("aliases")]
        public string Aliases { get; set; }

        [JsonProperty("proxyarp")]
        public string Proxyarp { get; set; }

        [JsonProperty("cron")]
        public Cron Cron { get; set; }

        [JsonProperty("wol")]
        public string Wol { get; set; }

        [JsonProperty("rrd")]
        public Rrd Rrd { get; set; }

        [JsonProperty("load_balancer")]
        public LoadBalancer LoadBalancer { get; set; }

        [JsonProperty("widgets")]
        public Widgets Widgets { get; set; }

        [JsonProperty("openvpn")]
        public string Openvpn { get; set; }

        [JsonProperty("dnshaper")]
        public string Dnshaper { get; set; }

        [JsonProperty("unbound")]
        public Unbound Unbound { get; set; }

        [JsonProperty("revision")]
        public Revision Revision { get; set; }

        [JsonProperty("cert")]
        public List<Cert> Cert { get; set; }

        [JsonProperty("installedpackages")]
        public Installedpackages InstalledPackages { get; set; }
    }

}
