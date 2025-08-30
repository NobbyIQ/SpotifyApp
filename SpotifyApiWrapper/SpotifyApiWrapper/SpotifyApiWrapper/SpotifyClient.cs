using SpotifyApiWrapper.Interfaces;

namespace SpotifyApiWrapper
{

    public interface ISpotifyClient
    {
        IPlaylistService PlaylistService { get; }
    }

    public class SpotifyClient
    {
        public IPlaylistService Playlists { get; }

        public SpotifyClient(IPlaylistService playlistService)
        {
            Playlists = playlistService;
        }
    }
}
