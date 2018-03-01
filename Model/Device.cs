namespace SpotifyWebApi.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    /// <summary>
    /// The <see cref="Device"/>.
    /// </summary>
    public class Device
    {
        /// <summary>
        /// Gets or sets the device ID. This may be null.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets a value indicating if this device is the currently active device.
        /// </summary>
        [JsonProperty("is_active")]
        public bool IsActive { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether controlling this device is restricted.
        /// At present if this is "true" then no Web API commands will be accepted by this device.
        /// </summary>
        [JsonProperty("is_restricted")]
        public bool IsRestricted { get; set; }

        /// <summary>
        /// Gets or sets the name of the device.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets device type, such as "Computer", "Smartphone" or "Speaker".
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the current volume in percent. This may be null.
        /// </summary>
        [JsonProperty("volume_percent")]
        public int? VolumePercent { get; set; }
    }
}
