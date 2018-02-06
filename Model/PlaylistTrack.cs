using Newtonsoft.Json;
using System;

namespace SpotifyWebApi.Model
{
    public class PlaylistTrack
    {
        [JsonProperty("added_at")]
        public DateTime AddedAt { get; set; }

        //[JsonProperty("added_by")]
        //TODO:

        [JsonProperty("is_local")]
        public bool IsLocal { get; set; }

        [JsonProperty("track")]
        public FullTrack Track { get; set; }
    }
}
