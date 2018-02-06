// <copyright file="MultipleArtists.cs" company="companyPlaceholder">
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
    /// The <see cref="MultipleArtists"/>.
    /// </summary>
    public class MultipleArtists
    {
        [JsonProperty("artists")]
        public IList<FullArtist> Artists { get; set; }
    }
}
