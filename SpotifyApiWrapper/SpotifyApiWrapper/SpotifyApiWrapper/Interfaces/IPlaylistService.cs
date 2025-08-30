using SpotifyApiWrapper.Models.Responses;
using SpotifyApiWrapper.Models.Responses.Get;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApiWrapper.Interfaces
{
    public interface IPlaylistService
    {
        Task<PlaylistModel?> GetPlaylistAsync(string playlistId, string? market, string? fields, string? additionalTypes);

        Task<CurrentUserPlaylistsModel?> GetCurrentUserPlaylistsAsync(int limit, int offset);

        Task<PlaylistModel?> CreatePlaylistAsync(string userId, string? name = null, bool? isPublic = null, bool? collaborative = null, string? description = null);

        Task<string?> AddItemsToPlaylistAsync(string playlistId, int position, string[] uris);
    }
}
