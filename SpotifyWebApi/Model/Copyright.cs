using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyWebApi.Model
{
    public class Copyright
    {
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("type")]
        public string Type { get; set; }

    }
}
