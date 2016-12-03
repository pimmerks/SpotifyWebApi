using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpotifyWebApi.Api;
using SpotifyWebApi.Model;
using SpotifyWebApi.Model.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyWebApi.Api_Tests
{
    [TestClass()]
    public class ApiHelper_Tests
    {
        Token token = null;
        String albumJson = "";

        public ApiHelper_Tests()
        {
            token = Auth.ClientCredentialsAuth.RequestToken(SpotifyWebApi_Tests.Properties.Settings.Default.ClientId, SpotifyWebApi_Tests.Properties.Settings.Default.ClientSecret);
            Assert.IsNotNull(token);
        }


        [TestMethod()]
        public void GetJsonFromUrl_Test_String()
        {
            Assert.IsNotNull(token);

            var json = ApiHelper.GetJsonFromUrl("https://api.spotify.com/v1/albums/4aawyAB9vmqN3uQ7FjRGTy", token);

            Assert.AreNotEqual(json, "");
        }

        [TestMethod()]
        public void GetJsonFromUrl_Test_URI()
        {
            Assert.IsNotNull(token);

            albumJson = ApiHelper.GetJsonFromUrl(new Uri("https://api.spotify.com/v1/albums/4aawyAB9vmqN3uQ7FjRGTy"), token);

            Assert.AreNotEqual(albumJson, "");
        }

        [TestMethod()]
        public void JsonToObject_Test()
        {
            var album = ApiHelper.JsonToObject<SimpleAlbum>(albumJson);

            Assert.IsNotNull(album);
            Assert.IsNotNull(album.Id);
        }

        [TestMethod()]
        public void GetObjectFromUrl_Test()
        {

        }
    }
}