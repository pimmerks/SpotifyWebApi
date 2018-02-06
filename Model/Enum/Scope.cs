//  <copyright file="Scope.cs" company="Pim Merks">
//  Copyright (c) SpotifyWebApi. All rights reserved.
//  </copyright>
namespace SpotifyWebApi.Model.Enum
{
    using System;

    [Flags]
    public enum Scope
    {
        /// <summary>
        /// If no scope is specified, access is permitted only to publicly available information: that is, only information normally visible to normal logged-in users of the Spotify desktop, web, and mobile clients (e.g. public playlists).
        /// </summary>
        None = 0,

        /// <summary>
        /// Read access to user's private playlists.
        /// </summary>
        PlaylistReadPrivate = 1,

        /// <summary>
        /// Include collaborative playlists when requesting a user's playlists.
        /// </summary>
        PlaylistReadCollaborative = 2,

        /// <summary>
        /// Write access to a user's public playlists.
        /// </summary>
        PlaylistModifyPublic = 4,

        /// <summary>
        /// Write access to a user's private playlists.
        /// </summary>
        PlaylistModifyPrivate = 8,

        /// <summary>
        /// Upload playlist cover image.
        /// </summary>
        UgcImageUpload = 16,

        /// <summary>
        /// Write/delete access to the list of artists and other users that the user follows.
        /// </summary>
        UserFollowModify = 32,

        /// <summary>
        /// Read access to the list of artists and other users that the user follows.
        /// </summary>
        UserFollowRead = 64,

        /// <summary>
        /// Read access to a user's "Your Music" library.
        /// </summary>
        UserLibraryRead = 128,

        /// <summary>
        /// Write/delete access to a user's "Your Music" library.
        /// </summary>
        UserLibraryModify = 265,

        /// <summary>
        /// Read access to user’s subscription details (type of user account).
        /// </summary>
        UserReadPrivate = 512,

        /// <summary>
        /// Read access to the user's birthdate.
        /// </summary>
        UserReadBirthdate = 1024,

        /// <summary>
        /// Read access to user’s email address.
        /// </summary>
        UserReadEmail = 2048,

        /// <summary>
        /// Read access to a user's top artists and tracks.
        /// </summary>
        UserTopRead = 4098,

        /// <summary>
        /// Read access to a user's playback state.
        /// </summary>
        UserReadPlaybackState = 8196,

        /// <summary>
        /// Control playback on Spotify clients and Spotify Connect devices.
        /// </summary>
        UserModifyPlaybackState = 16392,

        /// <summary>
        /// Read access to a user's currently playing track
        /// </summary>
        UserReadCurrentlyPlaying = 32784,

        /// <summary>
        /// Read access to a user's recently played items.
        /// </summary>
        UserReadRecentlyPlayed = 65568,
    }
}