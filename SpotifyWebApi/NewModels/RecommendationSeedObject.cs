namespace SpotifyWebApi.NewModels
{
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class RecommendationSeed
    {
        /// <summary>
        ///     The number of tracks available after min\\_\\* and max\\_\\* filters have been applied.
        /// </summary>
        /// <value>The number of tracks available after min\\_\\* and max\\_\\* filters have been applied. </value>
        [JsonProperty(PropertyName = "afterFilteringSize")]
        public int? AfterFilteringSize { get; set; }

        /// <summary>
        ///     The number of tracks available after relinking for regional availability.
        /// </summary>
        /// <value>The number of tracks available after relinking for regional availability. </value>
        [JsonProperty(PropertyName = "afterRelinkingSize")]
        public int? AfterRelinkingSize { get; set; }

        /// <summary>
        ///     A link to the full track or artist data for this seed. For tracks this will be a link to a [Track
        ///     Object](/documentation/web-api/reference/#object-trackobject). For artists a link to [an Artist
        ///     Object](/documentation/web-api/reference/#object-artistobject). For genre seeds, this value will be `null`.
        /// </summary>
        /// <value>
        ///     A link to the full track or artist data for this seed. For tracks this will be a link to a [Track
        ///     Object](/documentation/web-api/reference/#object-trackobject). For artists a link to [an Artist
        ///     Object](/documentation/web-api/reference/#object-artistobject). For genre seeds, this value will be `null`.
        /// </value>
        [JsonProperty(PropertyName = "href")]
        public string Href { get; set; }

        /// <summary>
        ///     The id used to select this seed. This will be the same as the string used in the `seed_artists`, `seed_tracks` or
        ///     `seed_genres` parameter.
        /// </summary>
        /// <value>
        ///     The id used to select this seed. This will be the same as the string used in the `seed_artists`, `seed_tracks`
        ///     or `seed_genres` parameter.
        /// </value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        ///     The number of recommended tracks available for this seed.
        /// </summary>
        /// <value>The number of recommended tracks available for this seed. </value>
        [JsonProperty(PropertyName = "initialPoolSize")]
        public int? InitialPoolSize { get; set; }

        /// <summary>
        ///     The entity type of this seed. One of `artist`, `track` or `genre`.
        /// </summary>
        /// <value>The entity type of this seed. One of `artist`, `track` or `genre`. </value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
}
