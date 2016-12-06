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
    }
}
