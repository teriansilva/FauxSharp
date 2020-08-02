using System.Collections.Generic;
using System.Threading.Tasks;
using FauxSharp.Constants;
using FauxSharp.Lib.Models.ResponseModels;
using FauxSharp.Lib.Models.ResponseModels.Data;

namespace FauxSharp.Services
{
    public interface IApiService
    {
        /// <summary>
        /// Causes the pfSense host to immediately update any urltable alias entries from their (remote) source URLs.
        /// Optionally update just one table by specifying the table name, else all tables are updated.
        /// </summary>
        /// <param name="arguments">table (optional, default = null)</param>
        /// <returns></returns>
        Task<ApiResponseData<AliasUpdateUrlTables>> AliasUpdateUrlTables(IDictionary<string, string> arguments = null);

        /// <summary>
        /// Causes the system to take a configuration backup and add it to the regular set of pfSense system backups at
        /// /cf/conf/backup/
        /// </summary>
        /// <returns></returns>
        Task<ApiResponseData<ConfigBackup>> ConfigBackup();

        /// <summary>
        /// Returns a list of the currently available pfSense system configuration backups.
        /// </summary>
        /// <returns></returns>
        Task<ApiResponseData<ConfigBackupList>> ConfigBackupList();

        /// <summary>
        /// Returns the system configuration as a JSON formatted string. Additionally, using the optional config_file
        /// parameter it is possible to retrieve backup configurations by providing the full path to it under the
        /// /cf/conf/backup path.
        /// </summary>
        /// <param name="arguments">config_file (optional, default=/cf/config/config.xml)</param>
        /// <returns></returns>
        Task<ApiResponseData<ConfigGet>> ConfigGet(IDictionary<string, string> arguments = null);

        /// <summary>
        /// Allows the API user to patch the system configuration with the existing system config
        /// A config_patch call allows the API user to supply the partial configuration to be updated which is quite
        /// different to the config_set function that requires the full configuration to be posted.
        /// </summary>
        /// <param name="bodyData"></param>
        /// <param name="arguments">do_backup (optional, default = true), do_reload (optional, default = true)</param>
        /// <returns></returns>
        Task<ApiResponseData<ConfigPatch>> ConfigPatch(string bodyData = "[]", IDictionary<string, string> arguments = null);

        /// <summary>
        /// Causes the pfSense system to perform a reload action of the config.xml file, by default this happens when the
        /// config_set action occurs hence there is normally no need to explicitly call this after a config_set action.
        /// </summary>
        /// <returns></returns>
        Task<ApiResponse> ConfigReload();

        /// <summary>
        /// Restores the pfSense system to the named backup configuration.
        /// </summary>
        /// <param name="arguments">config_file (required, full path to the backup file to restore)</param>
        /// <returns></returns>
        Task<ApiResponseData<ConfigRestore>> ConfigRestore(IDictionary<string, string> arguments = null);

        /// <summary>
        /// ets a full system configuration and (by default) takes a system config backup and (by default) causes the system
        /// config to be reloaded once successfully written and tested.
        /// NB1: be sure to pass the FULL system configuration here, not just the piece you wish to adjust! Consider the
        /// config_patch or config_item_set functions if you wish to adjust the configuration in more granular ways.
        /// NB2: if you are pulling down the result of a config_get call, be sure to parse that response data to obtain the
        /// config data only under the key .data.config
        /// </summary>
        /// <param name="bodyData"></param>
        /// <param name="arguments">do_backup (optional, default = true) do_reload (optional, default = true)</param>
        /// <returns></returns>
        Task<ApiResponseData<ConfigSet>> ConfigSet(string bodyData = "[]", IDictionary<string, string> arguments = null);

        /// <summary>
        /// Call directly a pfSense PHP function with API user supplied parameters. Note that is action is a VERY raw
        /// interface into the inner workings of pfSense and it is not recommended for API users that do not have a solid
        /// understanding of PHP and pfSense. Additionally, not all pfSense functions are appropriate to be called through
        /// the FauxAPI and only very limited testing has been performed against the possible outcomes and responses. It is
        /// possible to harm your pfSense system if you do not 100% understand what is going on.
        /// Functions to be called via this interface MUST be defined in the file /etc/pfsense_function_calls.txt only a
        /// handful very basic and read-only pfSense functions are enabled by default.
        /// </summary>
        /// <param name="bodyData"></param>
        /// <returns></returns>
        Task<ApiResponseData<FunctionCall>> FunctionCall(string bodyData);

        /// <summary>
        /// Returns gateway status data.
        /// </summary>
        /// <returns></returns>
        Task<ApiResponseData<GatewayStatus>> GatewayStatus();

        /// <summary>
        /// Returns interface statistics data and information - the real interface name must be provided not an alias of the
        /// interface such as "WAN" or "LAN"
        /// </summary>
        /// <param name="arguments">interface (required)</param>
        /// <returns></returns>
        Task<ApiResponseData<InterfaceStats>> InterfaceStats(IDictionary<string, string> arguments);

        /// <summary>
        /// Returns the numbered list of loaded pf rules from a pfctl -sr -vv command on the pfSense host. An empty
        /// rule_number parameter causes all rules to be returned.
        /// </summary>
        /// <param name="arguments">rule_number (optional, default = null)</param>
        /// <returns></returns>
        Task<ApiResponseData<RuleGet>> RuleGet(IDictionary<string, string> arguments = null);

        /// <summary>
        /// Performs a pfSense "send_event" command to cause various pfSense system actions as is also available through the
        /// pfSense console interface. The following standard pfSense send_event combinations are permitted:-
        /// filter: reload, sync
        /// interface: all, newip, reconfigure
        /// service: reload, restart, sync
        /// </summary>
        /// <param name="bodyData"></param>
        /// <returns></returns>
        Task<ApiResponse> SendEvent(string bodyData);

        /// <summary>
        /// Reboots the system.
        /// </summary>
        /// <returns></returns>
        Task<ApiResponse> SystemReboot();

        /// <summary>
        /// Returns various useful system stats.
        /// </summary>
        /// <returns></returns>
        Task<ApiResponseData<SystemStats>> SystemStats();
    }

    public class ApiService : IApiService
    {
        private readonly IApiBaseService _apiBaseService;
        public ApiService(IApiBaseService apiBaseService)
        {
            _apiBaseService = apiBaseService;
        }

        /// <inheritdoc />
        public async Task<ApiResponseData<AliasUpdateUrlTables>> AliasUpdateUrlTables(IDictionary<string, string> arguments = null)
        {
            var response = await _apiBaseService.ApiRequest("GET", ApiAction.AliasUpdateUrlTables, arguments: arguments);
            return new ApiResponseData<AliasUpdateUrlTables>(response);
        }

        /// <inheritdoc />
        public async Task<ApiResponseData<ConfigBackup>> ConfigBackup()
        {
            var response = await _apiBaseService.ApiRequest("GET", ApiAction.ConfigBackup);
            return new ApiResponseData<ConfigBackup>(response);
        }

        /// <inheritdoc />
        public async Task<ApiResponseData<ConfigBackupList>> ConfigBackupList()
        {
            var response = await _apiBaseService.ApiRequest("GET", ApiAction.ConfigBackupList);
            return new ApiResponseData<ConfigBackupList>(response);
        }

        /// <inheritdoc />
        public async Task<ApiResponseData<ConfigGet>> ConfigGet(IDictionary<string, string> arguments = null)
        {
            var response = await _apiBaseService.ApiRequest("GET", ApiAction.ConfigGet, arguments: arguments);
            return new ApiResponseData<ConfigGet>(response);
        }

        /// <inheritdoc />
        public async Task<ApiResponseData<ConfigPatch>> ConfigPatch(string bodyData = "[]", IDictionary<string, string> arguments = null)
        {
            var response = await _apiBaseService.ApiRequest("POST", ApiAction.ConfigPatch, bodyData, arguments);
            return new ApiResponseData<ConfigPatch>(response);
        }

        /// <inheritdoc />
        public async Task<ApiResponse> ConfigReload()
        {
            return await _apiBaseService.ApiRequest("GET", ApiAction.ConfigReload);
        }

        /// <inheritdoc />
        public async Task<ApiResponseData<ConfigRestore>> ConfigRestore(IDictionary<string, string> arguments = null)
        {
            var response = await _apiBaseService.ApiRequest("GET", ApiAction.ConfigRestore, arguments: arguments);
            return new ApiResponseData<ConfigRestore>(response);
        }

        /// <inheritdoc />
        public async Task<ApiResponseData<ConfigSet>> ConfigSet(string bodyData = "[]", IDictionary<string, string> arguments = null)
        {
            var response = await _apiBaseService.ApiRequest("POST", ApiAction.ConfigSet, bodyData, arguments);
            return new ApiResponseData<ConfigSet>(response);
        }

        /// <inheritdoc />
        public async Task<ApiResponseData<FunctionCall>> FunctionCall(string bodyData)
        {
            var response = await _apiBaseService.ApiRequest("POST", ApiAction.FunctionCall, bodyData);
            return new ApiResponseData<FunctionCall>(response);
        }

        /// <inheritdoc />
        public async Task<ApiResponseData<GatewayStatus>> GatewayStatus()
        {
            var response = await _apiBaseService.ApiRequest("GET", ApiAction.GatewayStatus);
            return new ApiResponseData<GatewayStatus>(response);
        }

        /// <inheritdoc />
        public async Task<ApiResponseData<InterfaceStats>> InterfaceStats(IDictionary<string, string> arguments)
        {
            var response = await _apiBaseService.ApiRequest("GET", ApiAction.InterfaceStats, arguments: arguments);
            return new ApiResponseData<InterfaceStats>(response);
        }

        /// <inheritdoc />
        public async Task<ApiResponseData<RuleGet>> RuleGet(IDictionary<string, string> arguments = null)
        {
            var response = await _apiBaseService.ApiRequest("GET", ApiAction.RuleGet, arguments: arguments);
            return new ApiResponseData<RuleGet>(response);
        }

        /// <inheritdoc />
        public async Task<ApiResponse> SendEvent(string bodyData)
        {
            return await _apiBaseService.ApiRequest("POST", ApiAction.SendEvent, bodyData);
        }

        /// <inheritdoc />
        public async Task<ApiResponse> SystemReboot()
        {
            return await _apiBaseService.ApiRequest("GET", ApiAction.SystemReboot);
        }

        /// <inheritdoc />
        public async Task<ApiResponseData<SystemStats>> SystemStats()
        {
            var response = await _apiBaseService.ApiRequest("GET", ApiAction.SystemStats);
            return new ApiResponseData<SystemStats>(response);
        }
    }
}
