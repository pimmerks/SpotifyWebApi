// <copyright file="SpotifyWebApi.cs" company="companyPlaceholder">
// Copyright (c) companyPlaceholder. All rights reserved.
// </copyright>

namespace SpotifyWebApi
{
    using System;
    using System.Runtime.Remoting.Messaging;
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
    /// The <see cref="SpotifyWebApi"/>.
    /// </summary>
    public class SpotifyWebApi : BaseApi, ISpotifyWebApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpotifyWebApi"/> class.
        /// </summary>
        public SpotifyWebApi(Token token) : base(token)
        {
        }

        /// <inheritdoc />
        public IAlbumApi Album => new AlbumApi(this.Token);

        /// <inheritdoc />
        public IArtistApi Artist => new ArtistApi(this.Token);

        /// <inheritdoc />
        public IBrowseApi Browse => throw new NotImplementedException();

        /// <inheritdoc />
        public IFollowApi Follow => throw new NotImplementedException();

        /// <inheritdoc />
        public IPersonalizationApi Personalization => throw new NotImplementedException();

        /// <inheritdoc />
        public IPlayerApi Player => throw new NotImplementedException();

        /// <inheritdoc />
        public IPlaylistApi Playlist => throw new NotImplementedException();

        /// <inheritdoc />
        public ISearchApi Search => throw new NotImplementedException();

        /// <inheritdoc />
        public ITrackApi Track => throw new NotImplementedException();

        /// <inheritdoc />
        public IUserLibraryApi UserLibrary => throw new NotImplementedException();

        /// <inheritdoc />
        public IUserProfileApi UserProfile => new UserProfileApi(this.Token);
    }
}
