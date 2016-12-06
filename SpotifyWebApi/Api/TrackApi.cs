using SpotifyWebApi.Model;
using SpotifyWebApi.Model.Auth;
using SpotifyWebApi.Model.Uri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyWebApi.Api
{
    public static class TrackApi
    {
        public static FullTrack GetTrack(string uri, Token token)
        {
            SpotifyUri su = new SpotifyUri(uri);
            return GetTrack(su, token);
        }

        public static FullTrack GetTrack(SpotifyUri uri, Token token)
        {
            if (uri.Type == UriType.track)
                return ApiHelper.GetObjectFromUrl<FullTrack>("https://api.spotify.com/v1/tracks/" + uri.Id, token);
            else
                return null;
        }


    }
}
