namespace SpotifyWebApi.Models
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class Copyright
    {
        /// <summary>
        ///     The copyright text for this content.
        /// </summary>
        /// <value>The copyright text for this content. </value>
        [JsonPropertyName("text")]
        public string Text { get; set; }

        /// <summary>
        ///     The type of copyright: `C` = the copyright, `P` = the sound recording (performance) copyright.
        /// </summary>
        /// <value>The type of copyright: `C` = the copyright, `P` = the sound recording (performance) copyright. </value>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
