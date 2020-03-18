namespace ExampleConsoleApp
{
    using System;
    using System.Collections.Specialized;
    using System.Diagnostics;
    using System.Linq;
    using System.Net;
    using System.Threading.Tasks;
    using Microsoft.Extensions.Configuration;
    using SpotifyWebApi;
    using SpotifyWebApi.Auth;
    using SpotifyWebApi.Model.Auth;
    using SpotifyWebApi.Model.Enum;

    public class Program
    {
        private string clientSecret;
        private string clientId;
        private string redirectUri;

        public Program(IConfiguration configuration)
        {
            this.clientId = configuration["Spotify:ClientId"];
            this.clientSecret = configuration["Spotify:ClientSecret"];
            this.redirectUri = configuration["Spotify:RedirectUri"];
        }

        public async Task Run()
        {
            var token = await this.GetToken();

            Console.Clear();
            Console.WriteLine("Successfully logged in!");

            // Use the api with access to personal data.
            var api = new SpotifyWebApi(token);
            var me = await api.UserProfile.GetMe();
            
            Console.WriteLine($"Hello {me.DisplayName}");
            
            var playlists = await api.Playlist.GetMyPlaylists();
            Console.WriteLine("Your playlists:");
            foreach (var simplePlaylist in playlists)
            {
                Console.Write($"{simplePlaylist.Name}, ");
            }

            Console.WriteLine();
            Console.WriteLine();

            var devices = await api.Player.GetAvailableDevices();
            Console.WriteLine("Your devices:");
            foreach (var device in devices)
            {
                Console.Write($"{device.Name}, ");
            }
            
            Console.ReadLine();
        }

        public async Task<Token> GetToken()
        {
            var state = Guid.NewGuid().ToString(); // Save this state because you must check it later

            var parameters = new AuthParameters
            {
                ClientId = this.clientId,
                ClientSecret = this.clientSecret,
                RedirectUri = this.redirectUri,
                Scopes = Scopes.All,
                ShowDialog = true
            };

            var url = AuthorizationCode.GetUrl(parameters, state);
            
            Console.WriteLine("Opening url...");
            Console.WriteLine(url);
            
            var ps = new ProcessStartInfo(url)
            { 
                UseShellExecute = true, 
                Verb = "open" 
            };
            Process.Start(ps);
            
            var queryString = await this.StartServerAndRetrieveAuthCode();

            // The retrieved callback:
            var retrievedState = queryString["state"];
            var retrievedCode = queryString["code"];
            var retrievedError = queryString["error"];

            if (retrievedError != null)
            {
                throw new Exception(retrievedError);
            }

            if (state != retrievedState)
            {
                throw new Exception("State did not match!");
            }

            var token = await AuthorizationCode.ProcessCallbackAsync(parameters, retrievedCode);

            return token;
        }

        public async Task<NameValueCollection> StartServerAndRetrieveAuthCode(string url = "http://localhost:8080/")
        {
            var listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:8080/");
            listener.Start();

            var context = await listener.GetContextAsync();

            listener.Stop();

            return context.Request.QueryString;
        }
    }
}