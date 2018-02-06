using Newtonsoft.Json;
using System.Collections.Generic;

namespace SpotifyWebApi.Model
{
    public class CursorPaging<T>
    {
        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("items")]
        public List<T> Items { get; set; }

        [JsonProperty("limit")]
        public int Limit { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("cursors")]
        public Cursor Cursors { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
