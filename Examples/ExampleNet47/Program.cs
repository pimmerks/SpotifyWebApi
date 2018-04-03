namespace Example2
{
    using System;
    using System.Configuration;
    using System.Diagnostics;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading.Tasks;
    using SpotifyWebApi;
    using SpotifyWebApi.Api;
    using SpotifyWebApi.Auth;
    using SpotifyWebApi.Model.Enum;
    using SpotifyWebApi.Model.Uri;

    /// <summary>
    /// Example console application using the SpotifyWebApi
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main entry point.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        public static void Main(string[] args)
        {
            var param = new AuthParameters
            {
                Scopes = Scope.All,

                ClientId = ConfigurationManager.AppSettings["clientId"],
                ClientSecret = ConfigurationManager.AppSettings["clientSecret"],
                RedirectUri = ConfigurationManager.AppSettings["redirectUri"],
                ShowDialog = false, // Set to true to login each time.
            };

            //var url = AuthorizationCode.GetUrl(param, "test");
            //Process.Start(url);
            //var r = GetResponse().GetAwaiter().GetResult();

            //var token = AuthorizationCode.ProcessCallback(param, r, string.Empty);

            var token = ClientCredentials.GetToken(param);

            ISpotifyWebApi api = new SpotifyWebApi(token);

            var task1 = api.UserProfile.GetMe();
            var task2 = api.Player.GetCurrentlyPlayingContext();
            var task3 = api.Playlist.GetMyPlaylists(200);

            Task.WhenAll(task1, task2, task3).GetAwaiter().GetResult();
            var me = task1.Result;
            var t = task2.Result;
            var p = task3.Result;

            Console.WriteLine($"Hello {me.DisplayName}, This is an example application!");
            Console.WriteLine($"You are listening to {t.Item.Name} on {t.Device.Name}");

            foreach (var simplePlaylist in p)
            {
                Console.WriteLine($"{simplePlaylist.Id}, {simplePlaylist.Name}");
            }

            Console.ReadLine();
        }

        /// <summary>
        /// Start a webserver that listens on 8080 and retrieve the access code.
        /// </summary>
        /// <returns>The access code.</returns>
        public static async Task<string> GetResponse()
        {
            var webserver = new TcpListener(IPAddress.Any, 8080);
            webserver.Start();

            var s = await webserver.AcceptSocketAsync();

            var bReceive = new byte[1024];
            int i = s.Receive(bReceive, bReceive.Length, 0);

            // Convert Byte to String
            string sBuffer = Encoding.ASCII.GetString(bReceive);

            s.Shutdown(SocketShutdown.Both);
            webserver.Stop();

            return sBuffer.Split('?')[1].Split('&')[0].Split('=')[1];
        }
    }
}
