using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Example
{
    using System.Configuration;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using SpotifyWebApi;
    using SpotifyWebApi.Auth;
    using SpotifyWebApi.Auth.AuthorizationCode;
    using SpotifyWebApi.Model.Enum;

    class Program
    {
        static async Task Main(string[] args)
        {
            var param = new AuthParameters
            {
                Scopes = Scope.UserReadPrivate | Scope.UserReadEmail | Scope.UserReadBirthdate | Scope.UserReadCurrentlyPlaying |
                Scope.UserTopRead | Scope.UserLibraryRead,

                ClientId = ConfigurationManager.AppSettings["clientId"],
                ClientSecret = ConfigurationManager.AppSettings["clientSecret"],
                RedirectUri = ConfigurationManager.AppSettings["redirectUri"],
                ShowDialog = true,
            };

            Process.Start(AuthorizationCode.GetUrl(param, "test"));
            var r = await GetResponse();

            var token = AuthorizationCode.ProcessCallback(param, r, "");

            ISpotifyWebApi api = new SpotifyWebApi(token);

            var me = api.UserProfile.GetMe();

            Console.WriteLine($"Hello {me.DisplayName}, This is an example application!");

            Console.ReadLine();
        }

        static async Task<string> GetResponse()
        {
            var webserver = new TcpListener(IPAddress.Any, 8080);
            webserver.Start();

            var s = await webserver.AcceptSocketAsync();

            var bReceive = new Byte[1024];
            int i = s.Receive(bReceive, bReceive.Length, 0);

            //Convert Byte to String
            string sBuffer = Encoding.ASCII.GetString(bReceive);

            s.Shutdown(SocketShutdown.Both);
            webserver.Stop();

            return sBuffer.Split('?')[1].Split('&')[0].Split('=')[1];
        }
    }
}
