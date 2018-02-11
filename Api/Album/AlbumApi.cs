// <copyright file="AlbumApi.cs" company="companyPlaceholder">
// Copyright (c) companyPlaceholder. All rights reserved.
// </copyright>

namespace SpotifyWebApi.Api.Album
{
    using System.Collections.Generic;
    using System.Linq;
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
        public FullAlbum GetAlbum(SpotifyUri albumUri, string market = "")
        {
            var res = ApiHelper.GetObjectFromUrl<FullAlbum>(
                ApiHelper.GetUri($"/albums/{albumUri.Id}{AddMarketCode("?", market)}"),
                this.Token);

            return res.Response;
        }

        /// <inheritdoc />
        public IList<FullAlbum> GetAlbums(IList<SpotifyUri> albumUris, string market = "")
        {
            Validation.ValidateList(albumUris, 1, 50);
            var l = string.Join(",", albumUris.Select(x => x.Id).ToArray());

            var res = ApiHelper.GetObjectFromUrl<MultipleAlbums>(
                ApiHelper.GetUri($"/albums?ids={l}{AddMarketCode("&", market)}"),
                this.Token);

            return res.Response.Albums;
        }

        /// <inheritdoc />
        public Paging<SimpleTrack> GetAlbumTracks(SpotifyUri albumUri, int limit = 20, int offset = 0, string market = "")
        {
            Validation.ValidateInteger(limit, 1, 50);

            var res = ApiHelper.GetObjectFromUrl<Paging<SimpleTrack>>(
                ApiHelper.GetUri($"/albums/{albumUri.Id}/tracks?limit={limit}&offset={offset}{AddMarketCode("&", market)}"),
                this.Token);

            return res.Response;
        }
    }
}
