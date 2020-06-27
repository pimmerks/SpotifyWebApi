namespace Spotify.WebApi.Tests.Business
{
    using Spotify.WebApi.Business;
    using Xunit;

    public class UriHelperTests
    {
        [Fact]
        public void FromUri_ReturnsValidUri()
        {
            var uri = UriHelper.FromUri("test");

            Assert.Equal($"{ISpotifyWebApi.BaseUri}test", uri.Uri.ToString());
        }
    }
}
