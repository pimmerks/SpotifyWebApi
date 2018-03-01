namespace SpotifyWebApi.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Enum;
    using Newtonsoft.Json;

    /// <summary>
    /// The <see cref="Context" />.
    /// </summary>
    public class Context
    {
        /// <summary>
        /// Gets or sets the uri of the context.
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets the href of the context, or null if not available.
        /// </summary>
        [JsonProperty("href")]
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets the external urls of the context, or null if not available.
        /// </summary>
        [JsonProperty("external_urls")]
        public Dictionary<string, string> ExternalUrls { get; set; }

        /// <summary>
        /// Gets or sets the object type of the item's context. Can be one of "album", "artist" or "playlist".
        /// </summary>
        [JsonProperty("type")]
        public ContextType Type { get; set; }
    }
}
