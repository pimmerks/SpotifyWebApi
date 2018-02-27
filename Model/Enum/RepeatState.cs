namespace SpotifyWebApi.Model.Enum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The <see cref="RepeatState"/>.
    /// </summary>
    public enum RepeatState
    {
        /// <summary>
        /// Will repeat the current track.
        /// </summary>
        Track,

        /// <summary>
        /// Will repeat the current context.
        /// </summary>
        Context,

        /// <summary>
        /// Will turn repeat off.
        /// </summary>
        Off
    }
}
