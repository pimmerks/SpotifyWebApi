using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyWebApi.Model
{
    public class Cursor
    {
        [JsonProperty("after")]
        public string After { get; set; }
    }
}
