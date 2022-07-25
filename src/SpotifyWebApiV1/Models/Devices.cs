namespace SpotifyWebApi.Models
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class DevicesObject
    {
        /// <summary>
        ///     A list of 0..n Device objects
        /// </summary>
        /// <value>A list of 0..n Device objects</value>
        [JsonPropertyName("devices")]
        public List<Device> Devices { get; set; }
    }
}
