namespace SpotifyWebApi.Api.Implementation
{
    using System.Net.Http;
    using System.Threading.Tasks;
    using SpotifyWebApi.Extensions;
    using SpotifyWebApi.Models;
    using SpotifyWebApi.Models.Auth;

    public class TracksApi : BaseApiClient, ITracksApi
    {
        public TracksApi(HttpClient client, Token accessToken)
            : base(client, accessToken)
        {
        }

        public async Task<Track> GetTrackAsync(string id, string? market)
        {
            return await this.HttpClient.GetAsync<Track>(
                $"tracks/{id}",
                CancellationToken.None,
                new KeyValuePair<string?, string?>("market", market));
        }
    }
}
