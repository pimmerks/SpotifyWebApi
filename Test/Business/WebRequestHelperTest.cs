namespace Test.Business
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Threading.Tasks;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SpotifyWebApi.Business;
    using SpotifyWebApi.Model;
    using SpotifyWebApi.Model.Auth;

    /// <summary>
    /// The <see cref="WebRequestHelperTest"/>.
    /// </summary>
    [TestClass]
    public class WebRequestHelperTest
    {
        private Token token;

        /// <summary>
        /// TODO
        /// </summary>
        [TestMethod]
        public void TestGet()
        {
            var r = ApiClient.GetAsync<PublicUser>(new Uri("https://api.spotify.com/v1/users/smedjan"), this.token)
                     .GetAwaiter().GetResult();

            if (r.Response is PublicUser user)
            {
                Assert.AreEqual("smedjan", user.Id);
            }
            else
            {
                Assert.Fail(r.Type.ToString());
            }
        }

        /// <summary>
        /// TODO
        /// </summary>
        [TestMethod]
        public void TestCreateUpdateDeletePlaylist()
        {
            var postResult = ApiClient.PostAsync<FullPlaylist>(
                new Uri("https://api.spotify.com/v1/users/test/playlists"),
                new
                {
                    description = "test1",
                    @public = false,
                    name = "testplaylist",
                },
                this.token).GetAwaiter().GetResult();

            FullPlaylist playlist = null;

            if (postResult.Response is FullPlaylist p)
            {
                Assert.AreEqual("testplaylist", p.Name);
                playlist = p;
            }
            else
            {
                Assert.Fail(postResult.Type.ToString());
            }

            var putResult = ApiClient.PutAsync<FullPlaylist>(
                new Uri($"https://api.spotify.com/v1/users/test/playlists/{playlist.Id}"),
                new
                {
                    description = "TestPut",
                    @public = false,
                    name = "Test playlist put",
                },
                this.token).GetAwaiter().GetResult();
        }

        /// <summary>
        /// TODO
        /// </summary>
        [TestInitialize]
        public void InitializeTests()
        {
            this.token = new Token
            {
                ExpiresIn = 3600,
                AccessToken = "BQDT0Kjb_pHHfEge7ieU5EmaqxFi1jQyli5SB7DMz2GcQBYhBEFEQpZUL8FraK_ITfMj72YqgKxE2l6y-OHAn0RK0FydZZYF2NCHD885AjUvPIB0XCYHEvZ52Lyt0kGMbIeBLuO5FCjz842GWjj8Tt1XlTaScMsFYZKBfUwUIbObuz0W080Kb_Fv8dXLEITe1or3PxC7XxhfHscClWA7EsQVmi-9tRThP-ZKCJQU6ZsD_Ib7i3yeodf2z-9hZSiAObCjO-OSwg",
                RefreshToken = string.Empty,
                Type = "Bearer"
            };
        }
    }
}
