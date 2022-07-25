namespace SpotifyWebApi.Models
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class Cursor
    {
        /// <summary>
        ///     The cursor to use as key to find the next page of items.
        /// </summary>
        /// <value>The cursor to use as key to find the next page of items.</value>
        [JsonPropertyName("after")]
        public string After { get; set; }
    }
}
