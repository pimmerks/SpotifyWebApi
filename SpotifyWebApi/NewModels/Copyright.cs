namespace SpotifyWebApi.NewModels
{
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class Copyright
    {
        /// <summary>
        ///     The copyright text for this content.
        /// </summary>
        /// <value>The copyright text for this content. </value>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

        /// <summary>
        ///     The type of copyright: `C` = the copyright, `P` = the sound recording (performance) copyright.
        /// </summary>
        /// <value>The type of copyright: `C` = the copyright, `P` = the sound recording (performance) copyright. </value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }
    }
}
