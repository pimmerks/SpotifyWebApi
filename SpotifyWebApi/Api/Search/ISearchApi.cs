namespace SpotifyWebApi.Api.Search
{
    using System.Threading.Tasks;
    using Model.Enum;
    using Model.Search;

    /// <summary>
    /// The search api.
    /// </summary>
    public interface ISearchApi
    {
        /// <summary>
        /// Get Spotify catalog information about artists, albums, tracks or playlists that match a keyword string.
        /// Note: There is only support for 20 results per category.
        /// TODO: Add support for more than 20 results per category.
        /// </summary>
        /// <param name="query">The search query's keywords (and optional field filters and operators).
        /// For more info see: https://developer.spotify.com/web-api/search-item/ </param>
        /// <param name="searchTypes">A list of item types to search across.
        /// Note you can specify multiple search types like: <c>SearchType.Album | SearchType.Artist</c>.</param>
        /// <param name="market">Optional. An ISO 3166-1 alpha-2 country code.</param>
        /// <param name="offset">Optional. The starting offset of the search.</param>
        /// <param name="resultLimit">The maximum results to return per category.</param>
        /// <returns>A list of <see cref="object"/>s.</returns>
        Task<SearchResult> Search(
            string query,
            SearchType searchTypes = SearchType.Album | SearchType.Artist | SearchType.Playlist | SearchType.Track,
            string market = "",
            int offset = 0,
            int resultLimit = 20);
    }
}