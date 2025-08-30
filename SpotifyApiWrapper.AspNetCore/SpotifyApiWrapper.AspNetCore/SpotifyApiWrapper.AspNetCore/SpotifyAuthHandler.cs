using SpotifyApiWrapper.Http.TokenProvider;
using SpotifyApiWrapper.Interfaces;

namespace SpotifyApiWrapper.Handlers
{
    public class SpotifyAuthHandler : DelegatingHandler
    {
        private readonly ISpotifyTokenProvider _spotifyTokenProvider;
        public SpotifyAuthHandler(ISpotifyTokenProvider spotifyTokenProvider)
        {
            _spotifyTokenProvider = spotifyTokenProvider ?? throw new ArgumentNullException(nameof(spotifyTokenProvider));
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var accessToken = await _spotifyTokenProvider.GetAccessTokenAsync();
            if (!string.IsNullOrEmpty(accessToken))
            {
                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            }
            return await base.SendAsync(request, cancellationToken);
        }
    }
}
