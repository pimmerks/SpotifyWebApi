namespace SpotifyWebApi.NewModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class Paging
    {
        /// <summary>
        ///     A link to the Web API endpoint returning the full result of the request
        /// </summary>
        /// <value>A link to the Web API endpoint returning the full result of the request </value>
        [JsonProperty(PropertyName = "href")]
        public string Href { get; set; }

        /// <summary>
        ///     The requested content
        /// </summary>
        /// <value>The requested content </value>
        [JsonProperty(PropertyName = "items")]
        public List<object> Items { get; set; }

        /// <summary>
        ///     The maximum number of items in the response (as set in the query or by default).
        /// </summary>
        /// <value>The maximum number of items in the response (as set in the query or by default). </value>
        [JsonProperty(PropertyName = "limit")]
        public int? Limit { get; set; }

        /// <summary>
        ///     URL to the next page of items. ( `null` if none)
        /// </summary>
        /// <value>URL to the next page of items. ( `null` if none) </value>
        [JsonProperty(PropertyName = "next")]
        public string Next { get; set; }

        /// <summary>
        ///     The offset of the items returned (as set in the query or by default)
        /// </summary>
        /// <value>The offset of the items returned (as set in the query or by default) </value>
        [JsonProperty(PropertyName = "offset")]
        public int? Offset { get; set; }

        /// <summary>
        ///     URL to the previous page of items. ( `null` if none)
        /// </summary>
        /// <value>URL to the previous page of items. ( `null` if none) </value>
        [JsonProperty(PropertyName = "previous")]
        public string Previous { get; set; }

        /// <summary>
        ///     The total number of items available to return.
        /// </summary>
        /// <value>The total number of items available to return. </value>
        [JsonProperty(PropertyName = "total")]
        public int? Total { get; set; }
    }
}
