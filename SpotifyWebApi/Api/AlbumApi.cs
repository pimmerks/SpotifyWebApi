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
    public static class AlbumApi
    {
        public static FullAlbum GetAlbum(string uri, Token token)
        {
            var spotifyUri = new SpotifyUri(uri);
            return GetAlbum(spotifyUri, token);
        }

        public static FullAlbum GetAlbum(SpotifyUri uri, Token token)
        {
            return ApiHelper.GetObjectFromUrl<FullAlbum>("https://api.spotify.com/v1/albums/" + uri.Id, token);
        }
    }
}
