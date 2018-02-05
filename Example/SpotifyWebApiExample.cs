namespace Example
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using SpotifyWebApi.Api;
    using SpotifyWebApi.Factory;
    using SpotifyWebApi.Model;
    using SpotifyWebApi.Model.Auth;
    using SpotifyWebApi.Model.Uri;

    public partial class SpotifyWebApiExample : Form
    {
        Token token;
        public SpotifyWebApiExample()
        {
            this.InitializeComponent();
        }

        private void Btn_GetAccessToken_Click(object sender, EventArgs e)
        {
            TokenFactory tokenFactory = new TokenFactory(
                Properties.Settings.Default.ClientId,
                Properties.Settings.Default.ClientSecret,
                TokenMethod.ClientCredentialsAuth);

            this.token = tokenFactory.GetToken();

            if(this.token.AccessToken != "")
            {
                this.tabControl1.Enabled = true;
            }

            this.txtAccesToken.Text = this.token.Type + " " + this.token.AccessToken;
        }

        private static string ArtistsToStringConverter(List<SimpleArtist> artist)
        {
            var ret = "";
            artist.ForEach(a => ret += a.Name + ", ");
            return ret.Substring(0, ret.Length - 2);
        }

        private void BtnGetAlbum_Click(object sender, EventArgs e)
        {
            var album = AlbumApi.GetAlbum(this.albumUrl.Text, this.token);

            this.listAlbumTracks.Items.Clear();
            album.Tracks.Items.ForEach(item => this.listAlbumTracks.Items.Add("Disc:" + item.DiscNumber + " Track:" + item.TrackNumber + " " + item.Name + " - " + ArtistsToStringConverter(item.Artists)));

            this.lblAlbumArtist.Text = "";
            album.Artists.ForEach(item => this.lblAlbumArtist.Text += item.Name + ", ");
            this.lblAlbumArtist.Text = this.lblAlbumArtist.Text.Substring(0, this.lblAlbumArtist.Text.Length - 2);

            this.picAlbumImage.Load(album.Images[0].Url);
        }

        private void BtnGetTrack_Click(object sender, EventArgs e)
        {
            var track = TrackApi.GetTrack(this.txtTrackUri.Text, this.token);

            this.picTrack.Load(track.Album.Images[0].Url);

            this.lblTrackAlbum.Text = track.Album.Name;
            this.lblTrackArtist.Text = ArtistsToStringConverter(track.Artists);
            this.lblTrackTitle.Text = track.Name;
        }

        private void BtnGetPlaylist_Click(object sender, EventArgs e)
        {
            var playlist = PlaylistApi.GetPlaylistWithoutTracks(new SpotifyUri(this.txtPlaylistUri.Text), this.token);
            playlist.TrackList = PlaylistApi.GetPlaylistTracks(new SpotifyUri(this.txtPlaylistUri.Text), this.token);

            this.picPlaylist.Load(playlist.Images[0].Url);

            this.listPlaylistTracks.Items.Clear();
            playlist.TrackList.ForEach(item => {
                if(item.Track != null)
                    this.listPlaylistTracks.Items.Add(item.Track.Name + " - " + ArtistsToStringConverter(item.Track.Artists));
                });

            this.lblPlaylistName.Text = playlist.Name;
            this.lblPlaylistOwner.Text = "ID:" + playlist.Owner.Id + " DisplayName:" + playlist.Owner.DisplayName;
        }
    }
}
