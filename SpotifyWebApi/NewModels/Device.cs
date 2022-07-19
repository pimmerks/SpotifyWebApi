namespace SpotifyWebApi.NewModels
{
    using Newtonsoft.Json;

    /// <summary>
    /// </summary>
    public class Device
    {
        /// <summary>
        ///     The device ID.
        /// </summary>
        /// <value>The device ID.</value>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        ///     If this device is the currently active device.
        /// </summary>
        /// <value>If this device is the currently active device.</value>
        [JsonProperty(PropertyName = "is_active")]
        public bool? IsActive { get; set; }

        /// <summary>
        ///     If this device is currently in a private session.
        /// </summary>
        /// <value>If this device is currently in a private session.</value>
        [JsonProperty(PropertyName = "is_private_session")]
        public bool? IsPrivateSession { get; set; }

        /// <summary>
        ///     Whether controlling this device is restricted. At present if this is \"true\" then no Web API commands will be
        ///     accepted by this device.
        /// </summary>
        /// <value>
        ///     Whether controlling this device is restricted. At present if this is \"true\" then no Web API commands will be
        ///     accepted by this device.
        /// </value>
        [JsonProperty(PropertyName = "is_restricted")]
        public bool? IsRestricted { get; set; }

        /// <summary>
        ///     The name of the device.
        /// </summary>
        /// <value>The name of the device.</value>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        ///     Device type, such as \"computer\", \"smartphone\" or \"speaker\".
        /// </summary>
        /// <value>Device type, such as \"computer\", \"smartphone\" or \"speaker\".</value>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        ///     The current volume in percent.
        /// </summary>
        /// <value>The current volume in percent.</value>
        [JsonProperty(PropertyName = "volume_percent")]
        public int? VolumePercent { get; set; }
    }
}
