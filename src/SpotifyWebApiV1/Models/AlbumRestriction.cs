namespace SpotifyWebApi.Models
{
    using System.Text.Json.Serialization;

    /// <summary>
    /// </summary>
    public class AlbumRestriction
    {
        /// <summary>
        ///     The reason for the restriction. Albums may be restricted if the content is not available in a given market, to the
        ///     user's subscription type, or when the user's account is set to not play explicit content. Additional reasons may be
        ///     added in the future.
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
