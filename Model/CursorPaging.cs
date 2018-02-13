namespace SpotifyWebApi.Model
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// The <see cref="CursorPaging{T}" /> class.
    /// </summary>
    /// <typeparam name="T">The type of <see cref="CursorPaging{T}"/></typeparam>
    public class CursorPaging<T>
    {
        /// <summary>
        /// Gets or sets the href.
        /// </summary>
        [JsonProperty("href")]
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        [JsonProperty("items")]
        public List<T> Items { get; set; }

        /// <summary>
        /// Gets or sets the limit.
        /// </summary>
        [JsonProperty("limit")]
        public int Limit { get; set; }

        /// <summary>
        /// Gets or sets the next.
        /// </summary>
        [JsonProperty("next")]
        public string Next { get; set; }

        /// <summary>
        /// Gets or sets the cursors.
        /// </summary>
        [JsonProperty("cursors")]
        public Cursor Cursors { get; set; }

        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
