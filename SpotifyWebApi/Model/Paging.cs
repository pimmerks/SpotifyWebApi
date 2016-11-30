using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyWebApi.Model
{
    public class Paging<T>
    {
        [JsonProperty("href")]
        public String Href { get; set; }

        [JsonProperty("items")]
        public List<T> Items { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("next")]
        public String Next { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("previous")]
        public String Previous { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
