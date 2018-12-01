// Internals only visible for testing purpose.
using System.Runtime.CompilerServices;
[assembly:InternalsVisibleTo("SpotifyWebApiTest")]

namespace SpotifyWebApi
{
    using System;
    using System.Net.Http;
    using Api;
    using Api.Album;
    using Api.Artist;
    using Api.Browse;
    using Api.Follow;
    using Api.Personalization;
    using Api.Player;
    using Api.Playlist;
    using Api.Search;
    using Api.Track;
    using Api.UserLibrary;
    using Api.UserProfile;
    using Model.Auth;

    /// <summary>
    /// The main Api class.
    /// </summary>
    public class SpotifyWebApi : BaseApi, ISpotifyWebApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpotifyWebApi" /> class.
        /// </summary>
        /// <param name="token">A valid <see cref="Token"/>.</param>
        /// <param name="httpClient">The <see cref="HttpClient"/> to be used by the api.</param>
        public SpotifyWebApi(Token token, HttpClient httpClient)
            : base(token, httpClient)
        {
        }

        /// <inheritdoc />
        public IAlbumApi Album => new AlbumApi(this.Token, this.HttpClient);

        /// <inheritdoc />
        public IArtistApi Artist => new ArtistApi(this.Token, this.HttpClient);

        /// <inheritdoc />
        public IBrowseApi Browse => throw new NotImplementedException("This api is not yet implemented!");

        /// <inheritdoc />
        public IFollowApi Follow => throw new NotImplementedException("This api is not yet implemented!");

        /// <inheritdoc />
        public IPersonalizationApi Personalization => throw new NotImplementedException("This api is not yet implemented!");

        /// <inheritdoc />
        public IPlayerApi Player => new PlayerApi(this.Token, this.HttpClient);

        /// <inheritdoc />
        public IPlaylistApi Playlist => new PlaylistApi(this.Token, this.HttpClient);

        /// <inheritdoc />
        public ISearchApi Search => new SearchApi(this.Token, this.HttpClient);

        /// <inheritdoc />
        public ITrackApi Track => new TrackApi(this.Token, this.HttpClient);

        /// <inheritdoc />
        public IUserLibraryApi UserLibrary => throw new NotImplementedException("This api is not yet implemented!");

        /// <inheritdoc />
        public IUserProfileApi UserProfile => new UserProfileApi(this.Token, this.HttpClient);
    }
}
