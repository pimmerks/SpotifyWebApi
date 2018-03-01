namespace SpotifyWebApiTest
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SpotifyWebApi;
    using SpotifyWebApi.Model.Auth;

    /// <summary>
    /// The <see cref="TestBase"/>.
    /// </summary>
    [TestClass]
    public class TestBase
    {
        protected Token Token;
        protected ISpotifyWebApi Api;

        [TestInitialize]
        public void BaseTestInit()
        {
            // TODO: Initialize Token and Apis...
        }
    }
}
