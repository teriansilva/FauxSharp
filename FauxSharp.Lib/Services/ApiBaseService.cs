using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using FauxSharp.Models;
using FauxSharp.Models.ResponseModels;
using Newtonsoft.Json;

namespace FauxSharp.Services
{
    public interface IApiBaseService
    {
        /// <summary>
        /// Provides API Response
        /// </summary>
        /// <param name="method"></param>
        /// <param name="apiAction"></param>
        /// <param name="bodyData"></param>
        /// <param name="arguments"></param>
        /// <returns></returns>
        Task<ApiResponseRoot> ApiRequest(string method, string apiAction, string bodyData = "", IDictionary<string, string> arguments = null);
    }

    public class ApiBaseService : IApiBaseService
    {

        private readonly ClientBaseOptions _clientBaseOptions;
        private readonly string ApiVersion = "v1";
        public ApiBaseService(ClientBaseOptions clientBaseOptions)
        {
            _clientBaseOptions = clientBaseOptions;
        }

        /// <inheritdoc />
        public async Task<ApiResponseRoot> ApiRequest(string method, string apiAction, string bodyData = "", IDictionary<string, string> arguments = null)
        {
            var client = new HttpClient();

            client.BaseAddress = new Uri("https://api.github.com");
            client.DefaultRequestHeaders.Add("User-Agent", "Server");
            client.DefaultRequestHeaders.Add("fauxapi-auth", GenerateAuth());

            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var url = BuildUri(apiAction, arguments);
            HttpResponseMessage response;
            switch (method)
            {
                case "GET":
                    response = await client.GetAsync(url);
                    break;
                case "POST":
                    response = await client.PostAsync(url, new StringContent(bodyData));
                    break;
                default:
                    throw new Exception("Please use either GET or POST method for api request");
            }

            response.EnsureSuccessStatusCode();
            var resp = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<ApiResponseRoot>(resp);
        }

        #region Internal
        private string GenerateRandomString(int length)
        {
            char[] charArray = "abcdefghijklmnopqrstuvw0123456789".ToCharArray();
            byte[] data1 = new byte[1];
            RNGCryptoServiceProvider cryptoServiceProvider = new RNGCryptoServiceProvider();
            cryptoServiceProvider.GetNonZeroBytes(data1);
            byte[] data2 = new byte[length];
            cryptoServiceProvider.GetNonZeroBytes(data2);
            StringBuilder stringBuilder = new StringBuilder(length);
            foreach (byte num in data2)
                stringBuilder.Append(charArray[num % charArray.Length]);
            return stringBuilder.ToString();

        }
        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private string GenerateAuth()
        {
            var timestamp = DateTime.Now;
            var nonce = GenerateRandomString(8);
            var hash = ComputeSha256Hash(_clientBaseOptions.ApiSecret + timestamp + nonce);
            return $"{_clientBaseOptions.ApiKey}:{timestamp}:{nonce}:{hash}";

        }
        private string BuildUri(string action, IDictionary<string, string> arguments)
        {
            if (_clientBaseOptions.Debug)
            {
                arguments.Add(new KeyValuePair<string, string>("__debug", _clientBaseOptions.Debug.ToString().ToLower()));
            }
            return _clientBaseOptions.Uri +
                   $"/fauxapi/{ApiVersion}/?" +
                   $"{HttpUtility.UrlEncode(string.Join("&", arguments.Select(x => $"{x.Key}={x.Value}")))}";
        }

        #endregion
    }
}
