namespace Spotify.WebApi.Model.Objects
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;
    using Tracks;

    public class RecommendationsResponse
    {
        /// <summary>
        /// An array of recommendation seed objects.
        /// </summary>
        [JsonPropertyName("seeds")]
        public List<RecommendationSeed> Seeds { get; private set; }

        /// <summary>
        /// An array of track object (simplified) ordered according to the parameters supplied.
        /// </summary>
        [JsonPropertyName("tracks")]
        public List<SimpleTrack> Tracks { get; private set; }
    }
}
