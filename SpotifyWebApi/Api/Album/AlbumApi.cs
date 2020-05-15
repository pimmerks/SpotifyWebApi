namespace SpotifyWebApi.Api.Album
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Business;
    using Model;
    using Model.Auth;
    using Model.List;
    using Model.Uri;

    /// <inheritdoc cref="BaseApi"/>
    /// <summary>
    /// The <see cref="AlbumApi"/>.
    /// </summary>
    public class AlbumApi : BaseApi, IAlbumApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlbumApi"/> class.
        /// </summary>
        /// <param name="token">A valid <see cref="Token"/>.</param>
        public AlbumApi(Token token)
            : base(token)
        {
        }

        /// <inheritdoc />
        public async Task<FullAlbum> GetAlbum(SpotifyUri albumUri, string? market)
        {
            return await this.GetAsync<FullAlbum>($"albums/{albumUri.Id}");
        }

        /// <inheritdoc />
        public async Task<IList<FullAlbum>> GetAlbums(IList<SpotifyUri> albumUris, string? market)
        {
            Validation.ValidateList(albumUris, nameof(albumUris), max: 50);

            var albumIds = string.Join(",", albumUris.Select(x => x.Id).ToArray());

            this.AddQueryParameters(
                "albums",
                new KeyValuePair<string, string>("ids", albumIds),
                new KeyValuePair<string, string>("market", market));

            return (await this.GetAsync<MultipleAlbums>("albums?ids=")).Albums;
        }

        /// <inheritdoc />
        public async Task<IList<SimpleTrack>> GetAlbumTracks(SpotifyUri albumUri, string? market)
        {
            var r = await ApiClient.GetAsync<Paging<SimpleTrack>>(
                        MakeUri(
                            $"albums/{albumUri.Id}/tracks",
                            ("limit", "50"),
                            ("offset", "0"), // TODO: Offset
                            ("market", market)),
                        this.Token);

            if (r.Response is Paging<SimpleTrack> tracks)
            {
                return await tracks.LoadToList(this.Token);
            }
            return new List<SimpleTrack>();
        }
    }
}
