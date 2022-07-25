namespace SpotifyWebApi.Models
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class CursorPaging
    {
        /// <summary>
        ///     A link to the Web API endpoint returning the full result of the request.
        /// </summary>
        /// <value>A link to the Web API endpoint returning the full result of the request.</value>
        [JsonPropertyName("href")]
        public string Href { get; set; }

        /// <summary>
        ///     The requested data.
        /// </summary>
        /// <value>The requested data.</value>
        [JsonPropertyName("items")]
        public List<object> Items { get; set; }

        /// <summary>
        ///     The maximum number of items in the response (as set in the query or by default).
        /// </summary>
        /// <value>The maximum number of items in the response (as set in the query or by default).</value>
        [JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        ///     URL to the next page of items. ( `null` if none)
        /// </summary>
        /// <value>URL to the next page of items. ( `null` if none)</value>
        [JsonPropertyName("next")]
        public string Next { get; set; }

        /// <summary>
        ///     The cursors used to find the next set of items.
        /// </summary>
        /// <value>The cursors used to find the next set of items.</value>
        [JsonPropertyName("cursors")]
        public Cursor Cursors { get; set; }

        /// <summary>
        ///     The total number of items available to return.
        /// </summary>
        /// <value>The total number of items available to return.</value>
        [JsonPropertyName("total")]
        public int? Total { get; set; }
    }
}
