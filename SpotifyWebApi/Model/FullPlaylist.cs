using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyWebApi.Model
{
    public class FullPlaylist
    {
        [JsonProperty("collaborative")]
        public bool Collaborative { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
        
        [JsonProperty("external_urls")]
        public Dictionary<string, string> ExternalUrls { get; set; }

        [JsonProperty("followers")]
        public Followers Followers { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("images")]
        public List<Image> Images { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("owner")]
        public PublicUser Owner { get; set; }

        [JsonProperty("public")]
        public bool Public { get; set; }

        [JsonProperty("snapshot_id")]
        public string SnapshotId { get; set; }

        [JsonProperty("tracks")]
        public Paging<PlaylistTrack> Tracks { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("uri")]
        public string Uri { get; set; }

        public List<PlaylistTrack> TrackList { get; set; }
    }
}
