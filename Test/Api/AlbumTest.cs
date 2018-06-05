namespace SpotifyWebApiTest.Api
{
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SpotifyWebApi;
    using SpotifyWebApi.Api;
    using SpotifyWebApi.Model.Auth;
    using SpotifyWebApi.Model.Uri;

    /// <summary>
    /// The <see cref="AlbumTest"/>.
    /// </summary>
    [TestClass]
    public class AlbumTest : TestBase
    {
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            this.Token = new Token
            {
                AccessToken = string.Empty,
                Type = "Bearer"
            };

            this.Api = new SpotifyWebApi(this.Token);
        }

        /// <summary>
        /// The album test.
        /// </summary>
        [TestMethod]
        public void GetAlbumTest()
        {
        }

        /// <summary>
        /// The albums test.
        /// </summary>
        [TestMethod]
        public void GetAlbumsTest()
        {
        }

        /// <summary>
        /// The album tracks test.
        /// </summary>
        [TestMethod]
        public void GetAlbumTracksTest()
        {
        }
    }
}
