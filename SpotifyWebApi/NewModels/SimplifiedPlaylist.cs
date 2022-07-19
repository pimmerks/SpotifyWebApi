namespace SpotifyWebApi.NewModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class SimplifiedPlaylist
    {
        /// <summary>
        ///     `true` if the owner allows other users to modify the playlist.
        /// </summary>
        /// <value>`true` if the owner allows other users to modify the playlist. </value>
        [JsonProperty(PropertyName = "collaborative")]
        public bool? Collaborative { get; set; }

        /// <summary>
        ///     The playlist description. _Only returned for modified, verified playlists, otherwise_ `null`.
        /// </summary>
        /// <value>The playlist description. _Only returned for modified, verified playlists, otherwise_ `null`. </value>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        ///     Known external URLs for this playlist.
        /// </summary>
        /// <value>Known external URLs for this playlist. </value>
        [JsonProperty(PropertyName = "external_urls")]
        public ExternalUrl ExternalUrls { get; set; }

        /// <summary>
        ///     A link to the Web API endpoint providing full details of the playlist.
        /// </summary>
        /// <value>A link to the Web API endpoint providing full details of the playlist. </value>
        [JsonProperty(PropertyName = "href")]
        public string Href { get; set; }

        /// <summary>
        ///     The [Spotify ID](/documentation/web-api/#spotify-uris-and-ids) for the playlist.
        /// </summary>
        /// <value>The [Spotify ID](/documentation/web-api/#spotify-uris-and-ids) for the playlist. </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        ///     Images for the playlist. The array may be empty or contain up to three images. The images are returned by size in
        ///     descending order. See [Working with Playlists](/documentation/general/guides/working-with-playlists/). _**Note**:
        ///     If returned, the source URL for the image (`url`) is temporary and will expire in less than a day._
        /// </summary>
        /// <value>
        ///     Images for the playlist. The array may be empty or contain up to three images. The images are returned by size
        ///     in descending order. See [Working with Playlists](/documentation/general/guides/working-with-playlists/).
        ///     _**Note**: If returned, the source URL for the image (`url`) is temporary and will expire in less than a day._
        /// </value>
        [JsonProperty(PropertyName = "images")]
        public List<Image> Images { get; set; }

        /// <summary>
        ///     The name of the playlist.
        /// </summary>
        /// <value>The name of the playlist. </value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        ///     The user who owns the playlist
        /// </summary>
        /// <value>The user who owns the playlist </value>
        [JsonProperty(PropertyName = "owner")]
        public PlaylistOwner Owner { get; set; }

        /// <summary>
        ///     The playlist's public/private status: `true` the playlist is public, `false` the playlist is private, `null` the
        ///     playlist status is not relevant. For more about public/private status, see [Working with
        ///     Playlists](/documentation/general/guides/working-with-playlists/)
        /// </summary>
        /// <value>
        ///     The playlist's public/private status: `true` the playlist is public, `false` the playlist is private, `null` the
        ///     playlist status is not relevant. For more about public/private status, see [Working with
        ///     Playlists](/documentation/general/guides/working-with-playlists/)
        /// </value>
        [JsonProperty(PropertyName = "public")]
        public bool? _Public { get; set; }

        /// <summary>
        ///     The version identifier for the current playlist. Can be supplied in other requests to target a specific playlist
        ///     version
        /// </summary>
        /// <value>
        ///     The version identifier for the current playlist. Can be supplied in other requests to target a specific playlist
        ///     version
        /// </value>
        [JsonProperty(PropertyName = "snapshot_id")]
        public string SnapshotId { get; set; }

        /// <summary>
        ///     A collection containing a link ( `href` ) to the Web API endpoint where full details of the playlist's tracks can
        ///     be retrieved, along with the `total` number of tracks in the playlist. Note, a track object may be `null`. This can
        ///     happen if a track is no longer available.
        /// </summary>
        /// <value>
        ///     A collection containing a link ( `href` ) to the Web API endpoint where full details of the playlist's tracks
        ///     can be retrieved, along with the `total` number of tracks in the playlist. Note, a track object may be `null`. This
        ///     can happen if a track is no longer available.
        /// </value>
        [JsonProperty(PropertyName = "tracks")]
        public PlaylistTracksRef Tracks { get; set; }

        /// <summary>
        ///     The object type: \"playlist\"
        /// </summary>
        /// <value>The object type: \"playlist\" </value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        ///     The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for the playlist.
        /// </summary>
        /// <value>The [Spotify URI](/documentation/web-api/#spotify-uris-and-ids) for the playlist. </value>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }
    }
}
