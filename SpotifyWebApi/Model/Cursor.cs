namespace Spotify.Model
{
    using Newtonsoft.Json;

    /// <summary>
    /// The <see cref="Cursor" />.
    /// </summary>
    public class Cursor
    {
        /// <summary>
        /// Gets or sets the after.
        /// </summary>
        [JsonProperty("after")]
        public string After { get; set; }
    }
}
