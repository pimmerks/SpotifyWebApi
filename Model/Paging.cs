namespace SpotifyWebApi.Model
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// The <see cref="Paging{T}" /> class.
    /// </summary>
    /// <typeparam name="T">The type of <see cref="Paging{T}"/></typeparam>
    public class Paging<T>
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
        /// Gets or sets the offset.
        /// </summary>
        [JsonProperty("offset")]
        public int Offset { get; set; }

        /// <summary>
        /// Gets or sets the previous.
        /// </summary>
        [JsonProperty("previous")]
        public string Previous { get; set; }

        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        [JsonProperty("total")]
        public int Total { get; set; }
    }
}
