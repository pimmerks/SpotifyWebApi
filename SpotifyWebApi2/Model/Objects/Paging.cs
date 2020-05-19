namespace Spotify.WebApi.Model.Objects
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Paging<T>
    {
        /// <summary>
        /// A link to the Web API endpoint returning the full result of the request
        /// </summary>
        [JsonPropertyName("href")]
        public string Href { get; private set; }

        /// <summary>
        /// The requested data.
        /// </summary>
        [JsonPropertyName("items")]
        public List<T> Items { get; private set; }

        /// <summary>
        /// The maximum number of items in the response (as set in the query or by default).
        /// </summary>
        [JsonPropertyName("limit")]
        public int Limit { get; private set; }

        /// <summary>
        /// URL to the next page of items. ( null if none)
        /// </summary>
        [JsonPropertyName("next")]
        public string Next { get; private set; }

        /// <summary>
        /// The offset of the items returned (as set in the query or by default)
        /// </summary>
        [JsonPropertyName("offset")]
        public int Offset { get; private set; }

        /// <summary>
        /// URL to the previous page of items. ( null if none)
        /// </summary>
        [JsonPropertyName("previous")]
        public string Previous { get; private set; }

        /// <summary>
        /// The total number of items available to return.
        /// </summary>
        [JsonPropertyName("total")]
        public int Total { get; private set; }
    }
}
