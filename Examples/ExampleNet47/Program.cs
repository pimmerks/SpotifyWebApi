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
            // First, lets create our auth parameters.
            var param = new AuthParameters
            {
                Scopes = Scope.All,

                ClientId = ConfigurationManager.AppSettings["clientId"],
                ClientSecret = ConfigurationManager.AppSettings["clientSecret"],
                RedirectUri = ConfigurationManager.AppSettings["redirectUri"],
                ShowDialog = false, // Set to true to login each time.
            };

            // Get the auth url, and start to process in the default web browser.
            var url = AuthorizationCode.GetUrl(param, "test");
            Process.Start(url);

            // Listen on our callback site for a response.
            var r = GetResponse().GetAwaiter().GetResult();

            // Use authorization code to get a token.
            var token = AuthorizationCode.ProcessCallback(param, r, string.Empty);

            // Once we have a token, create an api.
            var api = new SpotifyWebApi(token);

            // All API's return task's and are all async.
            var task1 = api.UserProfile.GetMe();
            var task2 = api.Player.GetCurrentlyPlayingContext();
            var task3 = api.Playlist.GetMyPlaylists(200);
            var task4 = api.Player.GetAvailableDevices();

            Task.WhenAll(task1, task2, task3, task4).GetAwaiter().GetResult();
            var me = task1.Result;
            var t = task2.Result;
            var p = task3.Result;
            var d = task4.Result;

            Console.WriteLine($"Hello {me.DisplayName}, This is an example application!");
            Console.WriteLine($"You are listening to {t.Item.Name} on {t.Device.Name}");
            Console.Write("Available devices: ");
            foreach (var device in d)
            {
                Console.Write($"{device.Name}");
            }
            Console.WriteLine();

            Console.WriteLine("Your playlists:");
            foreach (var simplePlaylist in p)
            {
                Console.WriteLine($"{simplePlaylist.Id}, {simplePlaylist.Name}");
            }

            Console.ReadLine();

            // Lets try to refresh our token.
            Console.WriteLine($"Old token: {token.AccessToken}");
            token = AuthorizationCode.RefreshToken(param, token);
            Console.WriteLine($"New token: {token.AccessToken}");

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
