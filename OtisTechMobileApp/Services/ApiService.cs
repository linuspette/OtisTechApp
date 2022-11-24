using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OtisTechMobileApp.Services
{
    public interface IApiService
    {
        Task<string> GetAsync(string route);
        Task<string> PostAsync(string route, string data);
    }

    public class ApiService : IApiService
    {
        private readonly HttpClient _httpClient;
        private readonly string baseAdress = "https://otisagileapi.azurewebsites.net/api/";
        public ApiService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> GetAsync(string route)
        {
            try
            {
                var result = await _httpClient.GetAsync(baseAdress + route);
                return await result.Content.ReadAsStringAsync();
            }
            catch
            {
                return null!;
            }
            
        }

        public async Task<string> PostAsync(string route, string data)
        {
            try
            {
                var result = await _httpClient.PostAsJsonAsync(baseAdress + route, JsonConvert.SerializeObject(data));

                return await result.Content.ReadAsStringAsync();
            }
            catch
            {
                return null!;
            }
        }
    }
}
