namespace SpotifyWebApi.Api.Album
{
    using System.Collections.Generic;
    using System.Linq;
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
        public async Task<FullAlbum> GetAlbum(SpotifyUri albumUri, string market)
        {
            var r = await ApiClient.GetAsync<FullAlbum>(
                        MakeUri($"albums/{albumUri.Id}{AddMarketCode("?", market)}"),
                        this.Token);

            if (r.Response is FullAlbum album)
            {
                return album;
            }
            return new FullAlbum();
        }

        /// <inheritdoc />
        public async Task<IList<FullAlbum>> GetAlbums(IList<SpotifyUri> albumUris, string market)
        {
            var lists = albumUris.ChunkBy(50);

            var res = new List<FullAlbum>();

            foreach (var l in lists)
            {
                var s = string.Join(",", l.Select(x => x.Id).ToArray());

                var r = await ApiClient.GetAsync<MultipleAlbums>(
                        MakeUri($"albums?ids={s}{AddMarketCode("&", market)}"),
                        this.Token);

                if (r.Response is MultipleAlbums albums)
                {
                    res.AddRange(albums.Albums);
                }
            }

            return res;
        }

        /// <inheritdoc />
        public async Task<IList<SimpleTrack>> GetAlbumTracks(SpotifyUri albumUri, string market)
        {
            var r = await ApiClient.GetAsync<Paging<SimpleTrack>>(
                        MakeUri($"albums/{albumUri.Id}/tracks?limit={50}&offset={0}{AddMarketCode("&", market)}"),
                        this.Token);

            if (r.Response is Paging<SimpleTrack> tracks)
            {
                return await HelperExtensions.LoadToList(tracks, this.Token);
            }
            return new List<SimpleTrack>();
        }
    }
}
