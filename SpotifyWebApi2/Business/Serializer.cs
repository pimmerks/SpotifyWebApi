namespace Spotify.WebApi.Business
{
    using System;
    using System.Net.Http;
    using System.Text.Json;
    using System.Threading.Tasks;

    internal static class Serializer
    {
        public static string Serialize<T>(T obj)
        {
            return JsonSerializer.Serialize<T>(obj);
        }

        public static T Deserialize<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json);
        }
    }

    internal static class HttpClientExtensions
    {
        public static async Task<T> GetAsync<T>(this HttpClient client, Uri uri)
        {
            using var response = await client.GetAsync(uri);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();

            return Serializer.Deserialize<T>(json);
        }
    }
}
