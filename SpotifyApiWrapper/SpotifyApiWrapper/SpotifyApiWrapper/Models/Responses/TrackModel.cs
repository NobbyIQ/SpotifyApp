using Newtonsoft.Json;
using SpotifyApiWrapper.Models.Responses.Get;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApiWrapper.Models.Responses
{
    public class TrackModel
    {
        [JsonProperty("album", Required = Required.Always)]
        public AlbumModel Album { get; set; } = new AlbumModel();
        [JsonProperty("artists", Required = Required.Always)]
        public List<ArtistsModel> Artists { get; set; } = new List<ArtistsModel>();
        [JsonProperty("available_markets", Required = Required.Always)]
        public string[] AvailableMarkets { get; set; } = Array.Empty<string>();
        [JsonProperty("disc_number", Required = Required.Always)]
        public int DiscNumber { get; set; }
        [JsonProperty("duration_ms", Required = Required.Always)]
        public int DurationMs { get; set; }
        [JsonProperty("explicit", Required = Required.Always)]
        public bool Explicit { get; set; }
        [JsonProperty("external_ids", Required = Required.Always)]
        public ExternalIdsModel ExternalIds { get; set; } = new ExternalIdsModel();
        [JsonProperty("external_urls", Required = Required.Always)]
        public ExternalUrlModel ExternalUrls { get; set; } = new ExternalUrlModel();
        [JsonProperty("href", Required = Required.Always)]
        public string Href { get; set; } = string.Empty;
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; } = string.Empty;
        [JsonProperty("is_playable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPlayable { get; set; }
        [JsonProperty("linked_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public LinkedFromModel? LinkedFrom { get; set; }
        [JsonProperty("restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RestrictionsModel? Restrictions { get; set; }
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; } = string.Empty;
        [JsonProperty("popularity", Required = Required.Always)]
        public int Popularity { get; set; }
        [JsonProperty("preview_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PreviewUrl { get; set; }
        [JsonProperty("track_number", Required = Required.Always)]
        public int TrackNumber { get; set; }
        [JsonProperty("type", Required = Required.Always)]
        public string Type { get; set; } = string.Empty;
        [JsonProperty("uri", Required = Required.Always)]
        public string Uri { get; set; } = string.Empty;
        [JsonProperty("is_local", Required = Required.Always)]
        public bool IsLocal { get; set; }
    }
}
