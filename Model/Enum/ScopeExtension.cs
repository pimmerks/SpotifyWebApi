namespace SpotifyWebApi.Model.Enum
{
    using System;

    public static class ScopeExtension
    {
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
                default:
                    throw new ArgumentOutOfRangeException(nameof(scope), scope, null);
            }
        }
    }
}