namespace Spotify.WebApi.Model.Objects.Playlists
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Albums;
    using Tracks;
    using Users;

    public class Playlist
    {
        /// <summary>
        /// true if the owner allows other users to modify the playlist.
        /// </summary>
        [JsonPropertyName("collaborative")]
        public bool Collaborative { get; private set; }

        /// <summary>
        /// Known external URLs for this playlist.
        /// </summary>
        [JsonPropertyName("external_urls")]
        public ExternalUrl ExternalUrls { get; private set; }

        /// <summary>
        /// A link to the Web API endpoint providing full details of the playlist.
        /// </summary>
        [JsonPropertyName("href")]
        public string Href { get; private set; }

        /// <summary>
        /// The Spotify ID for the playlist.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; private set; }

        /// <summary>
        /// Images for the playlist. The array may be empty or contain up to three images. The images are returned by size in descending order. See Working with Playlists. Note: If returned, the source URL for the image (url) is temporary and will expire in less than a day.
        /// </summary>
        [JsonPropertyName("images")]
        public List<Image> Images { get; private set; }

        /// <summary>
        /// The name of the playlist.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        /// <summary>
        /// The user who owns the playlist
        /// </summary>
        [JsonPropertyName("owner")]
        public PublicUser Owner { get; private set; }

        /// <summary>
        /// The playlist’s public/private status: true the playlist is public, false the playlist is private, null the playlist status is not relevant. For more about public/private status, see Working with Playlists
        /// </summary>
        [JsonPropertyName("public")]
        public bool Public { get; private set; }

        /// <summary>
        /// The version identifier for the current playlist. Can be supplied in other requests to target a specific playlist version
        /// </summary>
        [JsonPropertyName("snapshot_id")]
        public string SnapshotId { get; private set; }

        /// <summary>
        /// A collection containing a link (href) to the Web API endpoint where full details of the playlist’s tracks can be retrieved, along with the total number of items in the playlist.
        /// </summary>
        [JsonPropertyName("tracks")]
        public List<PlaylistTrack> Tracks { get; private set; }

        /// <summary>
        /// The object type: “playlist”
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; private set; }

        /// <summary>
        /// The Spotify URI for the playlist.
        /// </summary>
        [JsonPropertyName("uri")]
        public string Uri { get; private set; }
    }
}
