using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SpotifyApiWrapper.Models.Responses
{
    public class LinkedFromModel
    {
        [JsonProperty("external_urls", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public List<ExternalUrlModel> ExternalUrls { get; set; } = new List<ExternalUrlModel>();
    }
}
