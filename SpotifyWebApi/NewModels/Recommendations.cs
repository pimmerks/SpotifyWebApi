namespace SpotifyWebApi.NewModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class Recommendations
    {
        /// <summary>
        ///     An array of [recommendation seed objects](/documentation/web-api/reference/#object-recommendationseedobject).
        /// </summary>
        /// <value>An array of [recommendation seed objects](/documentation/web-api/reference/#object-recommendationseedobject). </value>
        [JsonProperty(PropertyName = "seeds")]
        public List<RecommendationSeed> Seeds { get; set; }

        /// <summary>
        ///     An array of [track object (simplified)](/documentation/web-api/reference/#object-simplifiedtrackobject) ordered
        ///     according to the parameters supplied.
        /// </summary>
        /// <value>
        ///     An array of [track object (simplified)](/documentation/web-api/reference/#object-simplifiedtrackobject) ordered
        ///     according to the parameters supplied.
        /// </value>
        [JsonProperty(PropertyName = "tracks")]
        public List<SimplifiedTrack> Tracks { get; set; }
    }
}
