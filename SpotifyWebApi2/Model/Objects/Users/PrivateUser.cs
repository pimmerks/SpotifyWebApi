namespace Spotify.WebApi.Model.Objects.Users
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Albums;

    public class PrivateUser
    {
        /// <summary>
        /// The country of the user, as set in the user’s account profile. An ISO 3166-1 alpha-2 country code. This field is only available when the current user has granted access to the user-read-private scope.
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; private set; }

        /// <summary>
        /// The name displayed on the user’s profile. null if not available.
        /// </summary>
        [JsonPropertyName("display_name")]
        public string DisplayName { get; private set; }

        /// <summary>
        /// The user’s email address, as entered by the user when creating their account. Important! This email address is unverified; there is no proof that it actually belongs to the user. This field is only available when the current user has granted access to the user-read-email scope.
        /// </summary>
        [JsonPropertyName("email")]
        public string Email { get; private set; }

        /// <summary>
        /// Known external URLs for this user.
        /// </summary>
        [JsonPropertyName("external_urls")]
        public ExternalUrl ExternalUrls { get; private set; }

        /// <summary>
        /// Information about the followers of the user.
        /// </summary>
        [JsonPropertyName("followers")]
        public Followers Followers { get; private set; }

        /// <summary>
        /// A link to the Web API endpoint for this user.
        /// </summary>
        [JsonPropertyName("href")]
        public string Href { get; private set; }

        /// <summary>
        /// The Spotify user ID for the user.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; private set; }

        /// <summary>
        /// The user’s profile image.
        /// </summary>
        [JsonPropertyName("images")]
        public List<Image> Images { get; private set; }

        /// <summary>
        /// The user’s Spotify subscription level: “premium”, “free”, etc. (The subscription level “open” can be considered the same as “free”.) This field is only available when the current user has granted access to the user-read-private scope.
        /// </summary>
        [JsonPropertyName("product")]
        public string Product { get; private set; }

        /// <summary>
        /// The object type: “user”
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; private set; }

        /// <summary>
        /// The Spotify URI for the user.
        /// </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; private set; }
    }
}
