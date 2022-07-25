namespace SpotifyWebApi.Models
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class Show : ShowBase
    {
        /// <summary>
        ///     The episodes of the show.
        /// </summary>
        /// <value>The episodes of the show. </value>
        [JsonPropertyName("episodes")]
        public List<Episode> Episodes { get; set; }
    }
}
