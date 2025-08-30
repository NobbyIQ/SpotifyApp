using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApiWrapper.Models.Responses
{
    public class RestrictionsModel
    {
        [JsonProperty("reason", Required = Required.Always)]
        public string Reason { get; set; } = string.Empty;
    }
}
