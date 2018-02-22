namespace Test.Api
{
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SpotifyWebApi.Model.Auth;
    using SpotifyWebApi;
    using SpotifyWebApi.Model.Uri;

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
        [TestMethod]
        public void GetAlbumTest()
        {
            var album = this.api.Album.GetAlbum(new SpotifyUri("spotify:album:0sNOF9WDwhWunNAHPD3Baj"));

            Assert.AreEqual("0sNOF9WDwhWunNAHPD3Baj", album.Id);
            Assert.AreEqual("Epic/Legacy", album.Label);
            Assert.AreEqual("She's So Unusual", album.Name);
            Assert.AreEqual(13, album.Tracks.Total);
            Assert.AreEqual("Cyndi Lauper", album.Artists.First().Name);
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
