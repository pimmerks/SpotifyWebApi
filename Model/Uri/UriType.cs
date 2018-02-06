namespace SpotifyWebApi.Model.Uri
{
    using System.Runtime.Serialization;

    [DataContract]
    public enum UriType
    {
        [EnumMember]
        User,

        [EnumMember]
        Track,

        [EnumMember]
        Artist,

        [EnumMember]
        Album,

        [EnumMember]
        Playlist,
    }
}
