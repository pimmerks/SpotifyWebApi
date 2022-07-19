namespace SpotifyWebApi.NewModels
{
    using Newtonsoft.Json;

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
        [JsonProperty(PropertyName = "status")]
        public int? Status { get; set; }

        /// <summary>
        ///     A short description of the cause of the error.
        /// </summary>
        /// <value>A short description of the cause of the error. </value>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }
    }
}
