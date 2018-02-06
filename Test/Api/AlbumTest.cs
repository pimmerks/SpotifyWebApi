// <copyright file="AlbumTest.cs" company="companyPlaceholder">
// Copyright (c) companyPlaceholder. All rights reserved.
// </copyright>

namespace Test.Api
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
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

        public void GetAlbumTest()
        {
        }

        public void GetAlbumsTest()
        {
        }

        public void GetAlbumTracksTest()
        {
        }
    }
}
