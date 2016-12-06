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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbumImage)).BeginInit();
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1082, 485);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Track";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1082, 485);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Playlist";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // SpotifyWebApiExample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 551);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_GetAccessToken);
            this.Name = "SpotifyWebApiExample";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAlbumImage)).EndInit();
            this.ResumeLayout(false);

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
    }
}

