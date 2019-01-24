namespace Spotify.Api.Browse
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Model;

    /// <summary>
    /// The browse api interface.
    /// </summary>
    public interface IBrowseApi
    {
        /// <summary>
        /// Get a list of Spotify featured playlists (shown, for example, on a Spotify player’s ‘Browse’ tab).
        /// </summary>
        /// <param name="locale">
        /// Optional. The desired language, consisting of a lowercase ISO 639-1 language code and an uppercase ISO 3166-1 alpha-2 country code, joined by an underscore.
        /// For example: es_MX, meaning “Spanish (Mexico)”. Provide this parameter if you want the results returned in a particular language (where available).
        /// Note that, if locale is not supplied, or if the specified language is not available, all strings will be returned in the Spotify default language (American English).
        /// The locale parameter, combined with the country parameter, may give odd results if not carefully matched.
        /// For example country=SE&amp;locale=de_DE will return a list of categories relevant to Sweden but as German language strings.
        /// </param>
        /// <param name="country">
        /// Optional. A country: an ISO 3166-1 alpha-2 country code. Provide this parameter if you want the list of returned items to be relevant to a particular country. If omitted, the returned items will be relevant to all countries.
        /// </param>
        /// <param name="timeStamp">
        /// Optional. Use this parameter to specify the user’s local time to get results tailored for that specific date and time in the day. If not provided, the response defaults to the current UTC time. Example: “2014-10-23T09:00:00” for a user whose local time is 9AM. If there were no featured playlists (or there is no data) at the specified time, the response will revert to the current UTC time.
        /// </param>
        /// <param name="maxResults">Optional. The maximum results to return, or -1 to retrieve all items.</param>
        /// <param name="offset">
        /// Optional. The index of the first item to return. Default: 0 (the first object). Use with limit to get the next set of items.
        /// </param>
        /// <returns>
        /// A <see cref="string"/> and a list of <see cref="SimplePlaylist"/> objects.
        /// The <see cref="string"/> conveys a message like "Monday morning music, coming right up!".
        /// </returns>
#pragma warning disable SA1009 // Closing parenthesis must be spaced correctly
        Task<(string Message, IList<SimplePlaylist> Playlists)> GetFeaturedPlaylists(
            string locale = null,
            string country = null,
            DateTime? timeStamp = null,
            int maxResults = -1,
            int offset = 0);
#pragma warning restore SA1009 // Closing parenthesis must be spaced correctly
    }
}