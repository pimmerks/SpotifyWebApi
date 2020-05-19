namespace Spotify.WebApi
{
    using Apis.Album;
    using Model.Authentication;

    public interface ISpotifyWebApi
    {
        public const string BaseUri = "https://api.spotify.com/v1/";

        public Token Token { get; set; }

        public IAlbumApi Album { get; }
    }
}
