namespace SpotifyWebApi.Models
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class Recommendations
    {
        /// <summary>
        ///     An array of [recommendation seed objects](/documentation/web-api/reference/#object-recommendationseedobject).
        /// </summary>
        /// <value>An array of [recommendation seed objects](/documentation/web-api/reference/#object-recommendationseedobject). </value>
        [JsonPropertyName("seeds")]
        public List<RecommendationSeed> Seeds { get; set; }

        /// <summary>
        ///     An array of [track object (simplified)](/documentation/web-api/reference/#object-simplifiedtrackobject) ordered
        ///     according to the parameters supplied.
        /// </summary>
        /// <value>
        ///     An array of [track object (simplified)](/documentation/web-api/reference/#object-simplifiedtrackobject) ordered
        ///     according to the parameters supplied.
        /// </value>
        [JsonPropertyName("tracks")]
        public List<SimplifiedTrack> Tracks { get; set; }
    }
}
