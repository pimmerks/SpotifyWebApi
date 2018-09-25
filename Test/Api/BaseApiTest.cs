using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifyWebApiTest.Api
{
    using SpotifyWebApi.Api;
    using SpotifyWebApi.Model.Auth;
    using Xunit;

    /// <summary>
    /// A test for the <see cref="BaseApi"/>.
    /// </summary>
    public class BaseApiTest : BaseApi
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes this test class.
        /// </summary>
        public BaseApiTest()
            : base(null)
        {
        }

        /// <summary>
        /// A test for the make uri method.
        /// </summary>
        [Fact]
        public void MakeUriTest()
        {
            var uri1 = MakeUri("test");
            Assert.Equal("https://api.spotify.com/v1/test", uri1.AbsoluteUri);
        }

        /// <summary>
        /// A test for the make uri method.
        /// </summary>
        /// <param name="expected">The expected absolute uri.</param>
        /// <param name="r">The relative uri.</param>
        /// <param name="q">The query parameter</param>
        /// <param name="v">The query value</param>
        [Theory]
        [InlineData("https://api.spotify.com/v1/test", "test", "", "")]
        [InlineData("https://api.spotify.com/v1/test", "test", "q", "")]
        [InlineData("https://api.spotify.com/v1/test", "test", "", "v")]
        [InlineData("https://api.spotify.com/v1/test?q=v", "test", "q", "v")]
        public void MakeUriTests(string expected, string r, string q, string v)
        {
            var uri = MakeUri(r, (queryParameter: q, value: v));
            Assert.Equal(expected, uri.AbsoluteUri);
        }

        /// <summary>
        /// A test for the make uri method.
        /// </summary>
        /// <param name="expected">The expected absolute uri.</param>
        /// <param name="r">The relative uri.</param>
        /// <param name="q1">The query parameter</param>
        /// <param name="v1">The query value</param>
        /// <param name="q2">The query parameter</param>
        /// <param name="v2">The query value</param>
        [Theory]
        [InlineData("https://api.spotify.com/v1/test", "test", "", "", "", "")]
        [InlineData("https://api.spotify.com/v1/test?q=v&q=v", "test", "q", "v", "q", "v")]
        [InlineData("https://api.spotify.com/v1/test", "test", "q", "", "", "v")]
        [InlineData("https://api.spotify.com/v1/test?q=v", "test", "q", "", "q", "v")]
        public void MakeUriTest2(string expected, string r, string q1, string v1, string q2, string v2)
        {
            var uri = MakeUri(r, (q1, v1), (q2, v2));
            Assert.Equal(expected, uri.AbsoluteUri);
        }
    }
}
