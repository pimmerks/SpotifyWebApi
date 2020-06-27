namespace Spotify.WebApi.Model.Objects
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// A cursor.
    /// </summary>
    public class Cursor
    {
        /// <summary>
        /// The cursor to use as key to find the next page of items.
        /// </summary>
        [JsonPropertyName("after")]
        public string After { get; set; }
    }
}
