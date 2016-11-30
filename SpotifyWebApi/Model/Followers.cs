using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyWebApi.Model
{
    public class Followers
    {
        [JsonProperty("href")]
        public String Href { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
