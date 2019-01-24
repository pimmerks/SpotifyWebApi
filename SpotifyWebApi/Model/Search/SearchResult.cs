namespace Spotify.Model.Search
{
    using System.Collections.Generic;

    /// <summary>
    /// A search result of a search query.
    /// </summary>
    public class SearchResult
    {
        /// <summary>
        /// The albums.
        /// </summary>
        public List<SimpleAlbum> Albums { get; set; }

        /// <summary>
        /// The artists.
        /// </summary>
        public List<FullArtist> Artists { get; set; }

        /// <summary>
        /// The tracks.
        /// </summary>
        public List<FullTrack> Tracks { get; set; }

        /// <summary>
        /// The playlists.
        /// </summary>
        public List<SimplePlaylist> Playlists { get; set; }
    }
}