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
        Task<string> GetAsync(string route, IDictionary<string, string>? header);
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

        public async Task<string> GetAsync(string apiCall, IDictionary<string, string>? header)
        {
            try
            {
                var request = new HttpRequestMessage(HttpMethod.Get, baseAdress + apiCall);
                if (header != null)
                {
                    request.Headers.Add(header.Keys.First(), header.Values.First());
                }


                var result = await _httpClient.SendAsync(request) ?? null!;

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
                //var result = await _httpClient.PostAsJsonAsync(baseAdress + route, JsonConvert.SerializeObject(data));

                
                
                var request = new HttpRequestMessage(HttpMethod.Post, new Uri($"{baseAdress}{route}"))
                {
                    Content = new StringContent(data, Encoding.UTF8, "application/json")
                };
               


                var result = await _httpClient.SendAsync(request);

                return await result.Content.ReadAsStringAsync();
            }
            catch
            {
                return null!;
            }
        }
    }
}
