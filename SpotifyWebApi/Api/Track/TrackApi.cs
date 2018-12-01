// <copyright file="TrackApi.cs" company="companyPlaceholder">
// Copyright (c) companyPlaceholder. All rights reserved.
// </copyright>

namespace SpotifyWebApi.Api.Track
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Text;
    using System.Threading.Tasks;
    using Business;
    using Model;
    using Model.Auth;
    using Model.Uri;

    /// <summary>
    /// The <see cref="TrackApi"/>.
    /// </summary>
    public class TrackApi : BaseApi, ITrackApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackApi"/> class.
        /// </summary>
        /// <param name="token">A valid access token.</param>
        /// <param name="httpClient">The <see cref="HttpClient"/> to be used for every request.</param>
        public TrackApi(Token token, HttpClient httpClient)
            : base(token, httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<FullTrack> GetTrack(SpotifyUri uri, string market)
        {
            var r = await ApiClient.GetAsync<FullTrack>(
                        MakeUri(
                            $"tracks/{uri.Id}",
                            ("market", market)),
                        this.Token);

            if (r.Response is FullTrack res)
            {
                return res;
            }
            return new FullTrack();
        }

        /// <inheritdoc />
        public async Task<IList<FullTrack>> GetTracks(IList<SpotifyUri> uris, string market)
        {
            Validation.ValidateList(uris, 1, 50);
            var r = await ApiClient.GetAsync<List<FullTrack>>(
                        MakeUri(
                            $"tracks",
                            ("ids", string.Join(",", uris.Select(x => x.Id))),
                            ("market", market)),
                        this.Token);

            if (r.Response is List<FullTrack> res)
            {
                return res;
            }
            return new List<FullTrack>();
        }
    }
}
