using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApiWrapper.Http
{
    public interface ISpotifyApiHttpClient
    {
        Task<HttpResponseMessage> PostAsync(string url, HttpContent httpContent);
        Task<HttpResponseMessage> GetAsync(string url);
        Task<HttpResponseMessage> PutAsync(string url, HttpContent httpContent);
    }
}
