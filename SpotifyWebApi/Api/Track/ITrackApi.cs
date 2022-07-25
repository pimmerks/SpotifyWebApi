namespace SpotifyWebApi.Api.Track
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Model;
    using Model.Uri;

    /// <summary>
    /// The track api.
    /// </summary>
    public interface ITrackApi
    {
        /// <summary>
        /// Get Spotify catalog information for a single track identified by its <see cref="SpotifyUri"/>
        /// </summary>
        /// <param name="uri">The <see cref="SpotifyUri"/> for the track.</param>
        /// <param name="market">Optional. An ISO 3166-1 alpha-2 country code. Provide this parameter if you want to apply Track Relinking.</param>
        /// <returns>A <see cref="FullTrack"/> object.</returns>
        Task<FullTrack> GetTrack(SpotifyUri uri, string market = null);

        /// <summary>
        /// Get Spotify catalog information for multiple tracks based on their <see cref="SpotifyUri"/>s.
        /// </summary>
        /// <param name="uris">A list of <see cref="SpotifyUri"/>s. Note a maximum of 50 tracks is allowed.</param>
        /// <param name="market">Optional. An ISO 3166-1 alpha-2 country code. Provide this parameter if you want to apply Track Relinking.</param>
        /// <returns>A list of <see cref="FullTrack"/> objects.</returns>
        Task<IList<FullTrack>> GetTracks(IList<SpotifyUri> uris, string market = null);
    }
}