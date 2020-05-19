namespace Spotify.WebApi.Model.Objects.Users
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Albums;

    public class PublicUser
    {
        /// <summary>
        /// The name displayed on the user’s profile. null if not available.
        /// </summary>
        [JsonPropertyName("display_name")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// Known public external URLs for this user.
        /// </summary>
        [JsonPropertyName("external_urls")]
        public ExternalUrl ExternalUrls { get; private set; }

        /// <summary>
        /// Information about the followers of this user.
        /// </summary>
        [JsonPropertyName("followers")]
        public Followers Followers { get; private set; }

        /// <summary>
        /// A link to the Web API endpoint for this user.
        /// </summary>
        [JsonPropertyName("href")]
        public string Href { get; private set; }

        /// <summary>
        /// The Spotify user ID for this user.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; private set; }

        /// <summary>
        /// The user’s profile image.
        /// </summary>
        [JsonPropertyName("images")]
        public List<Image> Images { get; private set; }

        /// <summary>
        /// The object type: “user”
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; private set; }

        /// <summary>
        /// The Spotify URI for this user.
        /// </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; private set; }
    }
}
