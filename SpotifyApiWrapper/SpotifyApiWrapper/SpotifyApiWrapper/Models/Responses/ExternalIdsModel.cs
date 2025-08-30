using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApiWrapper.Models.Responses
{
    public class ExternalIdsModel
    {
        [JsonProperty("isrc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Isrc { get; set; } = string.Empty;

        [JsonProperty("ean", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Ean { get; set; } = string.Empty;

        [JsonProperty("upc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string Upc { get; set; } = string.Empty;
    }
}
