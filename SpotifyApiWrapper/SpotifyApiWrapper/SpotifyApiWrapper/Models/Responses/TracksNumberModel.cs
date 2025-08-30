using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApiWrapper.Models.Responses
{
    public class TracksNumberModel
    {
        [JsonProperty("href", Required = Required.Always)]
        public string Href { get; set; } = string.Empty;

        [JsonProperty("total", Required = Required.Always)]
        public int Total { get; set; }
    }
}
