namespace Spotify.Model.List
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// The <see cref="MultipleArtists" />.
    /// </summary>
    public class MultipleArtists
    {
        /// <summary>
        /// Gets or sets the artists.
        /// </summary>
        [JsonProperty("artists")]
        public IList<FullArtist> Artists { get; set; }
    }
}
