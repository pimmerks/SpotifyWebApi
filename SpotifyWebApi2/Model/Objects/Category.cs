namespace Spotify.WebApi.Model.Objects
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    public class Category
    {
        /// <summary>
        /// A link to the Web API endpoint returning full details of the category.
        /// </summary>
        [JsonPropertyName("href")]
        public string Href { get; private set; }

        /// <summary>
        /// The category icon, in various sizes.
        /// </summary>
        [JsonPropertyName("icons")]
        public List<Image> Icons { get; private set; }

        /// <summary>
        /// The Spotify category ID of the category.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; private set; }

        /// <summary>
        /// The name of the category.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; private set; }
    }
}
