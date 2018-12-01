namespace SpotifyWebApi.Model
{
    using Newtonsoft.Json;

    /// <summary>
    /// The <see cref="ErrorResponse"/> class.
    /// </summary>
    public class ErrorResponse
    {
        /// <summary>
        /// Gets or sets the error.
        /// </summary>
        [JsonProperty("error")]
        public Error Error { get; set; }
    }
}