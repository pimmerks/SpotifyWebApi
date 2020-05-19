namespace Spotify.WebApi.Model.Objects.Episodes
{
    using System.Text.Json.Serialization;

    public class ResumePoint
    {
        /// <summary>
        /// Whether or not the episode has been fully played by the user.
        /// </summary>
        [JsonPropertyName("fully_played")]
        public bool FullyPlayed { get; set; }

        /// <summary>
        /// The user’s most recent position in the episode in milliseconds.
        /// </summary>
        [JsonPropertyName("resume_position_ms")]
        public int ResumePositionMs { get; set; }
    }
}
