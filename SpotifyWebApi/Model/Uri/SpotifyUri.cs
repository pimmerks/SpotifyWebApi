namespace SpotifyWebApi.Model.Uri
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using Exception;

    /// <summary>
    /// The <see cref="SpotifyUri" /> class.
    /// </summary>
    [DataContract]
    public class SpotifyUri
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="SpotifyUri"/> class.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <exception cref="Exception">
        /// Uri was not correct!
        /// or
        /// Uri was not a spotify uri!
        /// </exception>
        private SpotifyUri(string uri)
        {
            this.FullUri = uri;

            var split = uri.Split(':');
            this.Domain = split[0];

            if (this.Domain.Equals("spotify"))
            {
                if (split.Length == 5)
                {
                    this.Type = UriType.Playlist;
                }
                else
                {
                    try
                    {
                        this.Type = (UriType)Enum.Parse(typeof(UriType), split[1], true);
                    }
                    catch (Exception)
                    {
                        throw new InvalidUriException("Uri was not correct!");
                    }
                }

                switch (this.Type)
                {
                    case UriType.User:
                        this.Id = split[2];
                        break;
                    case UriType.Track:
                        this.Id = split[2];
                        break;
                    case UriType.Artist:
                        this.Id = split[2];
                        break;
                    case UriType.Album:
                        this.Id = split[2];
                        break;
                    case UriType.Playlist:
                        this.Id = split[2];
                        break;
                    case UriType.Local:
                        break;
                }
            }
            else
            {
                throw new InvalidUriException($"The provided uri is not a spotify uri (uri: {uri}).");
            }
        }

        #endregion Constructor

        #region Properties

        /// <summary>
        /// Gets the domain.
        /// </summary>
        [DataMember]
        public string Domain { get; private set; }

        /// <summary>
        /// Gets the type.
        /// </summary>
        [DataMember]
        public UriType Type { get; private set; }

        /// <summary>
        /// Gets the user identifier.
        /// </summary>
        [DataMember]
        public string UserId { get; private set; }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        [DataMember]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the full URI.
        /// </summary>
        [DataMember]
        public string FullUri { get; private set; }

        #endregion Properties

        #region Conversion

        /// <summary>
        /// Implicit operator to convert a string to a <see cref="SpotifyUri"/>.
        /// </summary>
        /// <param name="uri">The uri to convert.</param>
        public static implicit operator SpotifyUri(string uri)
        {
            return SpotifyUri.Make(uri);
        }

        #endregion Conversion

        #region Methods

        /// <summary>
        /// Creates a <see cref="SpotifyUri"/> from the given id and type.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="type">The <see cref="UriType"/>.
        /// Note this can not be <see cref="UriType.Playlist"/>, if you want to create a playlist uri use
        /// <see cref="Make(string)"/> or <see cref="Make(string, string)"/></param>
        /// <returns>A new instance of <see cref="SpotifyUri"/>.</returns>
        public static SpotifyUri Make(string id, UriType type)
        {
            if (string.IsNullOrEmpty(id)) throw new ArgumentException("id is null or empty.");

            switch (type)
            {
                case UriType.User:
                    return new SpotifyUri($"spotify:user:{id}");
                case UriType.Track:
                    return new SpotifyUri($"spotify:track:{id}");
                case UriType.Artist:
                    return new SpotifyUri($"spotify:artist:{id}");
                case UriType.Album:
                    return new SpotifyUri($"spotify:album:{id}");
                case UriType.Playlist:
                    throw new NotSupportedException("UriType Playlist is not supported.");
                case UriType.Local:
                    throw new NotSupportedException("UriType Local is not supported.");
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }

        /// <summary>
        /// Creates a playlist <see cref="SpotifyUri"/> from the given uri.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <param name="playlistId">The playlist id.</param>
        /// <returns>A new instance of <see cref="SpotifyUri"/>.
        /// Note: this will always be of <see cref="UriType.Playlist"/>.</returns>
        public static SpotifyUri Make(string userId, string playlistId)
        {
            if (string.IsNullOrEmpty(userId)) throw new ArgumentException("userId is null or empty.");
            if (string.IsNullOrEmpty(playlistId)) throw new ArgumentException("playlistId is null or empty.");

            return new SpotifyUri($"spotify:user:{userId}:playlist:{playlistId}");
        }

        /// <summary>
        /// Creates a <see cref="SpotifyUri"/> from the given uri.
        /// </summary>
        /// <param name="uri">The spotify uri.</param>
        /// <returns>A new instance of <see cref="SpotifyUri"/>.</returns>
        public static SpotifyUri Make(string uri)
        {
            if (string.IsNullOrEmpty(uri)) throw new ArgumentException("uri is null or empty.");
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

        /// <summary>
        /// This method is called after the object is completely deserialized. Use it instead of the constructror.
        /// </summary>
        /// <param name="context">The streaming context.</param>
        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            var i = new SpotifyUri(this.FullUri);
            this.Domain = i.Domain;
            this.FullUri = i.FullUri;
            this.Id = i.Id;
            this.Type = i.Type;
            this.UserId = i.UserId;
        }

        #endregion Methods
    }
}