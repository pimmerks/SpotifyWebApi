using SpotifyWebApi.Model;
using SpotifyWebApi.Model.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyWebApi.Api
{
    public class TrackApi
    {
        public static FullTrack GetTrack(string id, Token accestoken)
        {
            return ApiHelper.GetObjectFromUrl<FullTrack>("https://api.spotify.com/v1/tracks/" + id, accestoken);
        }

        public static FullTrack GetTrackFromUri(string uri, Token accestoken)
        {
            var id = uri.Split(':')[2];
            return ApiHelper.GetObjectFromUrl<FullTrack>("https://api.spotify.com/v1/tracks/" + id, accestoken);
        }


    }
}
