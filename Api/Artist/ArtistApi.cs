namespace SpotifyWebApi.Api.Artist
{
    using System;
    using System.Collections.Generic;
    using Model;
    using Model.Auth;
    using Model.Enum;
    using Model.Uri;

    /// <inheritdoc cref="BaseApi"/>
    /// <summary>
    /// The <see cref="ArtistApi"/>.
    /// </summary>
    public class ArtistApi : BaseApi, IArtistApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArtistApi"/> class.
        /// </summary>
        /// <param name="token">A valid <see cref="Token"/>.</param>
        public ArtistApi(Token token)
            : base(token)
        {
        }

        /// <inheritdoc />
        public FullArtist GetArtist(SpotifyUri artistUri)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IList<FullArtist> GetArtists(IList<SpotifyUri> artistUris)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public Paging<SimpleAlbum> GetArtistAlbums(
            SpotifyUri artistUri,
            AlbumType albumTypes = AlbumType.Album | AlbumType.AppearsOn | AlbumType.Compilation | AlbumType.Single,
            string market = "",
            int limit = 20,
            int offset = 0)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IList<FullTrack> GetArtistsTopTracks(SpotifyUri artistUri, string market)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public IList<FullArtist> GetArtistsRelatedArtists(SpotifyUri artistUri)
        {
            throw new NotImplementedException();
        }
    }
}
