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
    public static class PlaylistApi
    {
        public static List<PlaylistTrack> GetPlaylistTracks(SpotifyUri uri, Token token)
        {
            List<PlaylistTrack> tracks = new List<PlaylistTrack>();

            int offset = 0;

            var paging = GetPlaylistTracksPaging(uri, offset, 100, token);

            tracks.AddRange(paging.Items);
            offset = tracks.Count;

            while (paging.Next != null)
            {
                paging = GetPlaylistTracksPaging(uri, offset, 100, token);
                tracks.AddRange(paging.Items);
                offset = tracks.Count;
            }
            
            return tracks;
        }

        public static List<PlaylistTrack> GetMinimalPlaylistTracks(SpotifyUri uri, Token token)
        {
            List<PlaylistTrack> tracks = new List<PlaylistTrack>();

            int offset = 0;

            var fields = "limit,next,offset,previous,total,items(track(id,uri))";

            var paging = GetPlaylistTracksPaging(uri, offset, 100, token, fields);

            tracks.AddRange(paging.Items);
            offset = tracks.Count;

            while (paging.Next != null)
            {
                paging = GetPlaylistTracksPaging(uri, offset, 100, token, fields);
                tracks.AddRange(paging.Items);
                offset = tracks.Count;
            }

            return tracks;
        }

        private static Paging<PlaylistTrack> GetPlaylistTracksPaging(SpotifyUri uri, int offset, int limit, Token token, string fields = "")
        {
            var url = "https://api.spotify.com/v1/users/" + uri.UserId +
                "/playlists/" + uri.Id +
                "/tracks" + 
                (fields != "" ? ("?fields=" + fields + "&") : "?") + 
                "limit=" + limit +
                "&offset=" + offset;


            var json = ApiHelper.GetJsonFromUrl(url, token);

            var paging = ApiHelper.JsonToObject<Paging<PlaylistTrack>>(json);
            return paging;
        }

        public static FullPlaylist GetPlaylistWithoutTracks(SpotifyUri uri, Token token)
        {
            //collaborative,description,external_urls,href,id,images,name,owner,public,type,uri

            FullPlaylist playlist = null;

            var json = ApiHelper.GetJsonFromUrl("https://api.spotify.com/v1/users/" + uri.UserId + "/playlists/" + uri.Id + "?fields=collaborative,description,external_urls,href,id,images,name,owner,public,type,uri", token);

            playlist = ApiHelper.JsonToObject<FullPlaylist>(json);

            return playlist;
        }
    }
}
