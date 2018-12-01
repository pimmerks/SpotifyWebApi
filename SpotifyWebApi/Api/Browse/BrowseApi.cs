namespace SpotifyWebApi.Api.Browse
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using global::SpotifyWebApi.Business;
    using Model;
    using Model.Auth;

    /// <inheritdoc cref="BaseApi"/>
    /// <summary>
    /// The <see cref="BrowseApi"/>.
    /// </summary>
    public class BrowseApi : BaseApi, IBrowseApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrowseApi"/> class.
        /// </summary>
        /// <param name="token">A valid <see cref="Token"/>.</param>
        /// <param name="httpClient">The <see cref="HttpClient"/> to be used for every request.</param>
        public BrowseApi(Token token, HttpClient httpClient)
            : base(token, httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<(string Message, IList<SimplePlaylist> Playlists)> GetFeaturedPlaylists(
            string locale,
            string country,
            DateTime? timeStamp,
            int maxResults,
            int offset)
        {
            var r = await this.GetAsync<FeaturedPlaylistResponse>(
                       MakeUri(
                           $"browse/featured-playlists",
                           ("locale", locale),
                           ("country", country),
                           ("timestamp", $"{timeStamp:O}")));

            if (r.Response is FeaturedPlaylistResponse res)
            {
                return (res.Message, res.Playlists);
            }
            return (string.Empty, new List<SimplePlaylist>());
        }

        private class FeaturedPlaylistResponse
        {
            public string Message { get; set; }

            public List<SimplePlaylist> Playlists { get; set; }
        }
    }
}
