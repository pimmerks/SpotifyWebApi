namespace SpotifyWebApi.Model
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    /// <summary>
    /// The device list object.
    /// </summary>
    internal class DeviceList
    {
        /// <summary>
        /// A list of devices.
        /// </summary>
        [JsonProperty("devices")]
        public List<Device> Devices { get; set; }
    }
}