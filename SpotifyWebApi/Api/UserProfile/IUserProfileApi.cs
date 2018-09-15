namespace SpotifyWebApi.Api.UserProfile
{
    using System.Threading.Tasks;
    using Model;
    using Model.Enum;
    using Model.Uri;

    /// <summary>
    /// The user profile api.
    /// </summary>
    public interface IUserProfileApi
    {
        /// <summary>
        /// Get detailed profile information about the current user (including the current user’s username).
        /// </summary>
        /// <returns>A <see cref="PrivateUser"/> object representing the current user.</returns>
        /// <remarks>
        /// A valid access token from the Spotify Accounts service: see the Web API Authorization Guide for details.
        /// The access token must have been issued on behalf of the current user.
        /// Reading the user’s email address requires the <see cref="Scope.UserReadEmail"/> scope;
        /// reading country and product subscription level requires the <see cref="Scope.UserReadPrivate"/> scope.
        /// Reading the user’s birthdate requires the <see cref="Scope.UserReadBirthdate"/> scope.
        /// </remarks>
        Task<PrivateUser> GetMe();

        /// <summary>
        /// Get public profile information about a Spotify user.
        /// </summary>
        /// <param name="userUri">The user’s Spotify user ID.</param>
        /// <returns>The requested user.</returns>
        Task<PublicUser> GetUser(SpotifyUri userUri);
    }
}