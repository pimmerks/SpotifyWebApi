namespace SpotifyWebApi.NewModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class Show : ShowBase
    {
        /// <summary>
        ///     The episodes of the show.
        /// </summary>
        /// <value>The episodes of the show. </value>
        [JsonProperty(PropertyName = "episodes")]
        public List<Episode> Episodes { get; set; }
    }
}
