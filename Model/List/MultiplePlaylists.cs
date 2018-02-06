// <copyright file="MultiplePlaylists.cs" company="companyPlaceholder">
// Copyright (c) companyPlaceholder. All rights reserved.
// </copyright>

namespace SpotifyWebApi.Model.List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    /// <summary>
    /// The <see cref="MultiplePlaylists"/>.
    /// </summary>
    public class MultiplePlaylists
    {
        [JsonProperty("playlists")]
        public IList<FullPlaylist> Playlists { get; set; }
    }
}
