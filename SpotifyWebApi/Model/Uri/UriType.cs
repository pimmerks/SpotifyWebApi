namespace SpotifyWebApi.Model.Uri
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Enum UriType
    /// </summary>
    [DataContract]
    public enum UriType
    {
        /// <summary>
        /// The user
        /// </summary>
        [EnumMember]
        User,

        /// <summary>
        /// The track
        /// </summary>
        [EnumMember]
        Track,

        /// <summary>
        /// The artist
        /// </summary>
        [EnumMember]
        Artist,

        /// <summary>
        /// The album
        /// </summary>
        [EnumMember]
        Album,

        /// <summary>
        /// The playlist
        /// </summary>
        [EnumMember]
        Playlist,

        /// <summary>
        /// A local uri.
        /// </summary>
        [EnumMember]
        Local,
    }
}
