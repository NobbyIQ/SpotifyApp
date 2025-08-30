using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApiWrapper.Models.Responses.Get
{
    public class AlbumModel
    {
        [JsonProperty("album_type", Required = Required.Always)]
        public string AlbumType { get; set; } = string.Empty;
        [JsonProperty("total_tracks", Required = Required.Always)]
        public int TotalTracks { get; set; }
        [JsonProperty("available_markets", Required = Required.Always)]
        public string[] AvailableMarkets { get; set; } = Array.Empty<string>();
        [JsonProperty("external_urls", Required = Required.Always)]
        public ExternalUrlModel ExternalUrls { get; set; } = new ExternalUrlModel();
        [JsonProperty("href", Required = Required.Always)]
        public string Href { get; set; } = string.Empty;
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; } = string.Empty;
        [JsonProperty("images", Required = Required.Always)]
        public List<ImageModel> Images { get; set; } = new List<ImageModel>();
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; } = string.Empty;
        [JsonProperty("release_date", Required = Required.Always)]
        public string ReleaseDate { get; set; } = string.Empty;
        [JsonProperty("release_date_precision", Required = Required.Always)]
        public string ReleaseDatePrecision { get; set; } = string.Empty;
        [JsonProperty("restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RestrictionsModel? Restrictions { get; set; }
        [JsonProperty("type", Required = Required.Always)]
        public string Type { get; set; } = string.Empty;
        [JsonProperty("uri", Required = Required.Always)]
        public string Uri { get; set; } = string.Empty;
    }
}
