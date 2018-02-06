namespace SpotifyWebApi.Model.List
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Newtonsoft.Json;

    /// <summary>
    /// The <see cref="MultipleAlbums"/>.
    /// </summary>
    public class MultipleAlbums
    {
        [JsonProperty("albums")]
        public IList<FullAlbum> Albums { get; set; }
    }
}
