namespace SpotifyWebApi.NewModels
{
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class Cursor
    {
        /// <summary>
        ///     The cursor to use as key to find the next page of items.
        /// </summary>
        /// <value>The cursor to use as key to find the next page of items.</value>
        [JsonProperty(PropertyName = "after")]
        public string After { get; set; }
    }
}
