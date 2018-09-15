namespace SpotifyWebApiTest.Api
{
    using System.Diagnostics;
    using System.Threading.Tasks;
    using SpotifyWebApi.Model.Uri;
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
        [Theory]
        [InlineData("spotify:album:44tJAQ21VUkgwjRDbNeJtB", "Funky Freddy")]
        [InlineData("spotify:album:1JG04tRkcORA9RP3p06oGp", "Palmas")]
        public async Task GetAlbumTest(string uri, string expectedName)
        {
            var album = await this.TestData.Api.Album.GetAlbum(SpotifyUri.Make(uri));
            Assert.True(album.Name == expectedName);
            Assert.NotNull(album);
        }

        /// <summary>
        /// The albums test.
        /// </summary>
        [Fact]
        public async Task GetAlbumsTest()
        {
            var albums = await this.TestData.Api.Album.GetAlbums(
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
        [Theory]
        [InlineData("spotify:album:44tJAQ21VUkgwjRDbNeJtB", 1)]
        [InlineData("spotify:album:1JG04tRkcORA9RP3p06oGp", 21)]
        public async Task GetAlbumTracksTest(string uri, int expectedTrackCount)
        {
            var tracks = await this.TestData.Api.Album.GetAlbumTracks(SpotifyUri.Make(uri));
            Assert.Equal(expectedTrackCount, tracks.Count);
        }
    }
}
