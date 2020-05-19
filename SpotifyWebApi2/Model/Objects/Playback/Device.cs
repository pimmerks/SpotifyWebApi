namespace Spotify.WebApi.Model.Objects.Playback
{
    using System.Text.Json.Serialization;

    public class Device
    {
        /// <summary>
        /// The device ID. This may be null.
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; private set; }

        /// <summary>
        /// If this device is the currently active device.
        /// </summary>
        [JsonPropertyName("is_active")]
        public bool IsActive { get; private set; }

        /// <summary>
        /// If this device is currently in a private session.
        /// </summary>
        [JsonPropertyName("is_private_session")]
        public bool IsPrivateSession { get; private set; }

        /// <summary>
        /// Whether controlling this device is restricted. At present if this is “true” then no Web API commands will be accepted by this device.
        /// </summary>
        [JsonPropertyName("is_restricted")]
        public bool IsRestricted { get; private set; }

        /// <summary>
        /// The name of the device.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; private set; }

        /// <summary>
        /// Device type, such as “computer”, “smartphone” or “speaker”.
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; private set; }

        /// <summary>
        /// The current volume in percent. This may be null.
        /// </summary>
        [JsonPropertyName("volume_percent")]
        public int VolumePercent { get; private set; }
    }
}
