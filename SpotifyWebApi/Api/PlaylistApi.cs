using SpotifyWebApi.Model;
using SpotifyWebApi.Model.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyWebApi.Api
{
    public static class PlaylistApi
    {
        public static FullPlaylist GetPlaylist(string playlistId, string userId, Token token)
        {

            //FullPlaylist playlist = null;
            //var json = Api.GetJsonFromUrl("https://api.spotify.com/v1/users/" + userId + "/playlists/" + playlistId, token);
            //playlist = JsonToPlaylist(json);
            //return playlist;
            return null;
        }

        public static FullPlaylist GetPlaylistFromUri(string uri, Token token)
        {
            return null;

        }
    }
}
