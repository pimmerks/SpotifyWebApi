namespace Spotify.WebApi.Apis.Album
{
    using System;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Business;
    using Model.Authentication;

    public class AlbumApi : IAlbumApi
    {
        private readonly Token token;
        private readonly HttpClient httpClient;

        public AlbumApi(Token token, HttpClient httpClient)
        {
            this.token = token;
            this.httpClient = httpClient;
        }

        public async Task<string> GetAlbumAsync(string id, string? market = null)
        {
            var uri = UriHelper.FromUri($"albums/{id}")
                               .AddParameter("market", market)
                               .Uri;

            return await this.httpClient.GetAsync<string>(uri);
        }
    }
}
