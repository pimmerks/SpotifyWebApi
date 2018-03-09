namespace SpotifyWebApiTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SpotifyWebApi;
    using SpotifyWebApi.Model.Auth;

    /// <summary>
    /// The <see cref="TestBase"/>.
    /// </summary>
    [TestClass]
    public class TestBase
    {
        /// <summary>
        /// TODO
        /// </summary>
        protected Token Token { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        protected ISpotifyWebApi Api { get; set; }

        /// <summary>
        /// TODO
        /// </summary>
        [TestInitialize]
        public void BaseTestInit()
        {
            // TODO: Initialize Token and Apis...
        }
    }
}
