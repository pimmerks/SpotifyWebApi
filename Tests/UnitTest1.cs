namespace Spotify.WebApi.Tests
{
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Model.Authentication;
    using WebApi;
    using Xunit;

    public class UnitTest1
    {
        [Fact]
        public async Task Test1()
        {
            var token = Token.Make("BQA6-uhlUjUYYlAH20F3SVQszvusIATJjLeo0IODVbO319pWBuzv1yETgDE1B5ocCxduPlSLrmCuibrsI8_jorvXtezubT2-SUXVRbYPFIkxCwU7Q-sUJAdS2my5YsmHqjWHd5czjvWP711QO_boIrbGGURnbzgSMmyuNpc");
            using var client = new HttpClient();
            var s = new SpotifyWebApi(token, client);

            var album = await s.Album.GetAlbumAsync("4aawyAB9vmqN3uQ7FjRGTy");
            var albums = await s.Album.GetAlbumsAsync(new List<string> {"4aawyAB9vmqN3uQ7FjRGTy", "4gaWk8Dxttn5CvKAN5kRYR"}, "ES");
            var tracks = await s.Album.GetAlbumsTrackAsync("4aawyAB9vmqN3uQ7FjRGTy", 0, 5);
        }
    }
}
