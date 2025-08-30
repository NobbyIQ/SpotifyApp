using SpotifyApiWrapper;
using SpotifyApiWrapper.Http;
using SpotifyApiWrapper.Models.Responses.Get;

namespace SpotifyAiRecomendations.Services
{
    public class PlaylistService
    {
        private readonly ISpotifyClient _spotifyClient;

        public PlaylistService(ISpotifyClient spotifyClient)
        {
            _spotifyClient = spotifyClient;
        }

        public async Task<CurrentUserPlaylistsModel> GetUsersPlaylistTracks(int? limit = 50, int? offset = 0)
        {
            var playlist = _spotifyClient.PlaylistService.GetCurrentUserPlaylistsAsync(50, 0);
        }
    }
}
