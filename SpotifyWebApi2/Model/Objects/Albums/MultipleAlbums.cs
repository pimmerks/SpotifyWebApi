namespace Spotify.WebApi.Model.Objects.Albums
{
    using System.Collections.Generic;
    using System.Text.Json.Serialization;

    /// <summary>
    /// Internal class for wrapping the MultipleAlbums response.
    /// </summary>
    internal class MultipleAlbums
    {
        [JsonPropertyName("albums")]
        public List<Album> Albums { get; set; }
    }
}
