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
        /// An instance of a <see cref="Token"/> without access to personal information.
        /// </summary>
        public Token ClientCredentialsToken { get; }

        /// <summary>
        /// An instance of a <see cref="Token"/> with access to personal information.
        /// </summary>
        public Token PersonalToken { get; }

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

            this.ClientCredentialsToken = this.GetClientCredentialsToken(clientId, clientSecret);
            // this.PersonalToken = this.GetImplicitGrantToken(clientId);
        }

        private Token GetClientCredentialsToken(string clientId, string clientSecret)
        {
            return ClientCredentials.GetToken(new AuthParameters
            {
                ClientId = clientId,
                ClientSecret = clientSecret,
                Scopes = Scopes.All
            });
        }

        private Token GetImplicitGrantToken(string clientId)
        {
            throw new NotImplementedException();
        }
    }
}