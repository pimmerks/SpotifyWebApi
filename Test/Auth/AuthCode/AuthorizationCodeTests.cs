namespace SpotifyWebApiTest.Auth.AuthCode
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SpotifyWebApi.Auth;
    using SpotifyWebApi.Model.Enum;

    /// <summary>
    /// The <see cref="AuthorizationCodeTests" /> class.
    /// </summary>
    [TestClass]
    public class AuthorizationCodeTests
    {
        /// <summary>
        /// Gets the URL test.
        /// </summary>
        [TestMethod]
        public void GetUrlTest()
        {
            var code = AuthorizationCode.GetUrl(
                new AuthParameters
                {
                    Scopes = Scope.PlaylistModifyPrivate | Scope.UserLibraryRead,
                    RedirectUri = "test",
                    ClientId = "test",
                    ShowDialog = true,
                    ClientSecret = "tests"
                },
                "test");
        }
    }
}