namespace Spotify.WebApi.Model.Objects.Playback
{
    using System.Text.Json.Serialization;
    using Episodes;
    using Tracks;

    public class CurrentlyPlaying
    {
        /// <summary>
        /// A Context Object. Can be null.
        /// </summary>
        [JsonPropertyName("context")]
        public Context Context { get; set; }

        /// <summary>
        /// The object type of the currently playing item. Can be one of track, episode, ad or unknown.
        /// </summary>
        [JsonPropertyName("currently_playing_type")]
        public string CurrentlyPlayingType { get; set; }

        /// <summary>
        /// If something is currently playing, return true.
        /// </summary>
        [JsonPropertyName("is_playing")]
        public bool IsPlaying { get; set; }

        /// <summary>
        /// The currently playing track or episode. Can be null.
        /// </summary>
        [JsonPropertyName("item")]
        public PlayableBase Item { get; set; }

        /// <summary>
        /// Progress into the currently playing track or episode. Can be null.
        /// </summary>
        [JsonPropertyName("progress_ms")]
        public int ProgressMs { get; set; }

        /// <summary>
        /// Unix Millisecond Timestamp when data was fetched
        /// </summary>
        [JsonPropertyName("timestamp")]
        public int Timestamp { get; set; }
    }
}
