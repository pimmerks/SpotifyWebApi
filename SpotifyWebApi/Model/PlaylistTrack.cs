using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyWebApi.Model
{
    public class PlaylistTrack
    {
        [JsonProperty("added_at")]
        public DateTime AddedAt { get; set; }

        //[JsonProperty("added_by")]
        //TODO:

        [JsonProperty("is_local")]
        public Boolean IsLocal { get; set; }

        [JsonProperty("track")]
        public FullTrack Track { get; set; }
    }
}
