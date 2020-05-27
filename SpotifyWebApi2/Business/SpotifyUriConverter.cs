namespace Spotify.WebApi.Business
{
    using System;
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using Spotify.WebApi.Model;

    /// <inheritdoc />
    internal class SpotifyUriConverter : JsonConverter<SpotifyUri>
    {
        /// <inheritdoc/>
        public override SpotifyUri Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.String)
            {
                return SpotifyUri.Make(reader.GetString());
            }

            throw new JsonException("Could not deserialize Spotify Uri.");
        }

        /// <inheritdoc/>
        public override void Write(Utf8JsonWriter writer, SpotifyUri value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.FullUri);
        }
    }
}
