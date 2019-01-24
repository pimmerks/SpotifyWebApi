namespace Spotify.Model.List
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// The <see cref="MultiplePlaylists" />.
    /// </summary>
    public class MultiplePlaylists
    {
        /// <summary>
        /// Gets or sets the playlists.
        /// </summary>
        [JsonProperty("playlists")]
        public IList<FullPlaylist> Playlists { get; set; }
    }
}
