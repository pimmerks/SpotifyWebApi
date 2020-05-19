namespace Spotify.WebApi.Business
{
    using System.Text.Json;

    internal static class Serializer
    {
        public static string Serialize<T>(T obj)
        {
            return JsonSerializer.Serialize<T>(obj);
        }

        public static T Deserialize<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json, new JsonSerializerOptions
            {
                IgnoreNullValues = true
            });
        }
    }
}
