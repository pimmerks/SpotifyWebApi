namespace SpotifyWebApi.Models
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class Error
    {
        /// <summary>
        ///     The HTTP status code (also returned in the response header; see [Response Status
        ///     Codes](/documentation/web-api/#response-status-codes) for more information).
        /// </summary>
        /// <value>
        ///     The HTTP status code (also returned in the response header; see [Response Status
        ///     Codes](/documentation/web-api/#response-status-codes) for more information).
        /// </value>
        [JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        ///     A short description of the cause of the error.
        /// </summary>
        /// <value>A short description of the cause of the error. </value>
        [JsonPropertyName("message")]
        public string Message { get; set; }
    }
}
