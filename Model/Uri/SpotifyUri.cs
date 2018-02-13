namespace SpotifyWebApi.Model.Uri
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// The <see cref="SpotifyUri" /> class.
    /// </summary>
    [DataContract]
    public class SpotifyUri
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpotifyUri"/> class.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <exception cref="Exception">
        /// Uri was not correct!
        /// or
        /// Uri was not a spotify uri!
        /// </exception>
        public SpotifyUri(string uri)
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
                    Enum.TryParse(split[1], true, out UriType type);
                    this.Type = type;
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
                        this.UserId = split[2];
                        this.Id = split[4];
                        break;
                    default:
                        throw new Exception("Uri was not correct!");
                }
            }
            else
            {
                throw new Exception("Uri was not a spotify uri!");
            }
        }

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
    }
}
