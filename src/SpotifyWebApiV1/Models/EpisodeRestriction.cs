namespace SpotifyWebApi.Models
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class EpisodeRestriction
    {
        /// <summary>
        ///     The reason for the restriction. Supported values:
        ///     <br />
        ///     - `market` - The content item is not available in the given market.
        ///     <br />
        ///     - `product` - The content item is not available for the user's subscription type.
        ///     <br />
        ///     - `explicit` - The content item is explicit and the user's account is set to not play explicit
        ///     content.
        ///     <br />
        ///     Additional reasons may be added in the future. **Note**: If you use this field, make sure that
        ///     your application safely handles unknown values.
        /// </summary>
        /// <value>
        ///     The reason for the restriction. Supported values:
        ///     <br />
        ///     - `market` - The content item is not available in the given market.
        ///     <br />
        ///     - `product` - The content item is not available for the user's subscription type.
        ///     <br />
        ///     - `explicit` - The content item is explicit and the user's account is set to not play explicit
        ///     content.
        ///     <br />
        ///     Additional reasons may be added in the future. **Note**: If you use this field, make sure that
        ///     your application safely handles unknown values.
        /// </value>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
