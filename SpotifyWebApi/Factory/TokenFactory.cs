using SpotifyWebApi.Auth;
using SpotifyWebApi.Model.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyWebApi.Factory
{
    public class TokenFactory
    {
        public string ClientId { get; private set; }
        public string ClientSecret { get; private set; }
        public TokenMethod Method { get; private set; }

        public TokenFactory(string clientId, string clientSecret, TokenMethod method)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
            Method = method;
        }
        
        public Token GetToken()
        {
            switch (Method)
            {
                case TokenMethod.ClientCredentialsAuth:
                    return ClientCredentialsAuth.RequestToken(ClientId, ClientSecret);
                default:
                    return null;
            }
        }
    }
}
