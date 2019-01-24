namespace Spotify.Model.Enum
{
    using System;

    /// <summary>
    /// The <see cref="EnumExtensions" />.
    /// </summary>
    public static class EnumExtensions
    {
        /// <summary>
        /// Ases the string.
        /// </summary>
        /// <param name="albumType">Type of the album.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="ArgumentOutOfRangeException">albumType - null</exception>
        public static string AsString(this AlbumType albumType)
        {
            switch (albumType)
            {
                case AlbumType.Album:
                    return "album";
                case AlbumType.Single:
                    return "single";
                case AlbumType.AppearsOn:
                    return "appears_on";
                case AlbumType.Compilation:
                    return "compilation";
                default:
                    throw new ArgumentOutOfRangeException(nameof(albumType), albumType, null);
            }
        }

        /// <summary>
        /// Casts the <see cref="Scope"/> as string.
        /// </summary>
        /// <param name="scope">The enum member to convert to a string.</param>
        /// <returns>The casted string.</returns>
        public static string AsString(this Scope scope)
        {
            switch (scope)
            {
                case Scope.None:
                    return string.Empty;
                case Scope.PlaylistReadPrivate:
                    return "playlist-read-private";
                case Scope.PlaylistReadCollaborative:
                    return "playlist-read-collaborative";
                case Scope.PlaylistModifyPublic:
                    return "playlist-modify-public";
                case Scope.PlaylistModifyPrivate:
                    return "playlist-modify-private";
                case Scope.UgcImageUpload:
                    return "ugc-image-upload";
                case Scope.UserFollowModify:
                    return "user-follow-modify";
                case Scope.UserFollowRead:
                    return "user-follow-read";
                case Scope.UserLibraryRead:
                    return "user-library-read";
                case Scope.UserLibraryModify:
                    return "user-library-modify";
                case Scope.UserReadPrivate:
                    return "user-read-private";
                case Scope.UserReadBirthdate:
                    return "user-read-birthdate";
                case Scope.UserReadEmail:
                    return "user-read-email";
                case Scope.UserTopRead:
                    return "user-top-read";
                case Scope.UserReadPlaybackState:
                    return "user-read-playback-state";
                case Scope.UserModifyPlaybackState:
                    return "user-modify-playback-state";
                case Scope.UserReadCurrentlyPlaying:
                    return "user-read-currently-playing";
                case Scope.UserReadRecentlyPlayed:
                    return "user-read-recently-played";
                case Scope.All:
                    return "playlist-read-private playlist-read-collaborative playlist-modify-public playlist-modify-private ugc-image-upload user-follow-modify user-follow-read user-library-modify user-read-private user-read-birthdate user-read-email user-top-read user-read-playback-state user-modify-playback-state user-read-currently-playing user-read-recently-played";
                default:
                    throw new ArgumentOutOfRangeException(nameof(scope), scope, null);
            }
        }
    }
}
