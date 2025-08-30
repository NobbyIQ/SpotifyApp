using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApiWrapper.Models.Responses
{
    public class TracksModel
    {
        [JsonProperty("href", Required = Required.Always)]
        public string Href { get; set; } = string.Empty;

        [JsonProperty("limit", Required = Required.Always)]
        public int Limit { get; set; }

        [JsonProperty("next", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Include)]
        public string? Next { get; set; }

        [JsonProperty("offset", Required = Required.Always)]
        public int Offset { get; set; }

        [JsonProperty("previous", Required = Required.AllowNull, NullValueHandling = NullValueHandling.Include)]
        public string? Previous { get; set; }

        [JsonProperty("total", Required = Required.Always)]
        public int Total { get; set; }

        [JsonProperty("items", Required = Required.Always)]
        public List<PlaylistTrackModel> Items { get; set; } = new List<PlaylistTrackModel>();
    }
}
