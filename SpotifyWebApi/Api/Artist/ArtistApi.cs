namespace SpotifyWebApi.Api.Artist
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Business;
    using Model;
    using Model.Auth;
    using Model.Enum;
    using Model.Uri;

    /// <inheritdoc cref="BaseApi"/>
    /// <summary>
    /// The <see cref="ArtistApi"/>.
    /// </summary>
    public class ArtistApi : BaseApi, IArtistApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArtistApi"/> class.
        /// </summary>
        /// <param name="token">A valid <see cref="Token"/>.</param>
        /// <param name="httpClient">The <see cref="HttpClient"/> to be used for every request.</param>
        public ArtistApi(Token token, HttpClient httpClient)
            : base(token, httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<FullArtist> GetArtist(SpotifyUri artistUri)
        {
            var r = await ApiClient.GetAsync<FullArtist>(
                        MakeUri($"artists/{artistUri.Id}"),
                        this.Token);

            if (r.Response is FullArtist res)
            {
                return res;
            }
            return new FullArtist();
        }

        /// <inheritdoc />
        public async Task<IList<FullArtist>> GetArtists(IList<SpotifyUri> artistUris)
        {
            Validation.ValidateList(artistUris, 0, 50);
            var ids = artistUris.Select(x => x.Id).ToList().AsSingleString();
            var r = await ApiClient.GetAsync<FullArtist>(
                        MakeUri($"artists?ids={ids}"),
                        this.Token);

            if (r.Response is List<FullArtist> res)
            {
                return res;
            }
            return new List<FullArtist>();
        }

        /// <inheritdoc />
        public async Task<IList<SimpleAlbum>> GetArtistAlbums(SpotifyUri artistUri, AlbumType albumTypes, string market, int maxResults, int offset)
        {
            var albumTypeString = string.Empty;
            if (albumTypes.HasFlag(AlbumType.Album)) albumTypeString += "album,";
            if (albumTypes.HasFlag(AlbumType.AppearsOn)) albumTypeString += "appears_on,";
            if (albumTypes.HasFlag(AlbumType.Compilation)) albumTypeString += "compilation,";
            if (albumTypes.HasFlag(AlbumType.Single)) albumTypeString += "compilation,";
            albumTypeString = albumTypeString.Remove(albumTypeString.Length - 1);

            var r = await ApiClient.GetAsync<Paging<SimpleAlbum>>(
                        MakeUri(
                            $"artists/{artistUri.Id}/albums?{albumTypeString}",
                            ("album_type", albumTypeString),
                            ("limit", "50"),
                            ("offset", offset.ToString()),
                            ("market", market)),
                        this.Token);

            if (r.Response is Paging<SimpleAlbum> res)
            {
                return await res.LoadToList(this.Token);
            }
            return new List<SimpleAlbum>();
        }

        /// <inheritdoc />
        public async Task<IList<FullTrack>> GetArtistsTopTracks(SpotifyUri artistUri, string market)
        {
            var r = await ApiClient.GetAsync<List<FullTrack>>(
                        MakeUri(
                            $"artists/{artistUri.Id}/top-tracks",
                            ("market", market)),
                        this.Token);

            if (r.Response is List<FullTrack> res)
            {
                return res;
            }
            return new List<FullTrack>();
        }

        /// <inheritdoc />
        public async Task<IList<FullArtist>> GetArtistsRelatedArtists(SpotifyUri artistUri)
        {
            var r = await ApiClient.GetAsync<List<FullArtist>>(
                        MakeUri($"artists/{artistUri.Id}/related-artists"),
                        this.Token);

            if (r.Response is List<FullArtist> res)
            {
                return res;
            }
            return new List<FullArtist>();
        }
    }
}
