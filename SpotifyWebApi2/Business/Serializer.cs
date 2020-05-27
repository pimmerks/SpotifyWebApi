namespace Spotify.WebApi.Business
{
    using System.Text.Json;

    /// <summary>
    /// Serializer for serializing JSON to any object.
    /// </summary>
    public class Serializer
    {
        private JsonSerializerOptions options;

        /// <summary>
        /// Initializes a new instance of the <see cref="Serializer"/> class.
        /// </summary>
        public Serializer()
        {
            this.options = new JsonSerializerOptions();
            this.options.Converters.Add(new SpotifyUriConverter());
        }

        /// <summary>
        /// Serializes an object to a json string.
        /// </summary>
        /// <param name="obj">The object to serialize.</param>
        /// <typeparam name="T">The type.</typeparam>
        /// <returns>A json string.</returns>
        public string Serialize<T>(T obj)
        {
            return JsonSerializer.Serialize<T>(obj, this.options);
        }

        /// <summary>
        /// Deserializes a json string to an object.
        /// </summary>
        /// <param name="json">The json to deserialize.</param>
        /// <typeparam name="T">The object type.</typeparam>
        /// <returns>The newly created object.</returns>
        public T Deserialize<T>(string json)
        {
            return JsonSerializer.Deserialize<T>(json, this.options);
        }
    }
}
