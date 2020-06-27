﻿namespace Spotify.WebApi.Model
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Spotify.WebApi.Model.Exceptions;

    /// <summary>
    /// The Spotify Uri.
    /// </summary>
    public class SpotifyUri
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpotifyUri"/> class.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <exception cref="Exception">
        /// Uri is incorrect.
        /// or
        /// Uri is not a spotify uri.
        /// </exception>
        private SpotifyUri(string uri)
        {
            this.FullUri = uri;

            var split = uri.Split(':');
            if (split.Length != 3)
            {
                throw new SpotifyUriException($"Invalid uri {uri}");
            }

            this.Domain = split[0];
            this.Type = split[1];
            this.Id = split[2];
        }

        /// <summary>
        /// Gets or sets the domain.
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the full URI.
        /// </summary>
        public string FullUri { get; set; }

        /// <summary>
        /// Implicit operator to convert a string to a <see cref="SpotifyUri"/>.
        /// </summary>
        /// <param name="uri">The uri to convert.</param>
        public static implicit operator SpotifyUri(string uri)
        {
            return SpotifyUri.Make(uri);
        }

        /// <summary>
        /// Implicit operator to convert a <see cref="SpotifyUri"/> to a string.
        /// </summary>
        /// <param name="uri">The uri to convert.</param>
        public static implicit operator string(SpotifyUri uri)
        {
            return uri.FullUri;
        }

        /// <summary>
        /// Creates a <see cref="SpotifyUri"/> from the given uri.
        /// </summary>
        /// <param name="uri">The spotify uri.</param>
        /// <returns>A new instance of <see cref="SpotifyUri"/>.</returns>
        public static SpotifyUri Make(string uri)
        {
            if (string.IsNullOrEmpty(uri))
            {
                throw new ArgumentException("Uri is null or empty.");
            }

            return new SpotifyUri(uri);
        }

        /// <summary>
        /// Creates a list of <see cref="SpotifyUri"/>s for the given uris.
        /// </summary>
        /// <param name="uri">A list of uris.</param>
        /// <returns>A list of <see cref="SpotifyUri"/>.</returns>
        public static IList<SpotifyUri> MakeList(params string[] uri)
        {
            return uri.Select(SpotifyUri.Make).ToList();
        }

        /// <inheritdoc />
        public override string ToString() => this.FullUri;
    }
}
