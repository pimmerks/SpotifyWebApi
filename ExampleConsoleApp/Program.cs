﻿namespace ExampleConsoleApp
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
        private readonly IConfiguration configuration;
        private readonly SpotifyAuthentication spotifyAuthentication;

        public Program(IConfiguration configuration, SpotifyAuthentication spotifyAuthentication)
        {
            this.configuration = configuration;
            this.spotifyAuthentication = spotifyAuthentication;
        }

        public async Task Run()
        {
            var token = await this.spotifyAuthentication.GetToken();

            Console.Clear();
            Console.WriteLine("Successfully logged in!");

            // Use the api with access to personal data.
            var api = new SpotifyWebApi(token);
            var me = await api.UserProfile.GetMe();
            
            Console.WriteLine($"Hello {me.DisplayName}");
            
            var playlists = await api.Playlist.GetMyPlaylists();
            Console.WriteLine("Your playlists:");
            Console.WriteLine(string.Join(", ", playlists.Select(x => x.Name)));

            Console.WriteLine();

            var devices = await api.Player.GetAvailableDevices();
            Console.WriteLine("Your devices:");
            foreach (var device in devices)
            {
                Console.Write($"{device.Name}, ");
            }
            
            // Console.WriteLine("Refreshing token...");
            // var newToken = await AuthorizationCode.RefreshTokenAsync(this.parameters, token);
            // Console.WriteLine($"old: {token.AccessToken}");
            // Console.WriteLine($"new: {newToken.AccessToken}");
            //
            // api.SetToken(newToken);
            //
            // me = await api.UserProfile.GetMe();
            //
            // Console.WriteLine($"Hello {me.DisplayName}");

            Console.ReadLine();
        }
    }
}
