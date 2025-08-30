using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApiWrapper.Http
{
    public class SpotifyApiHttpClient : ISpotifyApiHttpClient
    {
        private readonly HttpClient _httpClient;

        public SpotifyApiHttpClient(string baseUrl)
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseUrl)
            };
        }

        public async Task<HttpResponseMessage> PostAsync(string url, HttpContent httpContent)
        {
            HttpResponseMessage res = await _httpClient.PostAsync(url, httpContent);
            await EnsureSuccess(res);
            return res;
        }

        public async Task<HttpResponseMessage> GetAsync(string url)
        {
            HttpResponseMessage res = await _httpClient.GetAsync(url);
            await EnsureSuccess(res);
            return res;
        }

        public async Task<HttpResponseMessage> PutAsync(string url, HttpContent httpContent)
        {
            HttpResponseMessage res = await _httpClient.PutAsync(url, httpContent);
            await EnsureSuccess(res);
            return res;
        }

        private static async Task EnsureSuccess(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                string errorMessage = await response.Content.ReadAsStringAsync();
                throw new HttpRequestException($"Request failed with status code {response.StatusCode}: {errorMessage}");
            }
        }
    }
}
