namespace SpotifyWebApiTest.Api
{
    using System;
    using System.Diagnostics;
    using System.Threading.Tasks;
    using Spotify.Api.Album;
    using Spotify.Model.Exception;
    using Spotify.Model.Uri;
    using Xunit;
    using Xunit.Abstractions;

    /// <summary>
    /// The <see cref="AlbumTest"/>.
    /// </summary>
    public class AlbumTest : TestBase
    {
        /// <inheritdoc />
        public AlbumTest(TestData testData, ITestOutputHelper output) : base(testData, output)
        {
        }

        /// <summary>
        /// The album test.
        /// </summary>
        [Theory(Skip = "Unsupported")]
        [InlineData("spotify:album:44tJAQ21VUkgwjRDbNeJtB", "Funky Freddy")]
        [InlineData("spotify:album:1JG04tRkcORA9RP3p06oGp", "Palmas")]
        public async Task GetAlbumTest(string uri, string expectedName)
        {
            var album = await this.Api.Album.GetAlbum(uri);
            Assert.True(album.Name == expectedName);
            Assert.NotNull(album);
        }

        /// <summary>
        /// The albums test.
        /// </summary>
        [Fact(Skip = "Unsupported")]
        public async Task GetAlbumsTest()
        {
            var albums = await this.Api.Album.GetAlbums(
                    SpotifyUri.MakeList(
                        "spotify:album:44tJAQ21VUkgwjRDbNeJtB",
                        "spotify:album:1JG04tRkcORA9RP3p06oGp"));
            Assert.Equal(2, albums.Count);
            Assert.True(albums[0].Name == "Funky Freddy");
            Assert.True(albums[1].Name == "Palmas");
        }

        /// <summary>
        /// The album tracks test.
        /// </summary>
        [Theory(Skip = "Unsupported")]
        [InlineData("spotify:album:44tJAQ21VUkgwjRDbNeJtB", 1)]
        [InlineData("spotify:album:1JG04tRkcORA9RP3p06oGp", 21)]
        public async Task GetAlbumTracksTest(string uri, int expectedTrackCount)
        {
            var tracks = await this.Api.Album.GetAlbumTracks(SpotifyUri.Make(uri));
            Assert.Equal(expectedTrackCount, tracks.Count);
        }

        /// <summary>
        /// Tests to see if the validation works.
        /// </summary>
        [Fact(Skip = "Unsupported")]
        public async Task GetAlbumTrackExceptionTest()
        {
            await Assert.ThrowsAsync<BadRequestException>(
                async () => await this.Api.Album.GetAlbum("spotify:album:fdsajkfdsjkha"));
        }

        /// <summary>
        /// Tests to see if the validation works.
        /// </summary>
        [Fact(Skip = "Unsupported")]
        public async Task UnauthorizedExceptionTest()
        {
            await Assert.ThrowsAsync<UnauthorizedAccessException>(
                async () => await new AlbumApi(null).GetAlbum("spotify:album:fdsajkfdsjkha", ""));
        }
    }
}
