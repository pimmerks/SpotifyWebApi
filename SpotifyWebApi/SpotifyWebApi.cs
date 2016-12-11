using SpotifyWebApi.Factory;
using SpotifyWebApi.Model.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyWebApi
{
    public class SpotifyWebApi
    {
        public Token Token { get; private set; }
        
        public SpotifyWebApi()
        {

        }

        /// <summary>
        /// Sets the Token for all further communication with the Spotify Api
        /// </summary>
        /// <param name="factory">The initialized TokenFactory</param>
        /// <returns></returns>
        public bool GetToken(TokenFactory factory)
        {
            var token = factory.GetToken();

            if (token == null)
                return false;

            Token = token;
            return true;
        }
    }
}
