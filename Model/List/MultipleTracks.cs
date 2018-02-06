// <copyright file="MultipleTracks.cs" company="companyPlaceholder">
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
    /// The <see cref="MultipleTracks"/>.
    /// </summary>
    public class MultipleTracks
    {
        [JsonProperty("tracks")]
        public IList<FullTrack> Tracks { get; set; }
    }
}
