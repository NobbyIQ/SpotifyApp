using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApiWrapper.Models.Responses
{
    public class ImageModel
    {
        [JsonProperty("url", Required = Required.Always, NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; } = string.Empty;

        [JsonProperty("height", Required = Required.Always, NullValueHandling = NullValueHandling.Include)]
        public int Height { get; set; }

        [JsonProperty("width", Required = Required.Always, NullValueHandling = NullValueHandling.Include)]
        public int Width { get; set; }
    }
}
