namespace Spotify.WebApi
{
    using Spotify.WebApi.Apis.Album;

    /// <summary>
    /// Main Spotify Web Api interface.
    /// </summary>
    public interface ISpotifyWebApi
    {
        /// <summary>
        /// The default base uri of the Spotify Web Api.
        /// </summary>
        public const string BaseUri = "https://api.spotify.com/v1/";

        /// <summary>
        /// Gets the <see cref="IAlbumApi"/>.
        /// </summary>
        public IAlbumApi Album { get; }
    }
}
