using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyWebApi.Model
{
    public class FullAlbum
    {
        [JsonProperty("album_type")]
        public String AlbumType { get; set; }

        [JsonProperty("artists")]
        public List<SimpleArtist> Artists { get; set; }

        [JsonProperty("available_markets")]
        public List<String> AvailableMarkets { get; set; }

        [JsonProperty("copyrights")]
        List<Copyright> Copyrights { get; set; }

        [JsonProperty("external_ids")]
        public Dictionary<string, string> ExternalIds { get; set; }

        [JsonProperty("external_url")]
        public Dictionary<string, string> ExternalUrls { get; set; }

        [JsonProperty("genres")]
        public List<String> Genres { get; set; }

        [JsonProperty("href")]
        public String Href { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("images")]
        public List<Image> Images { get; set; }

        [JsonProperty("label")]
        public String Label { get; set; }

        [JsonProperty("name")]
        public String Name { get; set; }

        [JsonProperty("popularity")]
        public int Popularity { get; set; }

        [JsonProperty("release_date")]
        public String ReleaseDate { get; set; }

        [JsonProperty("release_date_precision")]
        public String ReleaseDatePrecision { get; set; }

        [JsonProperty("tracks")]
        public Paging<SimpleTrack> Tracks { get; set; }

        [JsonProperty("type")]
        public String Type { get; set; }

        [JsonProperty("uri")]
        public String Uri { get; set; }
    }
}
