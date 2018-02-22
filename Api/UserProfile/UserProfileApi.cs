namespace SpotifyWebApi.Api.UserProfile
{
    using System;
    using Business;
    using Model;
    using Model.Auth;
    using Model.Uri;

    /// <inheritdoc cref="BaseApi"/>
    /// <summary>
    /// The <see cref="UserProfileApi"/>.
    /// </summary>
    public class UserProfileApi : BaseApi, IUserProfileApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserProfileApi"/> class.
        /// </summary>
        /// <param name="token">A valid <see cref="Token"/>.</param>
        public UserProfileApi(Token token)
            : base(token)
        {
        }

        /// <inheritdoc />
        public PrivateUser GetMe()
        {
            var res = ApiHelper.GetObjectFromUrl<PrivateUser>(
                ApiHelper.GetUri($"/me"),
                this.Token);

            throw new NotImplementedException(); // return res.Response;
        }

        /// <inheritdoc />
        public PublicUser GetUser(SpotifyUri userUri)
        {
            throw new NotImplementedException();
        }
    }
}
