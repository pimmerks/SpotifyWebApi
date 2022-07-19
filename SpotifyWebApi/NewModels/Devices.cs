namespace SpotifyWebApi.NewModels
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class DevicesObject
    {
        /// <summary>
        ///     A list of 0..n Device objects
        /// </summary>
        /// <value>A list of 0..n Device objects</value>
        [JsonProperty(PropertyName = "devices")]
        public List<Device> Devices { get; set; }
    }
}
