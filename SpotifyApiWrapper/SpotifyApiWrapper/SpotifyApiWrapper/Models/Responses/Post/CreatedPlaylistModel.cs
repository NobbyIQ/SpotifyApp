using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApiWrapper.Models.Responses.Post
{
    public class CreatedPlaylistModel
    {
        [JsonProperty("collaborative", Required = Required.Always)]
        public bool Collaborative { get; set; }

        [JsonProperty("description", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Include)]
        public string Description { get; set; } = string.Empty;

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

        [JsonProperty("owner", Required = Required.Always)]
        public OwnerModel Owner { get; set; } = new OwnerModel();

        [JsonProperty("public", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Include)]
        public bool Public { get; set; }

        [JsonProperty("snapshot_id", Required = Required.Always)]
        public string SnapshotId { get; set; } = string.Empty;

        [JsonProperty("tracks", Required = Required.Always)]
        public TracksModel Tracks { get; set; } = new TracksModel();

        [JsonProperty("type", Required = Required.Always)]
        public string Type { get; set; } = string.Empty;

        [JsonProperty("uri", Required = Required.Always)]
        public string Uri { get; set; } = string.Empty;
    }
}
