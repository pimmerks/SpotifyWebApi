using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpotifyWebApi.Auth;
using SpotifyWebApi.Model.Auth;
using SpotifyWebApi.Factory;
using SpotifyWebApi.Api;
using SpotifyWebApi.Model;
using SpotifyWebApi.Model.Uri;

namespace SpotifyWebApi_Example
{
    public partial class SpotifyWebApiExample : Form
    {
        Token _token;
        public SpotifyWebApiExample()
        {
            InitializeComponent();
        }

        private void btn_GetAccessToken_Click(object sender, EventArgs e)
        {
            TokenFactory tokenFactory = new TokenFactory(
                Properties.Settings.Default.ClientId,
                Properties.Settings.Default.ClientSecret,
                TokenMethod.ClientCredentialsAuth);

            _token = tokenFactory.GetToken();

            if(_token.AccessToken != "")
            {
                tabControl1.Enabled = true;
            }

            txtAccesToken.Text = _token.Type + " " + _token.AccessToken;
        }

        private static string ArtistsToStringConverter(List<SimpleArtist> artist)
        {
            var ret = "";
            artist.ForEach(a => ret += a.Name + ", ");
            return ret.Substring(0, ret.Length - 2);
        }

        private void btnGetAlbum_Click(object sender, EventArgs e)
        {
            var album = AlbumApi.GetAlbum(albumUrl.Text, _token);

            listAlbumTracks.Items.Clear();
            album.Tracks.Items.ForEach(item => listAlbumTracks.Items.Add("Disc:" + item.DiscNumber + " Track:" + item.TrackNumber + " " + item.Name + " - " + ArtistsToStringConverter(item.Artists)));

            lblAlbumArtist.Text = "";
            album.Artists.ForEach(item => lblAlbumArtist.Text += item.Name + ", ");
            lblAlbumArtist.Text = lblAlbumArtist.Text.Substring(0, lblAlbumArtist.Text.Length - 2);

            picAlbumImage.Load(album.Images[0].Url);
        }

        private void btnGetTrack_Click(object sender, EventArgs e)
        {
            var track = TrackApi.GetTrack(txtTrackUri.Text, _token);

            picTrack.Load(track.Album.Images[0].Url);

            lblTrackAlbum.Text = track.Album.Name;
            lblTrackArtist.Text = ArtistsToStringConverter(track.Artists);
            lblTrackTitle.Text = track.Name;
        }

        private void btnGetPlaylist_Click(object sender, EventArgs e)
        {
            var playlist = PlaylistApi.GetPlaylistWithoutTracks(new SpotifyUri(txtPlaylistUri.Text), _token);
            playlist.TrackList = PlaylistApi.GetPlaylistTracks(new SpotifyUri(txtPlaylistUri.Text), _token);

            picPlaylist.Load(playlist.Images[0].Url);

            listPlaylistTracks.Items.Clear();
            playlist.TrackList.ForEach(item => {
                if(item.Track != null)
                    listPlaylistTracks.Items.Add(item.Track.Name + " - " + ArtistsToStringConverter(item.Track.Artists));
                });

            lblPlaylistName.Text = playlist.Name;
            lblPlaylistOwner.Text = "ID:" + playlist.Owner.Id + " DisplayName:" + playlist.Owner.DisplayName;
        }
    }
}
