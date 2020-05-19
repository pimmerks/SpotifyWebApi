namespace Spotify.WebApi
{
    using System;
    using System.Net.Http;
    using Apis.Album;
    using Business;
    using Model.Authentication;

    public interface ISpotifyWebApi
    {
        public const string BaseUri = "https://api.spotify.com/v1/";
        
        public IAlbumApi Album { get; }

        public Token Token { get; set; }
    }

    public class SpotifyWebApi : ISpotifyWebApi
    {
        private readonly HttpClient httpClient;

        public Token Token { get; set; }

        public SpotifyWebApi(Token token, HttpClient httpClient)
        {
            this.httpClient = httpClient;
            this.Token = token;
        }

        public IAlbumApi Album => new AlbumApi(this.Token, this.httpClient);
    }
}
