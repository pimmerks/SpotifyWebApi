//  <copyright file="AlbumType.cs" company="Pim Merks">
//  Copyright (c) SpotifyWebApi. All rights reserved.
//  </copyright>
namespace SpotifyWebApi.Model.Enum
{
    using System;

    [Flags]
    public enum AlbumType
    {
        Album = 1,
        Single = 2,
        AppearsOn = 4,
        Compilation = 8
    }
}