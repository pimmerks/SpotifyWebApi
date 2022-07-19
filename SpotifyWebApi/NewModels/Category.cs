namespace SpotifyWebApi.NewModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class Category
    {
        /// <summary>
        ///     A link to the Web API endpoint returning full details of the category.
        /// </summary>
        /// <value>A link to the Web API endpoint returning full details of the category. </value>
        [JsonProperty(PropertyName = "href")]
        public string Href { get; set; }

        /// <summary>
        ///     The category icon, in various sizes.
        /// </summary>
        /// <value>The category icon, in various sizes. </value>
        [JsonProperty(PropertyName = "icons")]
        public List<Image> Icons { get; set; }

        /// <summary>
        ///     The [Spotify category ID](/documentation/web-api/#spotify-uris-and-ids) of the category.
        /// </summary>
        /// <value>The [Spotify category ID](/documentation/web-api/#spotify-uris-and-ids) of the category. </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        ///     The name of the category.
        /// </summary>
        /// <value>The name of the category. </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
