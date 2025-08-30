using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApiWrapper.Models.Responses
{
    public class PlaylistTrackModel
    {
        [JsonProperty("added_at", Required = Required.Always, NullValueHandling = NullValueHandling.Include)]
        public DateTime AddedAt { get; set; }

        [JsonProperty("added_by", Required = Required.Always, NullValueHandling = NullValueHandling.Include)]
        public OwnerModel AddedBy { get; set; } = new OwnerModel();

        [JsonProperty("is_local", Required = Required.Always)]
        public bool IsLocal { get; set; }

        [JsonProperty("track", Required = Required.Always, NullValueHandling = NullValueHandling.Include)]
        public TrackModel Track { get; set; } = new TrackModel();
    }
}
