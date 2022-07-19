namespace SpotifyWebApi.NewModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class PublicUser
    {
        /// <summary>
        ///     The name displayed on the user's profile. `null` if not available.
        /// </summary>
        /// <value>The name displayed on the user's profile. `null` if not available. </value>
        [JsonProperty(PropertyName = "display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        ///     Known public external URLs for this user.
        /// </summary>
        /// <value>Known public external URLs for this user. </value>
        [JsonProperty(PropertyName = "external_urls")]
        public ExternalUrl ExternalUrls { get; set; }

        /// <summary>
        ///     Information about the followers of this user.
        /// </summary>
        /// <value>Information about the followers of this user. </value>
        [JsonProperty(PropertyName = "followers")]
        public Followers Followers { get; set; }

        /// <summary>
        ///     A link to the Web API endpoint for this user.
        /// </summary>
        /// <value>A link to the Web API endpoint for this user. </value>
        [JsonProperty(PropertyName = "href")]
        public string Href { get; set; }

        /// <summary>
        ///     The [Spotify user ID](/documentation/web-api/#spotify-uris-and-ids) for this user.
        /// </summary>
        /// <value>The [Spotify user ID](/documentation/web-api/#spotify-uris-and-ids) for this user. </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        ///     The user's profile image.
        /// </summary>
        /// <value>The user's profile image. </value>
        [JsonProperty(PropertyName = "images")]
        public List<Image> Images { get; set; }

        /// <summary>
        ///     The object type.
        /// </summary>
        /// <value>The object type. </value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        ///     The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for this user.
        /// </summary>
        /// <value>The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for this user. </value>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }
    }
}
