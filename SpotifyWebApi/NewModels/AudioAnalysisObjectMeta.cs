namespace SpotifyWebApi.NewModels
{
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class AudioAnalysisMeta
    {
        /// <summary>
        ///     The version of the Analyzer used to analyze this track.
        /// </summary>
        /// <value>The version of the Analyzer used to analyze this track.</value>
        [JsonProperty(PropertyName = "analyzer_version")]
        public string AnalyzerVersion { get; set; }

        /// <summary>
        ///     The platform used to read the track's audio data.
        /// </summary>
        /// <value>The platform used to read the track's audio data.</value>
        [JsonProperty(PropertyName = "platform")]
        public string Platform { get; set; }

        /// <summary>
        ///     A detailed status code for this track. If analysis data is missing, this code may explain why.
        /// </summary>
        /// <value>A detailed status code for this track. If analysis data is missing, this code may explain why.</value>
        [JsonProperty(PropertyName = "detailed_status")]
        public string DetailedStatus { get; set; }

        /// <summary>
        ///     The return code of the analyzer process. 0 if successful, 1 if any errors occurred.
        /// </summary>
        /// <value>The return code of the analyzer process. 0 if successful, 1 if any errors occurred.</value>
        [JsonProperty(PropertyName = "status_code")]
        public int? StatusCode { get; set; }

        /// <summary>
        ///     The Unix timestamp (in seconds) at which this track was analyzed.
        /// </summary>
        /// <value>The Unix timestamp (in seconds) at which this track was analyzed.</value>
        [JsonProperty(PropertyName = "timestamp")]
        public int? Timestamp { get; set; }

        /// <summary>
        ///     The amount of time taken to analyze this track.
        /// </summary>
        /// <value>The amount of time taken to analyze this track.</value>
        [JsonProperty(PropertyName = "analysis_time")]
        public decimal? AnalysisTime { get; set; }

        /// <summary>
        ///     The method used to read the track's audio data.
        /// </summary>
        /// <value>The method used to read the track's audio data.</value>
        [JsonProperty(PropertyName = "input_process")]
        public string InputProcess { get; set; }
    }
}
