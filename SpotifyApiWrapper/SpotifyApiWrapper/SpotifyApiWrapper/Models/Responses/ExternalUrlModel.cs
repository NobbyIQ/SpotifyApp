using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApiWrapper.Models.Responses
{
    public class ExternalUrlModel
    {
        [JsonProperty("spotify", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Spotify { get; set; } = string.Empty;
    }
}
