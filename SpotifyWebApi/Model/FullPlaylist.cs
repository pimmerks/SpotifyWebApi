namespace SpotifyWebApi.Model
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Uri;

    /// <summary>
    /// The <see cref="FullPlaylist" /> class.
    /// </summary>
    public class FullPlaylist
    {
        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="FullPlaylist"/> is collaborative.
        /// </summary>
        [JsonProperty("collaborative")]
        public bool Collaborative { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the external urls.
        /// </summary>
        [JsonProperty("external_urls")]
        public Dictionary<string, string> ExternalUrls { get; set; }

        /// <summary>
        /// Gets or sets the followers.
        /// </summary>
        [JsonProperty("followers")]
        public Followers Followers { get; set; }

        /// <summary>
        /// Gets or sets the href.
        /// </summary>
        [JsonProperty("href")]
        public string Href { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        [JsonProperty("images")]
        public List<Image> Images { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the owner.
        /// </summary>
        [JsonProperty("owner")]
        public PublicUser Owner { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="FullPlaylist"/> is public.
        /// </summary>
        [JsonProperty("public")]
        public bool? Public { get; set; }

        /// <summary>
        /// Gets or sets the snapshot identifier.
        /// </summary>
        [JsonProperty("snapshot_id")]
        public string SnapshotId { get; set; }

        /// <summary>
        /// Gets or sets the tracks.
        /// </summary>
        [JsonProperty("tracks")]
        public Paging<PlaylistTrack> Tracks { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the URI.
        /// </summary>
        [JsonProperty("uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets or sets the track list.
        /// </summary>
        public List<PlaylistTrack> TrackList { get; set; }

        /// <summary>
        /// Gets the <see cref="Model.Uri.SpotifyUri"/> of this object.
        /// </summary>
        public SpotifyUri SpotifyUri => SpotifyUri.Make(this.Uri);
    }
}
