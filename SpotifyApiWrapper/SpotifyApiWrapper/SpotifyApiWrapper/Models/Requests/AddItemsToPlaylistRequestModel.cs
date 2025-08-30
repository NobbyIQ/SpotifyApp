using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApiWrapper.Models.Requests
{
    public class AddItemsToPlaylistRequestModel
    {
        [JsonProperty("uris", Required = Required.Always)]
        public string[] Uris { get; set; }

        [JsonProperty("position", Required = Required.Always)]
        public int Position { get; set; }
    }
}
