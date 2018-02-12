// <copyright file="AlbumTest.cs" company="companyPlaceholder">
// Copyright (c) companyPlaceholder. All rights reserved.
// </copyright>

namespace Test.Api
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SpotifyWebApi.Model.Auth;
    using SpotifyWebApi;

    /// <summary>
    /// The <see cref="AlbumTest"/>.
    /// </summary>
    [TestClass]
    public class AlbumTest
    {
        private Token token;
        private ISpotifyWebApi api;

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            this.token = new Token
            {
                AccessToken = "",
                Type = "Bearer"
            };

            this.api = new SpotifyWebApi(this.token);
        }

        /// <summary>
        /// The album test.
        /// </summary>
        public void GetAlbumTest()
        {
        }

        /// <summary>
        /// The albums test.
        /// </summary>
        public void GetAlbumsTest()
        {
        }

        /// <summary>
        /// The album tracks test.
        /// </summary>
        public void GetAlbumTracksTest()
        {
        }
    }
}
