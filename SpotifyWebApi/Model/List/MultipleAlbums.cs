namespace SpotifyWebApi.Model.List
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// The <see cref="MultipleAlbums" />.
    /// </summary>
    public class MultipleAlbums
    {
        /// <summary>
        /// Gets or sets the albums.
        /// </summary>
        [JsonProperty("albums")]
        public IList<FullAlbum> Albums { get; set; }
    }
}
