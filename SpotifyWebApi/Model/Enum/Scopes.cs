namespace SpotifyWebApi.Model.Enum
{
    /// <summary>
    /// Spotify scopes, for more information visit https://developer.spotify.com/documentation/general/guides/scopes/
    /// </summary>
    public static class Scopes
    {
        /// <summary>
        /// The default scope separator.
        /// </summary>
        public const string ScopeSeparator = " ";

        #region Images

        /// <summary>
        /// Write access to user-provided images.
        /// </summary>
        public const string UgcImageUpload = "ugc-image-upload";

        /// <summary>
        /// All scopes in the image category.
        /// </summary>
        public const string AllImages = UgcImageUpload;

        #endregion

        #region Spotify connect

        /// <summary>
        /// UserReadPlaybackState
        /// </summary>
        public const string UserReadPlaybackState = "user-read-playback-state";

        /// <summary>
        /// UserModifyPlaybackState
        /// </summary>
        public const string UserModifyPlaybackState = "user-modify-playback-state";

        /// <summary>
        /// UserReadCurrentlyPlaying
        /// </summary>
        public const string UserReadCurrentlyPlaying = "user-read-currently-playing";

        /// <summary>
        /// All scopes from the Spotify Connect category.
        /// </summary>
        public const string AllSpotifyConnect =
            UserReadPlaybackState + Sep + UserModifyPlaybackState + Sep + UserReadCurrentlyPlaying;

        #endregion

        #region Playback

        /// <summary>
        /// Streaming
        /// </summary>
        public const string Streaming = "streaming";

        /// <summary>
        /// AppRemoteControl
        /// </summary>
        public const string AppRemoteControl = "app-remote-control";

        /// <summary>
        /// All scopes from the Playback category.
        /// </summary>
        public const string AllPlayback = Streaming + Sep + AppRemoteControl;

        #endregion

        #region Users

        /// <summary>
        /// UserReadEmail
        /// </summary>
        public const string UserReadEmail = "user-read-email";

        /// <summary>
        /// UserReadPrivate
        /// </summary>
        public const string UserReadPrivate = "user-read-private";

        /// <summary>
        /// All scopes from the Users category.
        /// </summary>
        public const string AllUser = UserReadEmail + Sep + UserReadPrivate;

        #endregion

        #region Playlists

        /// <summary>
        /// PlaylistReadCollaborative
        /// </summary>
        public const string PlaylistReadCollaborative = "playlist-read-collaborative";

        /// <summary>
        /// PlaylistModifyPublic
        /// </summary>
        public const string PlaylistModifyPublic = "playlist-modify-public";

        /// <summary>
        /// PlaylistReadPrivate
        /// </summary>
        public const string PlaylistReadPrivate = "playlist-read-private";

        /// <summary>
        /// PlaylistModifyPrivate
        /// </summary>
        public const string PlaylistModifyPrivate = "playlist-modify-private";

        /// <summary>
        /// All scopes from the Playlist category.
        /// </summary>
        public const string AllPlaylist = PlaylistReadCollaborative + Sep + PlaylistModifyPublic + Sep +
                                          PlaylistReadPrivate + Sep + PlaylistModifyPrivate;
        #endregion

        #region Library

        /// <summary>
        /// UserLibraryModify
        /// </summary>
        public const string UserLibraryModify = "user-library-modify";

        /// <summary>
        /// UserLibraryRead
        /// </summary>
        public const string UserLibraryRead = "user-library-read";

        /// <summary>
        /// All scopes from the Library category.
        /// </summary>
        public const string AllLibrary = UserLibraryModify + Sep + UserLibraryRead;

        #endregion

        #region Listening history

        /// <summary>
        /// UserTopRead
        /// </summary>
        public const string UserTopRead = "user-top-read";

        /// <summary>
        /// UserReadRecentlyPlayed
        /// </summary>
        public const string UserReadRecentlyPlayed = "user-read-recently-played";

        /// <summary>
        /// All scopes from the Listening history category.
        /// </summary>
        public const string AllListeningHistory = UserTopRead + Sep + UserReadRecentlyPlayed;
        #endregion

        #region Follow

        /// <summary>
        /// UserFollowRead
        /// </summary>
        public const string UserFollowRead = "user-follow-read";

        /// <summary>
        /// UserFollowModify
        /// </summary>
        public const string UserFollowModify = "user-follow-modify";

        /// <summary>
        /// All scopes from the Follow category.
        /// </summary>
        public const string AllFollow = UserFollowRead + Sep + UserFollowModify;

        #endregion

        /// <summary>
        /// All scopes.
        /// </summary>
        public const string All = AllImages + Sep + AllSpotifyConnect + Sep + AllPlayback + Sep + AllUser + Sep +
                                        AllPlaylist + Sep + AllLibrary + Sep + AllListeningHistory + Sep + AllFollow;

        /// <summary>
        /// Scope separator for ease of use.
        /// </summary>
        private const string Sep = ScopeSeparator;
    }
}