namespace SpotifyWebApi.Models
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class ExternalId
    {
        /// <summary>
        ///     [International Standard Recording Code](http://en.wikipedia.org/wiki/International_Standard_Recording_Code)
        /// </summary>
        /// <value>[International Standard Recording Code](http://en.wikipedia.org/wiki/International_Standard_Recording_Code) </value>
        [JsonPropertyName("isrc")]
        public string Isrc { get; set; }

        /// <summary>
        ///     [International Article Number](http://en.wikipedia.org/wiki/International_Article_Number_%28EAN%29)
        /// </summary>
        /// <value>[International Article Number](http://en.wikipedia.org/wiki/International_Article_Number_%28EAN%29) </value>
        [JsonPropertyName("ean")]
        public string Ean { get; set; }

        /// <summary>
        ///     [Universal Product Code](http://en.wikipedia.org/wiki/Universal_Product_Code)
        /// </summary>
        /// <value>[Universal Product Code](http://en.wikipedia.org/wiki/Universal_Product_Code) </value>
        [JsonPropertyName("upc")]
        public string Upc { get; set; }
    }
}
