using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpotifyWebApi.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyWebApi.Auth_Tests
{
    [TestClass()]
    public class ClientCredentialsAuth_Tests
    {
        [TestMethod()]
        public void RequestToken_Test()
        {
            var token = ClientCredentialsAuth.RequestToken(SpotifyWebApi_Tests.Properties.Settings.Default.ClientId, SpotifyWebApi_Tests.Properties.Settings.Default.ClientSecret);
            Assert.IsNotNull(token);
            Assert.IsTrue(token.AccessToken.Length > 0);
            Assert.IsTrue(token.Type.Length > 0);
        }
    }
}