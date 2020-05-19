namespace Spotify.WebApi.Apis.Album
{
    using System.Threading.Tasks;
    using Model;

    public interface IAlbumApi
    {
        public Task<string> GetAlbumAsync(SpotifyUri uri, string? market = null) => this.GetAlbumAsync(uri.Id, market);

        public Task<string> GetAlbumAsync(string id, string? market = null);
        
        
    }
}
