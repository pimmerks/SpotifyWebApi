namespace Spotify.WebApi
{
    using System.Net.Http;
    using Apis.Album;
    using Business;
    using Model.Authentication;

    public class SpotifyWebApi : ISpotifyWebApi
    {
        private readonly HttpClient httpClient;

        public Token Token { get; set; }

        public SpotifyWebApi(HttpClient httpClient)
            : this(null, httpClient)
        {
        }

        public SpotifyWebApi(Token token, HttpClient httpClient)
        {
            this.httpClient = httpClient;
            this.Token = token;

            if (this.Token != null)
            {
                this.httpClient.AddToken(token);
            }
        }

        public IAlbumApi Album => new AlbumApi(this.Token, this.httpClient);
    }
}
