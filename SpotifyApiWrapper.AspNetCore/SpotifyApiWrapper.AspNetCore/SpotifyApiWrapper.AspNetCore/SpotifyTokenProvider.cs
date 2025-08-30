using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using SpotifyApiWrapper.Http.TokenProvider;
using SpotifyApiWrapper.Interfaces;

namespace SpotifyApiWrapper.Http.TokenProvider
{
    public class SpotifyTokenProvider : ISpotifyTokenProvider
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public SpotifyTokenProvider(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<string> GetAccessTokenAsync()
        {
            var context = _httpContextAccessor.HttpContext;
            if (context == null)
            {
                throw new Exception("HttpContext is null");
            }
            return await context.GetTokenAsync("access_token") ?? string.Empty;
        }
    }
}
