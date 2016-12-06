using SpotifyWebApi.Model;
using SpotifyWebApi.Model.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyWebApi.Api
{
    public static class AlbumApi
    {
        public static FullAlbum GetAlbum(string uri, Token token)
        {
            var id = uri.Split(':')[2];
            return ApiHelper.GetObjectFromUrl<FullAlbum>("https://api.spotify.com/v1/albums/" + id, token);
        }
    }
}
