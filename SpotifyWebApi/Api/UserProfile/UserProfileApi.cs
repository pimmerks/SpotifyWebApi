namespace SpotifyWebApi.Api.UserProfile
{
    using System.Net.Http;
    using System.Threading.Tasks;
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
        /// <param name="httpClient">The <see cref="HttpClient"/> to be used for every request.</param>
        public UserProfileApi(Token token, HttpClient httpClient)
            : base(token, httpClient)
        {
        }

        /// <inheritdoc />
        public async Task<PrivateUser> GetMe()
        {
            var r = await ApiClient.GetAsync<PrivateUser>(
                          MakeUri("me"), this.Token);

            if (r.Response is PrivateUser res)
            {
                return res;
            }
            return new PrivateUser();
        }

        /// <inheritdoc />
        public async Task<PublicUser> GetUser(SpotifyUri userUri)
        {
            var r = await ApiClient.GetAsync<PublicUser>(
                        MakeUri($"users/{userUri.Id}"), this.Token);

            if (r.Response is PublicUser res)
            {
                return res;
            }
            return new PublicUser();
        }
    }
}
