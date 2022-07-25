namespace SpotifyWebApi.Models
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class Category
    {
        /// <summary>
        ///     A link to the Web API endpoint returning full details of the category.
        /// </summary>
        /// <value>A link to the Web API endpoint returning full details of the category. </value>
        [JsonPropertyName("href")]
        public string Href { get; set; }

        /// <summary>
        ///     The category icon, in various sizes.
        /// </summary>
        /// <value>The category icon, in various sizes. </value>
        [JsonPropertyName("icons")]
        public List<Image> Icons { get; set; }

        /// <summary>
        ///     The [Spotify category ID](/documentation/web-api/#spotify-uris-and-ids) of the category.
        /// </summary>
        /// <value>The [Spotify category ID](/documentation/web-api/#spotify-uris-and-ids) of the category. </value>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     The name of the category.
        /// </summary>
        /// <value>The name of the category. </value>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
