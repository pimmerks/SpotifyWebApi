namespace SpotifyWebApi.Test.Api
{
    using System;
    using global::SpotifyWebApi.Api;
    using global::SpotifyWebApi.Model;
    using global::SpotifyWebApi.Model.Auth;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass()]
    public class ApiHelper_Tests
    {
        Token token = null;
        String albumJson = "";

        public ApiHelper_Tests()
        {
            this.token = global::SpotifyWebApi.Auth.ClientCredentialsAuth.RequestToken(Properties.Settings.Default.ClientId, Properties.Settings.Default.ClientSecret);
            Assert.IsNotNull(this.token);
        }


        [TestMethod()]
        public void GetJsonFromUrl_Test_String()
        {
            Assert.IsNotNull(this.token);

            var json = ApiHelper.GetJsonFromUrl("https://api.spotify.com/v1/albums/4aawyAB9vmqN3uQ7FjRGTy", this.token);

            Assert.AreNotEqual(json, "");
        }

        [TestMethod()]
        public void GetJsonFromUrl_Test_URI()
        {
            Assert.IsNotNull(this.token);

            this.albumJson = ApiHelper.GetJsonFromUrl(new Uri("https://api.spotify.com/v1/albums/4aawyAB9vmqN3uQ7FjRGTy"), this.token);

            Assert.AreNotEqual(this.albumJson, "");
        }

        [TestMethod()]
        public void JsonToObject_Test()
        {
            var album = ApiHelper.JsonToObject<SimpleAlbum>(this.albumJson);

            Assert.IsNotNull(album);
            Assert.IsNotNull(album.Id);
        }

        [TestMethod()]
        public void GetObjectFromUrl_Test()
        {

        }
    }
}