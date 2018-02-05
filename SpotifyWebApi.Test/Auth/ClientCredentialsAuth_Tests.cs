namespace SpotifyWebApi.Test.Auth
{
    using global::SpotifyWebApi.Auth;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass()]
    public class ClientCredentialsAuth_Tests
    {
        [TestMethod()]
        public void RequestToken_Test()
        {
            var token = ClientCredentialsAuth.RequestToken(Properties.Settings.Default.ClientId, Properties.Settings.Default.ClientSecret);
            Assert.IsNotNull(token);
            Assert.IsTrue(token.AccessToken.Length > 0);
            Assert.IsTrue(token.Type.Length > 0);
        }
    }
}