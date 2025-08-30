using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApiWrapper.Models.Requests
{
    public class CreatePlaylistRequestModel
    {
        [JsonProperty("name", Required = Required.Always)]
        public string? Name { get; set; } = string.Empty;

        [JsonProperty("public", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Public { get; set; } = null;

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Collaborative { get; set; } = null;

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; } = null;
    }
}
