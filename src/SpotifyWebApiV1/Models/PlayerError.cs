namespace SpotifyWebApi.Models
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class PlayerError
    {
        /// <summary>
        ///     The HTTP status code. Either `404 NOT FOUND` or `403 FORBIDDEN`.  Also returned in the response header.
        /// </summary>
        /// <value>The HTTP status code. Either `404 NOT FOUND` or `403 FORBIDDEN`.  Also returned in the response header. </value>
        [JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        ///     A short description of the cause of the error.
        /// </summary>
        /// <value>A short description of the cause of the error. </value>
        [JsonPropertyName("message")]
        public string Message { get; set; }

        /// <summary>
        ///     Gets or Sets Reason
        /// </summary>
        [JsonPropertyName("reason")]
        public PlayerErrorReasons Reason { get; set; }
    }
}
