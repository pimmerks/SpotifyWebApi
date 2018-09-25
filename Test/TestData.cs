namespace SpotifyWebApiTest
{
    using System;
    using System.Diagnostics;
    using SpotifyWebApi;
    using SpotifyWebApi.Auth;
    using SpotifyWebApi.Model.Auth;
    using SpotifyWebApi.Model.Enum;
    using Xunit.Abstractions;

    /// <summary>
    /// A class containing some test data used for all tests.
    /// </summary>
    public class TestData
    {
        /// <summary>
        /// An instance of <see cref="Token"/>.
        /// </summary>
        public Token Token { get; }

        /// <summary>
        /// An instance of <see cref="ISpotifyWebApi"/>.
        /// </summary>
        public ISpotifyWebApi Api { get; }

        /// <summary>
        /// Initializes the test data.
        /// </summary>
        public TestData()
        {
            // So to make the tests work, we need to get a Client Id and Secret.
            // I have chosen to save that data in environment variables.
            // Key: 'SpotifyWebApiTestData' Value: 'ClientId:ClientSecret'
            var variables = Environment.GetEnvironmentVariable("SpotifyWebApiTestData")?.Split(':');
            if (variables == null)
            {
                throw new Exception("Did you set the environment variables before testing?");
            }

            var clientId = variables[0];
            var clientSecret = variables[1];

            this.Token = ClientCredentials.GetToken(new AuthParameters
            {
                ClientId = clientId,
                ClientSecret = clientSecret,
                Scopes = Scope.All
            });
            this.Api = new SpotifyWebApi(this.Token);
        }
    }
}