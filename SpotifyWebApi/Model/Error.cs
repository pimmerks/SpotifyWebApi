namespace Spotify.Model
{
    using Newtonsoft.Json;

    /// <summary>
    /// The <see cref="Error" /> class.
    /// </summary>
    public class Error
    {
        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        [JsonProperty("status")]
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; }
    }
}
