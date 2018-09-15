namespace SpotifyWebApi.Model.List
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// The <see cref="MultipleTracks" />.
    /// </summary>
    public class MultipleTracks
    {
        /// <summary>
        /// Gets or sets the tracks.
        /// </summary>
        [JsonProperty("tracks")]
        public IList<FullTrack> Tracks { get; set; }
    }
}
