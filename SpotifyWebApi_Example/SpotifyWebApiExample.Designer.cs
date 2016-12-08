namespace SpotifyWebApi_Example
{
    partial class SpotifyWebApiExample
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_GetAccessToken = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblAlbumArtist = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listAlbumTracks = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picAlbumImage = new System.Windows.Forms.PictureBox();
            this.btnGetAlbum = new System.Windows.Forms.Button();
            this.albumUrl = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTrackAlbum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTrackArtist = new System.Windows.Forms.Label();
            this.lblTrackTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.picTrack = new System.Windows.Forms.PictureBox();
            this.btnGetTrack = new System.Windows.Forms.Button();
            this.txtTrackUri = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.txtPlaylistUri = new System.Windows.Forms.TextBox();
            this.btnGetPlaylist = new System.Windows.Forms.Button();
            this.picPlaylist = new System.Windows.Forms.PictureBox();
            this.listPlaylistTracks = new System.Windows.Forms.ListBox();
            this.txtAccesToken = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPlaylistName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblPlaylistOwner = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbumImage)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTrack)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlaylist)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_GetAccessToken
            // 
            this.btn_GetAccessToken.Location = new System.Drawing.Point(12, 12);
            this.btn_GetAccessToken.Name = "btn_GetAccessToken";
            this.btn_GetAccessToken.Size = new System.Drawing.Size(134, 23);
            this.btn_GetAccessToken.TabIndex = 0;
            this.btn_GetAccessToken.Text = "Get Access token";
            this.btn_GetAccessToken.UseVisualStyleBackColor = true;
            this.btn_GetAccessToken.Click += new System.EventHandler(this.btn_GetAccessToken_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(1, 41);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1090, 511);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblAlbumArtist);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.listAlbumTracks);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.picAlbumImage);
            this.tabPage1.Controls.Add(this.btnGetAlbum);
            this.tabPage1.Controls.Add(this.albumUrl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1082, 485);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Album";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblAlbumArtist
            // 
            this.lblAlbumArtist.AutoSize = true;
            this.lblAlbumArtist.Location = new System.Drawing.Point(320, 7);
            this.lblAlbumArtist.Name = "lblAlbumArtist";
            this.lblAlbumArtist.Size = new System.Drawing.Size(61, 13);
            this.lblAlbumArtist.TabIndex = 7;
            this.lblAlbumArtist.Text = "Artist Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Artist:";
            // 
            // listAlbumTracks
            // 
            this.listAlbumTracks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listAlbumTracks.FormattingEnabled = true;
            this.listAlbumTracks.Items.AddRange(new object[] {
            "track 1",
            "track 2"});
            this.listAlbumTracks.Location = new System.Drawing.Point(323, 47);
            this.listAlbumTracks.Name = "listAlbumTracks";
            this.listAlbumTracks.Size = new System.Drawing.Size(751, 433);
            this.listAlbumTracks.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tracks:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Image:";
            // 
            // picAlbumImage
            // 
            this.picAlbumImage.BackColor = System.Drawing.Color.Gainsboro;
            this.picAlbumImage.Location = new System.Drawing.Point(3, 47);
            this.picAlbumImage.Name = "picAlbumImage";
            this.picAlbumImage.Size = new System.Drawing.Size(314, 314);
            this.picAlbumImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAlbumImage.TabIndex = 2;
            this.picAlbumImage.TabStop = false;
            // 
            // btnGetAlbum
            // 
            this.btnGetAlbum.Location = new System.Drawing.Point(199, 6);
            this.btnGetAlbum.Name = "btnGetAlbum";
            this.btnGetAlbum.Size = new System.Drawing.Size(75, 23);
            this.btnGetAlbum.TabIndex = 1;
            this.btnGetAlbum.Text = "GetAlbum";
            this.btnGetAlbum.UseVisualStyleBackColor = true;
            this.btnGetAlbum.Click += new System.EventHandler(this.btnGetAlbum_Click);
            // 
            // albumUrl
            // 
            this.albumUrl.Location = new System.Drawing.Point(3, 8);
            this.albumUrl.Name = "albumUrl";
            this.albumUrl.Size = new System.Drawing.Size(190, 20);
            this.albumUrl.TabIndex = 0;
            this.albumUrl.Text = "spotify uri";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblTrackAlbum);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.lblTrackArtist);
            this.tabPage2.Controls.Add(this.lblTrackTitle);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.picTrack);
            this.tabPage2.Controls.Add(this.btnGetTrack);
            this.tabPage2.Controls.Add(this.txtTrackUri);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1082, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Track";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblTrackAlbum
            // 
            this.lblTrackAlbum.AutoSize = true;
            this.lblTrackAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackAlbum.Location = new System.Drawing.Point(80, 79);
            this.lblTrackAlbum.Name = "lblTrackAlbum";
            this.lblTrackAlbum.Size = new System.Drawing.Size(70, 25);
            this.lblTrackAlbum.TabIndex = 9;
            this.lblTrackAlbum.Text = "album";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Album:";
            // 
            // lblTrackArtist
            // 
            this.lblTrackArtist.AutoSize = true;
            this.lblTrackArtist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackArtist.Location = new System.Drawing.Point(80, 54);
            this.lblTrackArtist.Name = "lblTrackArtist";
            this.lblTrackArtist.Size = new System.Drawing.Size(70, 25);
            this.lblTrackArtist.TabIndex = 7;
            this.lblTrackArtist.Text = "artists";
            // 
            // lblTrackTitle
            // 
            this.lblTrackTitle.AutoSize = true;
            this.lblTrackTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackTitle.Location = new System.Drawing.Point(80, 29);
            this.lblTrackTitle.Name = "lblTrackTitle";
            this.lblTrackTitle.Size = new System.Drawing.Size(46, 25);
            this.lblTrackTitle.TabIndex = 6;
            this.lblTrackTitle.Text = "title";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Artists";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Title:";
            // 
            // picTrack
            // 
            this.picTrack.BackColor = System.Drawing.Color.Gainsboro;
            this.picTrack.Location = new System.Drawing.Point(604, 6);
            this.picTrack.Name = "picTrack";
            this.picTrack.Size = new System.Drawing.Size(470, 470);
            this.picTrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTrack.TabIndex = 3;
            this.picTrack.TabStop = false;
            // 
            // btnGetTrack
            // 
            this.btnGetTrack.Location = new System.Drawing.Point(198, 4);
            this.btnGetTrack.Name = "btnGetTrack";
            this.btnGetTrack.Size = new System.Drawing.Size(75, 23);
            this.btnGetTrack.TabIndex = 1;
            this.btnGetTrack.Text = "Get Track";
            this.btnGetTrack.UseVisualStyleBackColor = true;
            this.btnGetTrack.Click += new System.EventHandler(this.btnGetTrack_Click);
            // 
            // txtTrackUri
            // 
            this.txtTrackUri.Location = new System.Drawing.Point(7, 6);
            this.txtTrackUri.Name = "txtTrackUri";
            this.txtTrackUri.Size = new System.Drawing.Size(185, 20);
            this.txtTrackUri.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1082, 485);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Artist";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lblPlaylistOwner);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.lblPlaylistName);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.listPlaylistTracks);
            this.tabPage4.Controls.Add(this.picPlaylist);
            this.tabPage4.Controls.Add(this.btnGetPlaylist);
            this.tabPage4.Controls.Add(this.txtPlaylistUri);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1082, 485);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Playlist";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtPlaylistUri
            // 
            this.txtPlaylistUri.Location = new System.Drawing.Point(7, 12);
            this.txtPlaylistUri.Name = "txtPlaylistUri";
            this.txtPlaylistUri.Size = new System.Drawing.Size(190, 20);
            this.txtPlaylistUri.TabIndex = 0;
            // 
            // btnGetPlaylist
            // 
            this.btnGetPlaylist.Location = new System.Drawing.Point(203, 10);
            this.btnGetPlaylist.Name = "btnGetPlaylist";
            this.btnGetPlaylist.Size = new System.Drawing.Size(75, 23);
            this.btnGetPlaylist.TabIndex = 1;
            this.btnGetPlaylist.Text = "Get Playlist";
            this.btnGetPlaylist.UseVisualStyleBackColor = true;
            this.btnGetPlaylist.Click += new System.EventHandler(this.btnGetPlaylist_Click);
            // 
            // picPlaylist
            // 
            this.picPlaylist.Location = new System.Drawing.Point(7, 204);
            this.picPlaylist.Name = "picPlaylist";
            this.picPlaylist.Size = new System.Drawing.Size(271, 271);
            this.picPlaylist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlaylist.TabIndex = 2;
            this.picPlaylist.TabStop = false;
            // 
            // listPlaylistTracks
            // 
            this.listPlaylistTracks.FormattingEnabled = true;
            this.listPlaylistTracks.Items.AddRange(new object[] {
            "item1",
            "item2"});
            this.listPlaylistTracks.Location = new System.Drawing.Point(284, 3);
            this.listPlaylistTracks.Name = "listPlaylistTracks";
            this.listPlaylistTracks.Size = new System.Drawing.Size(790, 472);
            this.listPlaylistTracks.TabIndex = 3;
            // 
            // txtAccesToken
            // 
            this.txtAccesToken.Location = new System.Drawing.Point(152, 12);
            this.txtAccesToken.Name = "txtAccesToken";
            this.txtAccesToken.Size = new System.Drawing.Size(859, 20);
            this.txtAccesToken.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Name:";
            // 
            // lblPlaylistName
            // 
            this.lblPlaylistName.AutoSize = true;
            this.lblPlaylistName.Location = new System.Drawing.Point(90, 35);
            this.lblPlaylistName.Name = "lblPlaylistName";
            this.lblPlaylistName.Size = new System.Drawing.Size(64, 13);
            this.lblPlaylistName.TabIndex = 5;
            this.lblPlaylistName.Text = "playlistname";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Owner:";
            // 
            // lblPlaylistOwner
            // 
            this.lblPlaylistOwner.AutoSize = true;
            this.lblPlaylistOwner.Location = new System.Drawing.Point(90, 61);
            this.lblPlaylistOwner.Name = "lblPlaylistOwner";
            this.lblPlaylistOwner.Size = new System.Drawing.Size(36, 13);
            this.lblPlaylistOwner.TabIndex = 7;
            this.lblPlaylistOwner.Text = "owner";
            // 
            // SpotifyWebApiExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 551);
            this.Controls.Add(this.txtAccesToken);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_GetAccessToken);
            this.Name = "SpotifyWebApiExample";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbumImage)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTrack)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPlaylist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_GetAccessToken;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblAlbumArtist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listAlbumTracks;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picAlbumImage;
        private System.Windows.Forms.Button btnGetAlbum;
        private System.Windows.Forms.TextBox albumUrl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picTrack;
        private System.Windows.Forms.Button btnGetTrack;
        private System.Windows.Forms.TextBox txtTrackUri;
        private System.Windows.Forms.Label lblTrackAlbum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTrackArtist;
        private System.Windows.Forms.Label lblTrackTitle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox picPlaylist;
        private System.Windows.Forms.Button btnGetPlaylist;
        private System.Windows.Forms.TextBox txtPlaylistUri;
        private System.Windows.Forms.ListBox listPlaylistTracks;
        private System.Windows.Forms.TextBox txtAccesToken;
        private System.Windows.Forms.Label lblPlaylistOwner;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblPlaylistName;
        private System.Windows.Forms.Label label7;
    }
}

