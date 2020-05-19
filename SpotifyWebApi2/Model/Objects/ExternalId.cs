namespace Spotify.WebApi.Model.Objects
{
    using System.Text.Json.Serialization;

    public class ExternalId
    {
        /// <summary>
        /// International Article Number
        /// </summary>
        [JsonPropertyName("ean")]
        public string Ean { get; private set; }

        /// <summary>
        /// International Standard Recording Code
        /// </summary>
        [JsonPropertyName("isrc")]
        public string Isrc { get; private set; }

        /// <summary>
        /// Universal Product Code
        /// </summary>
        [JsonPropertyName("upc")]
        public string Upc { get; private set; }
    }
}
