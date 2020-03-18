namespace SpotifyWebApi.Model.Enum
{
    using System;

    // /// <summary>
    // /// Enum Scope
    // /// </summary>
    // [Flags]
    // public enum Scope
    // {
    //     /// <summary>
    //     /// If no scope is specified, access is permitted only to publicly available information: that is, only information normally visible to normal logged-in users of the Spotify desktop, web, and mobile clients (e.g. public playlists).
    //     /// </summary>
    //     None = 0,
    //
    //     /// <summary>
    //     /// Read access to user's private playlists.
    //     /// </summary>
    //     PlaylistReadPrivate = 1 << 0,
    //
    //     /// <summary>
    //     /// Include collaborative playlists when requesting a user's playlists.
    //     /// </summary>
    //     PlaylistReadCollaborative = 1 << 1,
    //
    //     /// <summary>
    //     /// Write access to a user's public playlists.
    //     /// </summary>
    //     PlaylistModifyPublic = 1 << 2,
    //
    //     /// <summary>
    //     /// Write access to a user's private playlists.
    //     /// </summary>
    //     PlaylistModifyPrivate = 1 << 3,
    //
    //     /// <summary>
    //     /// Upload playlist cover image.
    //     /// </summary>
    //     UgcImageUpload = 1 << 4,
    //
    //     /// <summary>
    //     /// Write/delete access to the list of artists and other users that the user follows.
    //     /// </summary>
    //     UserFollowModify = 1 << 5,
    //
    //     /// <summary>
    //     /// Read access to the list of artists and other users that the user follows.
    //     /// </summary>
    //     UserFollowRead = 1 << 6,
    //
    //     /// <summary>
    //     /// Read access to a user's "Your Music" library.
    //     /// </summary>
    //     UserLibraryRead = 1 << 7,
    //
    //     /// <summary>
    //     /// Write/delete access to a user's "Your Music" library.
    //     /// </summary>
    //     UserLibraryModify = 1 << 8,
    //
    //     /// <summary>
    //     /// Read access to user’s subscription details (type of user account).
    //     /// </summary>
    //     UserReadPrivate = 1 << 9,
    //
    //     /// <summary>
    //     /// Read access to the user's birthdate.
    //     /// </summary>
    //     UserReadBirthdate = 1 << 10,
    //
    //     /// <summary>
    //     /// Read access to user’s email address.
    //     /// </summary>
    //     UserReadEmail = 1 << 11,
    //
    //     /// <summary>
    //     /// Read access to a user's top artists and tracks.
    //     /// </summary>
    //     UserTopRead = 1 << 12,
    //
    //     /// <summary>
    //     /// Read access to a user's playback state.
    //     /// </summary>
    //     UserReadPlaybackState = 1 << 13,
    //
    //     /// <summary>
    //     /// Control playback on Spotify clients and Spotify Connect devices.
    //     /// </summary>
    //     UserModifyPlaybackState = 1 << 14,
    //
    //     /// <summary>
    //     /// Read access to a user's currently playing track
    //     /// </summary>
    //     UserReadCurrentlyPlaying = 1 << 15,
    //
    //     /// <summary>
    //     /// Read access to a user's recently played items.
    //     /// </summary>
    //     UserReadRecentlyPlayed = 1 << 16,
    //
    //     /// <summary>
    //     /// Request access to all scopes.
    //     /// </summary>
    //     All = ~1
    // }

    /// <summary>
    /// Spotify scopes, for more information visit https://developer.spotify.com/documentation/general/guides/scopes/
    /// </summary>
    public static class Scopes
    {
        public const string ScopeSeparator = " ";

        /// <summary>
        /// Scope separator.
        /// </summary>
        private const string Sep = ScopeSeparator;

        #region Images

        public const string UgcImageUpload = "ugc-image-upload";
        public const string AllImages = UgcImageUpload;

        #endregion

        #region Spotify connect

        public const string UserReadPlaybackState = "user-read-playback-state";
        public const string UserModifyPlaybackState = "user-modify-playback-state";
        public const string UserReadCurrentlyPlaying = "user-read-currently-playing";

        public const string AllSpotifyConnect =
            UserReadPlaybackState + Sep + UserModifyPlaybackState + Sep + UserReadCurrentlyPlaying;

        #endregion

        #region Playback

        public const string Streaming = "streaming";
        public const string AppRemoteControl = "app-remote-control";
        public const string AllPlayback = Streaming + Sep + AppRemoteControl;

        #endregion

        #region Users

        public const string UserReadEmail = "user-read-email";
        public const string UserReadPrivate = "user-read-private";
        public const string AllUser = UserReadEmail + Sep + UserReadPrivate;

        #endregion

        #region Playlists

        public const string PlaylistReadCollaborative = "playlist-read-collaborative";
        public const string PlaylistModifyPublic = "playlist-modify-public";
        public const string PlaylistReadPrivate = "playlist-read-private";
        public const string PlaylistModifyPrivate = "playlist-modify-private";

        public const string AllPlaylist = PlaylistReadCollaborative + Sep + PlaylistModifyPublic + Sep +
                                          PlaylistReadPrivate + Sep + PlaylistModifyPrivate; 
        #endregion

        #region Library

        public const string UserLibraryModify = "user-library-modify";
        public const string UserLibraryRead = "user-library-read";
        public const string AllLibrary = UserLibraryModify + Sep + UserLibraryRead;

        #endregion

        #region Listening history

        public const string UserTopRead = "user-top-read";
        public const string UserReadRecentlyPlayed = "user-read-recently-played";
        public const string AllListeningHistory = UserTopRead + Sep + UserReadRecentlyPlayed;
        #endregion

        #region Follow

        public const string UserFollowRead = "user-follow-read";
        public const string UserFollowModify = "user-follow-modify";
        public const string AllFollow = UserFollowRead + Sep + UserFollowModify;

        #endregion

        public const string All = AllImages + Sep + AllSpotifyConnect + Sep + AllPlayback + Sep + AllUser + Sep +
                                        AllPlaylist + Sep + AllLibrary + Sep + AllListeningHistory + Sep + AllFollow;
    }
}