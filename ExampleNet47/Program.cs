namespace Example2
{
    using System;
    using System.Configuration;
    using System.Diagnostics;
    using System.Linq;
    using System.Net;
    using System.Net.Sockets;
    using System.Text;
    using System.Threading.Tasks;
    using SpotifyWebApi;
    using SpotifyWebApi.Api;
    using SpotifyWebApi.Auth;
    using SpotifyWebApi.Auth.AuthorizationCode;
    using SpotifyWebApi.Model.Enum;
    using SpotifyWebApi.Model.Uri;

    /// <summary>
    /// TODO
    /// </summary>
    public class Program
    {
        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="args">TODO</param>
        /// <returns>TODO</returns>
        public static void Main(string[] args)
        {
            var param = new AuthParameters
            {
                Scopes = Scope.All,

                ClientId = ConfigurationManager.AppSettings["clientId"],
                ClientSecret = ConfigurationManager.AppSettings["clientSecret"],
                RedirectUri = ConfigurationManager.AppSettings["redirectUri"],
                ShowDialog = true,
            };

            var url = AuthorizationCode.GetUrl(param, "test");
            Process.Start(url);
            var r = GetResponse().GetAwaiter().GetResult();

            var token = AuthorizationCode.ProcessCallback(param, r, string.Empty);

            ISpotifyWebApi api = new SpotifyWebApi(token);

            var task1 = api.UserProfile.GetMe();
            var task2 = api.Player.GetCurrentlyPlayingContextAsync();

            task1.Wait();
            var me = task1.Result;
            task2.Wait();
            var t = task2.Result;

            var task3 = api.Artist.GetArtistAlbums(new SpotifyUri(t.Item.Artists.First().Uri));
            task3.Wait();

            Console.WriteLine($"Hello {me.DisplayName}, This is an example application!");
            Console.WriteLine($"You are listening to {t.Item.Name} on {t.Device.Name}");

            foreach (var simpleAlbum in task3.Result)
            {
                Console.WriteLine(simpleAlbum.Name);
            }

            Console.ReadLine();
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <returns>TODO</returns>
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
