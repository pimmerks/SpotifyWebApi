namespace Spotify.WebApi.Model.Objects
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Spotify.WebApi.Model.Objects.Tracks;

    /// <summary>
    /// Recommendations response.
    /// </summary>
    public class RecommendationsResponse
    {
        /// <summary>
        /// An array of recommendation seed objects.
        /// </summary>
        [JsonPropertyName("seeds")]
        public List<RecommendationSeed> Seeds { get; set; }

        /// <summary>
        /// An array of track object (simplified) ordered according to the parameters supplied.
        /// </summary>
        [JsonPropertyName("tracks")]
        public List<SimpleTrack> Tracks { get; set; }
    }
}
