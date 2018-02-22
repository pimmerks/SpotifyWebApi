namespace SpotifyWebApi
{
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
        public SpotifyWebApi(Token token)
            : base(token)
        {
        }

        /// <inheritdoc />
        public IAlbumApi Album => new AlbumApi(this.Token);

        /// <inheritdoc />
        public IArtistApi Artist => new ArtistApi(this.Token);

        /// <inheritdoc />
        public IBrowseApi Browse => null;

        /// <inheritdoc />
        public IFollowApi Follow => null;

        /// <inheritdoc />
        public IPersonalizationApi Personalization => null;

        /// <inheritdoc />
        public IPlayerApi Player => null;

        /// <inheritdoc />
        public IPlaylistApi Playlist => null;

        /// <inheritdoc />
        public ISearchApi Search => null;

        /// <inheritdoc />
        public ITrackApi Track => null;

        /// <inheritdoc />
        public IUserLibraryApi UserLibrary => null;

        /// <inheritdoc />
        public IUserProfileApi UserProfile => new UserProfileApi(this.Token);
    }
}
