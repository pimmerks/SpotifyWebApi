using System;
using System.Runtime.Serialization;

namespace SpotifyWebApi.Model.Uri
{
    [DataContract]
    public class SpotifyUri
    {
        [DataMember]
        public string Domain { get; private set; }

        [DataMember]
        public UriType Type { get; private set; }

        [DataMember]
        public string UserId { get; private set; }

        [DataMember]
        public string Id { get; private set; }

        [DataMember]
        public string FullUri { get; private set; }

        public SpotifyUri(string uri)
        {
            this.FullUri = uri;

            var split = uri.Split(':');
            this.Domain = split[0];

            if (this.Domain.Equals("spotify"))
            {
                if (split.Length == 5)
                    this.Type = UriType.Playlist;
                else
                {
                    UriType type;
                    System.Enum.TryParse(split[1], true, out type);
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
        /// This method is called after the object is completely deserialized. Use it instead of the constructror.
        /// </summary>
        /// <param name="context">The streaming context.</param>
        [OnDeserialized]
        void OnDeserialized(StreamingContext context)
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
