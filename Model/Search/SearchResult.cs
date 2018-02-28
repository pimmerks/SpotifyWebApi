namespace SpotifyWebApi.Model.Search
{
    using System;
    using Newtonsoft.Json;

    /// <summary>
    /// The <see cref="SearchResult"/>.
    /// </summary>
    public class SearchResult
    {
        /// <summary>
        /// The albums.
        /// </summary>
        [JsonProperty("albums", NullValueHandling = NullValueHandling.Ignore)]
        public Paging<SimpleAlbum> Albums { get; set; }

        /// <summary>
        /// The artists.
        /// </summary>
        [JsonProperty("artists", NullValueHandling = NullValueHandling.Ignore)]
        public Paging<FullArtist> Artists { get; set; }

        /// <summary>
        /// The tracks.
        /// </summary>
        [JsonProperty("tracks", NullValueHandling = NullValueHandling.Ignore)]
        public Paging<FullTrack> Tracks { get; set; }

        /// <summary>
        /// The playlists.
        /// </summary>
        [JsonProperty("playlists", NullValueHandling = NullValueHandling.Ignore)]
        public Paging<SimplePlaylist> Playlists { get; set; }
    }
}
