namespace Spotify.WebApi.Apis.Album
{
    using System.Threading.Tasks;
    using Model;
    using Model.Objects.Albums;

    public interface IAlbumApi
    {
        public Task<Album> GetAlbumAsync(SpotifyUri uri, string? market = null) => this.GetAlbumAsync(uri.Id, market);

        public Task<Album> GetAlbumAsync(string id, string? market = null);
    }
}
