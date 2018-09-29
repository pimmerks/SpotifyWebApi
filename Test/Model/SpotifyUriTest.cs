using System;
using System.Collections.Generic;
using System.Text;

namespace SpotifyWebApiTest.Model
{
    using SpotifyWebApi.Model.Exception;
    using SpotifyWebApi.Model.Uri;
    using Xunit;

    /// <summary>
    /// A class testing the correct functioning of <see cref="SpotifyUri"/>.
    /// </summary>
    public class SpotifyUriTest
    {
        /// <summary>
        /// Tests the <c>SpotifyUri.Make()</c> method.
        /// </summary>
        /// <param name="u">The uri to convert.</param>
        /// <param name="type">The <see cref="UriType"/>.</param>
        [Theory]
        [InlineData("spotify:album:1JG04tRkcORA9RP3p06oGp", UriType.Album)]
        [InlineData("spotify:artist:2JPBDCZC133viR1884BIEi", UriType.Artist)]
        [InlineData("spotify:user:1141820105:playlist:2vIxq3ZWHDDgrVfAzmIbDf", UriType.Playlist)]
        [InlineData("spotify:track:0ZGZTut99seZYeJTLy7QZG", UriType.Track)]
        [InlineData("spotify:user:1141820105", UriType.User)]
        public void UriTypeTest(string u, UriType type)
        {
            var uri = SpotifyUri.Make(u);
            Assert.Equal(u, uri.FullUri);
            Assert.Equal(type, uri.Type);
        }

        /// <summary>
        /// Tests the SpotifyUri.Make method for correct exceptions.
        /// </summary>
        [Fact]
        public void UriExceptionTest()
        {
            Assert.Throws<ArgumentException>(() => SpotifyUri.Make(""));
            Assert.Throws<ArgumentException>(() => SpotifyUri.Make("", UriType.Album));
            Assert.Throws<ArgumentException>(() => SpotifyUri.Make("", ""));
            Assert.Throws<ArgumentException>(() => SpotifyUri.Make("Test", ""));
            Assert.Throws<ArgumentException>(() => SpotifyUri.Make("", "Test"));
            Assert.Throws<NotSupportedException>(() => SpotifyUri.Make("Test", UriType.Playlist));
            Assert.Throws<InvalidUriException>(() => SpotifyUri.Make("a:a:a:a:a"));
            Assert.Throws<InvalidUriException>(() => SpotifyUri.Make("spotify:::"));
        }

        /// <summary>
        /// Tests the SpotifyUri.Make method for correct functioning.
        /// </summary>
        [Fact]
        public void UriTest()
        {
            var u1 = SpotifyUri.Make("0ZGZTut99seZYeJTLy7QZG", UriType.Track);
            var u2 = SpotifyUri.Make("1141820105", "2vIxq3ZWHDDgrVfAzmIbDf");

            Assert.Equal(UriType.Track, u1.Type);
            Assert.Equal("spotify:track:0ZGZTut99seZYeJTLy7QZG", u1.FullUri);
            Assert.Equal(UriType.Playlist, u2.Type);
            Assert.Equal("spotify:user:1141820105:playlist:2vIxq3ZWHDDgrVfAzmIbDf", u2.FullUri);
        }
    }
}
