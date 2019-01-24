namespace SpotifyWebApiTest.Api
{
    using System.Diagnostics;
    using System.Threading.Tasks;
    using Spotify.Api.Playlist;
    using Spotify.Model.Uri;
    using Xunit;
    using Xunit.Abstractions;

    /// <summary>
    /// The <see cref="AlbumTest"/>.
    /// </summary>
    public class PlaylistTest : TestBase
    {
        /// <inheritdoc />
        public PlaylistTest(TestData testData, ITestOutputHelper output) : base(testData, output)
        {
        }

        /// <summary>
        /// Tests the <see cref="IPlaylistApi.GetPlaylistTracks"/> method.
        /// </summary>
        /// <param name="uri">A playlist uri.</param>
        /// <param name="expectedTrackCount">The expected track count.</param>
        [Theory(Skip = "Unsupported")]
        [InlineData("spotify:user:1141820105:playlist:26JXqOmOpnO3hJ4Ij1EEKL", 20)]
        [InlineData("spotify:user:1141820105:playlist:4ReouBjlGOwe1btf1CAvIh", 100)]
        [InlineData("spotify:user:1141820105:playlist:2Iiwx1mspBbv9eV3gah2B9", 200)]
        [InlineData("spotify:user:1141820105:playlist:2vIxq3ZWHDDgrVfAzmIbDf", 1000)]
        // [InlineData("spotify:user:1141820105:playlist:4y6G7PQjyw48ha4SdbLF0A", 10000)]
        public async Task GetPlaylistTracksTest(string uri, int expectedTrackCount)
        {
            var st = Stopwatch.StartNew();
            var tracks = await this.Api.Playlist.GetPlaylistTracks(SpotifyUri.Make(uri));
            st.Stop();
            this.Output.WriteLine($"Getting {expectedTrackCount} tracks took {st.Elapsed:c}");
            Assert.Equal(expectedTrackCount, tracks.Count);
        }

        /// <summary>
        /// A test for correct retrieval of a playlist.
        /// </summary>
        [Fact(Skip = "Unsupported")]
        public async Task GetPlaylistTest()
        {
            var pl = await this.Api.Playlist.GetPlaylist(
                         "spotify:user:1141820105:playlist:26JXqOmOpnO3hJ4Ij1EEKL");
            Assert.NotNull(pl);
            Assert.Equal("Test Playlist (20 songs)", pl.Name);
        }
    }
}