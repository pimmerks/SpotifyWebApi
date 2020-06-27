namespace Spotify.WebApi.Model.Objects
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// External ids.
    /// </summary>
    public class ExternalId
    {
        /// <summary>
        /// International Article Number
        /// </summary>
        [JsonPropertyName("ean")]
        public string Ean { get; set; }

        /// <summary>
        /// International Standard Recording Code
        /// </summary>
        [JsonPropertyName("isrc")]
        public string Isrc { get; set; }

        /// <summary>
        /// Universal Product Code
        /// </summary>
        [JsonPropertyName("upc")]
        public string Upc { get; set; }
    }
}
