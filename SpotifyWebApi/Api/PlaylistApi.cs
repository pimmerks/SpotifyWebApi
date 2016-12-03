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

            FullPlaylist playlist = null;

            var json = ApiHelper.GetJsonFromUrl("https://api.spotify.com/v1/users/" + userId + "/playlists/" + playlistId, token);
            
            playlist = ApiHelper.JsonToObject<FullPlaylist>(json);
            
            return playlist;
        }

        public static List<PlaylistTrack> GetPlaylistTracks(string playlistId, string userId, Token token)
        {
            //https://api.spotify.com/v1/users/{user_id}/playlists/{playlist_id}/tracks

            List<PlaylistTrack> tracks = null;

            int offset = 0;

            var json = ApiHelper.GetJsonFromUrl("https://api.spotify.com/v1/users/" + userId + "/playlists/" + playlistId + "/tracks&limit=100&offset=" + offset, token);

            var paging = ApiHelper.JsonToObject<Paging<PlaylistTrack>>(json);


            while(paging.Next != null)
            {
                tracks.AddRange(paging.Items);
                //TODO:
                offset += paging.Limit;
            }



            return tracks;
        }

        public static FullPlaylist GetPlaylistFromUri(string uri, Token token)
        {
            return null;

        }
    }
}
