// <copyright file="SearchApi.cs" company="companyPlaceholder">
// Copyright (c) companyPlaceholder. All rights reserved.
// </copyright>

namespace SpotifyWebApi.Api.Search
{
    using System;
    using System.Collections.Generic;
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
        public SearchApi(Token token)
            : base(token)
        {
        }

        /// <inheritdoc />
        public async Task<IList<object>> Search(
            string query,
            SearchType searchTypes = SearchType.Album | SearchType.Artist | SearchType.Playlist | SearchType.Track,
            string market = "",
            int offset = 0,
            int resultLimit = 100)
        {
            var searchTypeString = "&type=";
            if (searchTypes.HasFlag(SearchType.Album)) searchTypeString += "album,";
            if (searchTypes.HasFlag(SearchType.Artist)) searchTypeString += "artist,";
            if (searchTypes.HasFlag(SearchType.Playlist)) searchTypeString += "playlist,";
            if (searchTypes.HasFlag(SearchType.Track)) searchTypeString += "track,";
            searchTypeString = searchTypeString.Remove(searchTypeString.Length - 1);

            var r = await ApiClient.GetAsync<SearchResult>(
                        MakeUri($"search?q={query}{searchTypeString}&offset={offset}{AddMarketCode("&", market)}"),
                        this.Token);

            if (r.Response is SearchResult res)
            {
                var result = new List<object>();
                try
                {
                    var artists = res.Artists.LoadToList(this.Token);
                    var albums = res.Albums.LoadToList(this.Token);
                    var playlists = res.Playlists.LoadToList(this.Token);
                    var tracks = res.Tracks.LoadToList(this.Token);

                    // Await all tasks finished...
                    await Task.WhenAll(artists, albums, playlists, tracks);

                    result.AddRange(artists.Result);
                    result.AddRange(albums.Result);
                    result.AddRange(playlists.Result);
                    result.AddRange(tracks.Result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                return result;
            }
            return new List<object>();
        }
    }
}
