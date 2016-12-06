using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyWebApi.Model.Uri
{
    public class SpotifyUri
    {
        public string Domain { get; private set; }

        public UriType Type { get; private set; }

        public string User { get; private set; }

        public string Id { get; private set; }

        public string FullUri { get; private set; }

        public SpotifyUri(string uri)
        {
            FullUri = uri;

            var split = uri.Split(':');
            Domain = split[0];

            if (Domain.Equals("spotify"))
            {
                if (split.Length == 5)
                    Type = UriType.playlist;
                else
                {
                    UriType type;
                    Enum.TryParse(split[1], true, out type);
                    Type = type;
                }
                
                switch (Type)
                {
                    case UriType.user:
                        Id = split[2];
                        break;
                    case UriType.track:
                        Id = split[2];
                        break;
                    case UriType.artist:
                        Id = split[2];
                        break;
                    case UriType.album:
                        Id = split[2];
                        break;
                    case UriType.playlist:
                        User = split[2];
                        Id = split[4];
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
    }
}
