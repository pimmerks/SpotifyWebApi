namespace SpotifyWebApi.Api.Search
{
    using System;
    using System.Linq;
    using System.Net.Http;
    using System.Threading.Tasks;
    using Business;
    using Model.Auth;
    using Model.Enum;
    using Model.Search;

    /// <summary>
    /// The <see cref="SearchApi"/>.
    /// </summary>
    public class SearchApi : BaseApi, ISearchApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchApi"/> class.
        /// </summary>
        /// <param name="token">A valid <see cref="Token"/>.</param>
        /// <param name="httpClient">The <see cref="HttpClient"/> to be used for every request.</param>
        public SearchApi(Token token, HttpClient httpClient)
        : base(token, httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<SearchResult> Search(
            string query,
            SearchType searchTypes,
            string market,
            int offset,
            int resultLimit)
        {
            var searchTypeString = string.Empty;
            if (searchTypes.HasFlag(SearchType.Album)) searchTypeString += "album,";
            if (searchTypes.HasFlag(SearchType.Artist)) searchTypeString += "artist,";
            if (searchTypes.HasFlag(SearchType.Playlist)) searchTypeString += "playlist,";
            if (searchTypes.HasFlag(SearchType.Track)) searchTypeString += "track,";

            var r = await this.GetAsync<ApiSearchResult>(
                        MakeUri(
                            "search",
                            ("q", query.Replace(' ', '+')),
                            ("type", searchTypeString.Remove(searchTypeString.Length - 1)),
                            ("offset", offset.ToString()),
                            ("market", market)));

            if (r.Response is ApiSearchResult res)
            {
                var result = new SearchResult
                {
                    Albums = res.Albums.Items,
                    Playlists = res.Playlists.Items,
                    Tracks = res.Tracks.Items,
                    Artists = res.Artists.Items
                };

                return result;
            }
            return new SearchResult();
        }
    }
}
