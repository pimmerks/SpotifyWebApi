namespace SpotifyWebApi.Models
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class PrivateUser
    {
        /// <summary>
        ///     The country of the user, as set in the user's account profile. An [ISO 3166-1 alpha-2 country
        ///     code](http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2). _This field is only available when the current user has
        ///     granted access to the [user-read-private](/documentation/general/guides/authorization-guide/#list-of-scopes)
        ///     scope._
        /// </summary>
        /// <value>
        ///     The country of the user, as set in the user's account profile. An [ISO 3166-1 alpha-2 country
        ///     code](http://en.wikipedia.org/wiki/ISO_3166-1_alpha-2). _This field is only available when the current user has
        ///     granted access to the [user-read-private](/documentation/general/guides/authorization-guide/#list-of-scopes)
        ///     scope._
        /// </value>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        ///     The name displayed on the user's profile. `null` if not available.
        /// </summary>
        /// <value>The name displayed on the user's profile. `null` if not available. </value>
        [JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        ///     The user's email address, as entered by the user when creating their account. _**Important!** This email address is
        ///     unverified; there is no proof that it actually belongs to the user._ _This field is only available when the current
        ///     user has granted access to the [user-read-email](/documentation/general/guides/authorization-guide/#list-of-scopes)
        ///     scope._
        /// </summary>
        /// <value>
        ///     The user's email address, as entered by the user when creating their account. _**Important!** This email address
        ///     is unverified; there is no proof that it actually belongs to the user._ _This field is only available when the
        ///     current user has granted access to the
        ///     [user-read-email](/documentation/general/guides/authorization-guide/#list-of-scopes) scope._
        /// </value>
        [JsonPropertyName("email")]
        public string Email { get; set; }

        /// <summary>
        ///     The user's explicit content settings. _This field is only available when the current user has granted access to the
        ///     [user-read-private](/documentation/general/guides/authorization-guide/#list-of-scopes) scope._
        /// </summary>
        /// <value>
        ///     The user's explicit content settings. _This field is only available when the current user has granted access to
        ///     the [user-read-private](/documentation/general/guides/authorization-guide/#list-of-scopes) scope._
        /// </value>
        [JsonPropertyName("explicit_content")]
        public ExplicitContentSettings ExplicitContent { get; set; }

        /// <summary>
        ///     Known external URLs for this user.
        /// </summary>
        /// <value>Known external URLs for this user.</value>
        [JsonPropertyName("external_urls")]
        public ExternalUrl ExternalUrls { get; set; }

        /// <summary>
        ///     Information about the followers of the user.
        /// </summary>
        /// <value>Information about the followers of the user.</value>
        [JsonPropertyName("followers")]
        public Followers Followers { get; set; }

        /// <summary>
        ///     A link to the Web API endpoint for this user.
        /// </summary>
        /// <value>A link to the Web API endpoint for this user. </value>
        [JsonPropertyName("href")]
        public string Href { get; set; }

        /// <summary>
        ///     The [Spotify user ID](/documentation/web-api/#spotify-uris-and-ids) for the user.
        /// </summary>
        /// <value>The [Spotify user ID](/documentation/web-api/#spotify-uris-and-ids) for the user. </value>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        ///     The user's profile image.
        /// </summary>
        /// <value>The user's profile image.</value>
        [JsonPropertyName("images")]
        public List<Image> Images { get; set; }

        /// <summary>
        ///     The user's Spotify subscription level: \"premium\", \"free\", etc. (The subscription level \"open\" can be
        ///     considered the same as \"free\".) _This field is only available when the current user has granted access to the
        ///     [user-read-private](/documentation/general/guides/authorization-guide/#list-of-scopes) scope._
        /// </summary>
        /// <value>
        ///     The user's Spotify subscription level: \"premium\", \"free\", etc. (The subscription level \"open\" can be
        ///     considered the same as \"free\".) _This field is only available when the current user has granted access to the
        ///     [user-read-private](/documentation/general/guides/authorization-guide/#list-of-scopes) scope._
        /// </value>
        [JsonPropertyName("product")]
        public string Product { get; set; }

        /// <summary>
        ///     The object type: \"user\"
        /// </summary>
        /// <value>The object type: \"user\" </value>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        ///     The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for the user.
        /// </summary>
        /// <value>The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for the user. </value>
        [JsonPropertyName("uri")]
        public string Uri { get; set; }
    }
}
