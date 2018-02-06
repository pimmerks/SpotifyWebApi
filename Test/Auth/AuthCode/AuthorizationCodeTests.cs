namespace Test.Auth.AuthCode
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SpotifyWebApi.Auth;
    using SpotifyWebApi.Auth.AuthorizationCode;
    using SpotifyWebApi.Model.Enum;

    [TestClass]
    public class AuthorizationCodeTests
    {
        [TestMethod()]
        public void GetUrlTest()
        {
            var code = AuthorizationCode.GetUrl(new AuthParameters
            {
                Scopes = Scope.PlaylistModifyPrivate | Scope.UserLibraryRead,
                RedirectUri = "test",
                ClientId = "test",
                ShowDialog = true,
                ClientSecret = "tests"
            }, "test");
        }
    }
}