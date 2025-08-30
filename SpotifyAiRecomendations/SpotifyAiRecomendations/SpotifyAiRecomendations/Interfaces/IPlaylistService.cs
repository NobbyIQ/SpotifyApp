using SpotifyApiWrapper.Models.Responses;
using SpotifyApiWrapper.Models.Responses.Get;

namespace SpotifyAiRecomendations.Interfaces
{
    public interface IPlaylistService
    {
        public Task<CurrentUserPlaylistsModel> GetUsersPlaylists();
    }
}
