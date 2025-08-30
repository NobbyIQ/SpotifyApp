using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApiWrapper.Models.Responses
{
    public class ArtistsModel
    {
        [JsonProperty("external_urls", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<ExternalUrlModel> ExternalUrls { get; set; } = new List<ExternalUrlModel>();

        [JsonProperty("href", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Href { get; set; } = string.Empty;

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; } = string.Empty;

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; } = string.Empty;

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; } = string.Empty;
         
        [JsonProperty("uri", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; } = string.Empty;
    }
}
