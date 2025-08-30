using SpotifyApiWrapper.Http;
using SpotifyApiWrapper.Interfaces;
using SpotifyApiWrapper.Models.Requests;
using SpotifyApiWrapper.Models.Responses;
using SpotifyApiWrapper.Models.Responses.Get;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SpotifyApiWrapper.Services
{
    public class PlaylistService : IPlaylistService
    {
        private readonly ISpotifyApiHttpClient _spotifyApiHttpClient;

        public PlaylistService(ISpotifyApiHttpClient spotifyApiHttpClient)
        {
            _spotifyApiHttpClient = spotifyApiHttpClient;
        }

        public async Task<PlaylistModel?> GetPlaylistAsync(string playlistId, string? market, string? fields, string? additionalTypes)
        {
            List<string> queryParams = new List<string>();
            if (!string.IsNullOrEmpty(market))
            {
                queryParams.Add("market=" + market);
            }
            if (!string.IsNullOrEmpty(fields))
            {
                queryParams.Add("fields=" + fields);
            }
            if (!string.IsNullOrEmpty(additionalTypes))
            {
                queryParams.Add("additional_types=" + additionalTypes);
            }
            string queryString = ((queryParams.Count > 0) ? ("?" + string.Join("&", queryParams)) : "");
            return JsonSerializer.Deserialize<PlaylistModel>(await (await _spotifyApiHttpClient.GetAsync("playlists/" + playlistId + queryString)).Content.ReadAsStringAsync(), new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }

        public async Task<CurrentUserPlaylistsModel?> GetCurrentUserPlaylistsAsync(int limit = 50, int offset = 0)
        {
            List<string> queryParams = new List<string>
        {
            $"limit={limit}",
            $"offset={offset}"
        };
            return JsonSerializer.Deserialize<CurrentUserPlaylistsModel>(await (await _spotifyApiHttpClient.GetAsync("me/playlists?" + string.Join("&", queryParams))).Content.ReadAsStringAsync(), new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }

        public async Task<PlaylistModel?> CreatePlaylistAsync(string userId, string? name, bool? isPublic, bool? collaborative, string? description)
        {
            CreatePlaylistRequestModel request = new CreatePlaylistRequestModel
            {
                Name = name,
                Public = isPublic,
                Collaborative = collaborative,
                Description = description
            };
            string json = JsonSerializer.Serialize(request);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            return JsonSerializer.Deserialize<PlaylistModel>(await (await _spotifyApiHttpClient.PostAsync("users/" + userId + "/playlists", content)).Content.ReadAsStringAsync(), new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
        }

        public async Task<string?> AddItemsToPlaylistAsync(string playlistId, int position, string[] uris)
        {
            var body = new { uris, position };
            string json = JsonSerializer.Serialize(body);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
            string? snapshotId = JsonSerializer.Deserialize<string>(await (await _spotifyApiHttpClient.PostAsync("playlists/" + playlistId + "/tracks", content)).Content.ReadAsStringAsync(), new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });
            return snapshotId ?? string.Empty;
        }
    }
}
