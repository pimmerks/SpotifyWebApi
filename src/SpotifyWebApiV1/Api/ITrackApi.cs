namespace SpotifyWebApi.Api
{
    using SpotifyWebApi.Models;

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITracksApi 
    {
        // /// <summary>
        // /// Add Items to Playlist 
        // /// </summary>
        // /// <remarks>
        // /// Add one or more items to a user&#x27;s playlist. 
        // /// </remarks>
        // /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        // /// <param name="playlistId"></param>
        // /// <param name="body"> (optional)</param>
        // /// <param name="position"> (optional)</param>
        // /// <param name="uris"> (optional)</param>
        // /// <returns>Task of InlineResponse2006</returns>
        // System.Threading.Tasks.Task<InlineResponse2006> AddTracksToPlaylistAsync (string playlistId, Dictionary<string, Object> body = null, int? position = null, string uris = null);
        //
        // /// <summary>
        // /// Check User&#x27;s Saved Tracks 
        // /// </summary>
        // /// <remarks>
        // /// Check if one or more tracks is already saved in the current Spotify user&#x27;s &#x27;Your Music&#x27; library. 
        // /// </remarks>
        // /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        // /// <param name="ids"></param>
        // /// <returns>Task of List&lt;bool?&gt;</returns>
        // System.Threading.Tasks.Task<List<bool?>> CheckUsersSavedTracksAsync (string ids);
        //
        // /// <summary>
        // /// Get Album Tracks 
        // /// </summary>
        // /// <remarks>
        // /// Get Spotify catalog information about an album’s tracks. Optional parameters can be used to limit the number of tracks returned. 
        // /// </remarks>
        // /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        // /// <param name="id"></param>
        // /// <param name="market"> (optional)</param>
        // /// <param name="limit"> (optional, default to 20)</param>
        // /// <param name="offset"> (optional, default to 0)</param>
        // /// <returns>Task of PagingObject</returns>
        // System.Threading.Tasks.Task<PagingObject> GetAnAlbumsTracksAsync (string id, string market = null, int? limit = null, int? offset = null);
        // /// <summary>
        // /// Get Artist&#x27;s Top Tracks 
        // /// </summary>
        // /// <remarks>
        // /// Get Spotify catalog information about an artist&#x27;s top tracks by country. 
        // /// </remarks>
        // /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        // /// <param name="id"></param>
        // /// <param name="market"> (optional)</param>
        // /// <returns>Task of InlineResponse2002</returns>
        // System.Threading.Tasks.Task<InlineResponse2002> GetAnArtistsTopTracksAsync (string id, string market = null);
        //
        // /// <summary>
        // /// Get Track&#x27;s Audio Analysis 
        // /// </summary>
        // /// <remarks>
        // /// Get a low-level audio analysis for a track in the Spotify catalog. The audio analysis describes the track’s structure and musical content, including rhythm, pitch, and timbre. 
        // /// </remarks>
        // /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        // /// <param name="id"></param>
        // /// <returns>Task of AudioAnalysisObject</returns>
        // System.Threading.Tasks.Task<AudioAnalysisObject> GetAudioAnalysisAsync (string id);
        //
        // /// <summary>
        // /// Get Track&#x27;s Audio Features 
        // /// </summary>
        // /// <remarks>
        // /// Get audio feature information for a single track identified by its unique Spotify ID. 
        // /// </remarks>
        // /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        // /// <param name="id"></param>
        // /// <returns>Task of AudioFeaturesObject</returns>
        // System.Threading.Tasks.Task<AudioFeaturesObject> GetAudioFeaturesAsync (string id);
        // /// <summary>
        // /// Get Playlist Items 
        // /// </summary>
        // /// <remarks>
        // /// Get full details of the items of a playlist owned by a Spotify user. 
        // /// </remarks>
        // /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        // /// <param name="playlistId"></param>
        // /// <param name="market"> (optional)</param>
        // /// <param name="fields"> (optional)</param>
        // /// <param name="limit"> (optional, default to 20)</param>
        // /// <param name="offset"> (optional, default to 0)</param>
        // /// <param name="additionalTypes"> (optional)</param>
        // /// <returns>Task of PagingObject</returns>
        // System.Threading.Tasks.Task<PagingObject> GetPlaylistsTracksAsync (string playlistId, string market = null, string fields = null, int? limit = null, int? offset = null, string additionalTypes = null);
        // /// <summary>
        // /// Get Recommendations 
        // /// </summary>
        // /// <remarks>
        // /// Recommendations are generated based on the available information for a given seed entity and matched against similar artists and tracks. If there is sufficient information about the provided seeds, a list of tracks will be returned together with pool size details.  For artists and tracks that are very new or obscure there might not be enough data to generate a list of tracks. 
        // /// </remarks>
        // /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        // /// <param name="seedArtists"></param>
        // /// <param name="seedGenres"></param>
        // /// <param name="seedTracks"></param>
        // /// <param name="limit"> (optional, default to 20)</param>
        // /// <param name="market"> (optional)</param>
        // /// <param name="minAcousticness"> (optional)</param>
        // /// <param name="maxAcousticness"> (optional)</param>
        // /// <param name="targetAcousticness"> (optional)</param>
        // /// <param name="minDanceability"> (optional)</param>
        // /// <param name="maxDanceability"> (optional)</param>
        // /// <param name="targetDanceability"> (optional)</param>
        // /// <param name="minDurationMs"> (optional)</param>
        // /// <param name="maxDurationMs"> (optional)</param>
        // /// <param name="targetDurationMs"> (optional)</param>
        // /// <param name="minEnergy"> (optional)</param>
        // /// <param name="maxEnergy"> (optional)</param>
        // /// <param name="targetEnergy"> (optional)</param>
        // /// <param name="minInstrumentalness"> (optional)</param>
        // /// <param name="maxInstrumentalness"> (optional)</param>
        // /// <param name="targetInstrumentalness"> (optional)</param>
        // /// <param name="minKey"> (optional)</param>
        // /// <param name="maxKey"> (optional)</param>
        // /// <param name="targetKey"> (optional)</param>
        // /// <param name="minLiveness"> (optional)</param>
        // /// <param name="maxLiveness"> (optional)</param>
        // /// <param name="targetLiveness"> (optional)</param>
        // /// <param name="minLoudness"> (optional)</param>
        // /// <param name="maxLoudness"> (optional)</param>
        // /// <param name="targetLoudness"> (optional)</param>
        // /// <param name="minMode"> (optional)</param>
        // /// <param name="maxMode"> (optional)</param>
        // /// <param name="targetMode"> (optional)</param>
        // /// <param name="minPopularity"> (optional)</param>
        // /// <param name="maxPopularity"> (optional)</param>
        // /// <param name="targetPopularity"> (optional)</param>
        // /// <param name="minSpeechiness"> (optional)</param>
        // /// <param name="maxSpeechiness"> (optional)</param>
        // /// <param name="targetSpeechiness"> (optional)</param>
        // /// <param name="minTempo"> (optional)</param>
        // /// <param name="maxTempo"> (optional)</param>
        // /// <param name="targetTempo"> (optional)</param>
        // /// <param name="minTimeSignature"> (optional)</param>
        // /// <param name="maxTimeSignature"> (optional)</param>
        // /// <param name="targetTimeSignature"> (optional)</param>
        // /// <param name="minValence"> (optional)</param>
        // /// <param name="maxValence"> (optional)</param>
        // /// <param name="targetValence"> (optional)</param>
        // /// <returns>Task of RecommendationsObject</returns>
        // System.Threading.Tasks.Task<RecommendationsObject> GetRecommendationsAsync (string seedArtists, string seedGenres, string seedTracks, int? limit = null, string market = null, decimal? minAcousticness = null, decimal? maxAcousticness = null, decimal? targetAcousticness = null, decimal? minDanceability = null, decimal? maxDanceability = null, decimal? targetDanceability = null, int? minDurationMs = null, int? maxDurationMs = null, int? targetDurationMs = null, decimal? minEnergy = null, decimal? maxEnergy = null, decimal? targetEnergy = null, decimal? minInstrumentalness = null, decimal? maxInstrumentalness = null, decimal? targetInstrumentalness = null, int? minKey = null, int? maxKey = null, int? targetKey = null, decimal? minLiveness = null, decimal? maxLiveness = null, decimal? targetLiveness = null, decimal? minLoudness = null, decimal? maxLoudness = null, decimal? targetLoudness = null, int? minMode = null, int? maxMode = null, int? targetMode = null, int? minPopularity = null, int? maxPopularity = null, int? targetPopularity = null, decimal? minSpeechiness = null, decimal? maxSpeechiness = null, decimal? targetSpeechiness = null, decimal? minTempo = null, decimal? maxTempo = null, decimal? targetTempo = null, int? minTimeSignature = null, int? maxTimeSignature = null, int? targetTimeSignature = null, decimal? minValence = null, decimal? maxValence = null, decimal? targetValence = null);
        // /// <summary>
        // /// Get Tracks&#x27; Audio Features 
        // /// </summary>
        // /// <remarks>
        // /// Get audio features for multiple tracks based on their Spotify IDs. 
        // /// </remarks>
        // /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        // /// <param name="ids"></param>
        // /// <returns>Task of InlineResponse20012</returns>
        // System.Threading.Tasks.Task<InlineResponse20012> GetSeveralAudioFeaturesAsync (string ids);
        // /// <summary>
        // /// Get Several Tracks 
        // /// </summary>
        // /// <remarks>
        // /// Get Spotify catalog information for multiple tracks based on their Spotify IDs. 
        // /// </remarks>
        // /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        // /// <param name="ids"></param>
        // /// <param name="market"> (optional)</param>
        // /// <returns>Task of InlineResponse2002</returns>
        // System.Threading.Tasks.Task<InlineResponse2002> GetSeveralTracksAsync (string ids, string market = null);

        /// <summary>
        /// Get Track
        /// </summary>
        /// <remarks>
        /// Get Spotify catalog information for a single track identified by its unique Spotify ID. 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="market"> (optional)</param>
        /// <returns>Task of TrackObject</returns>
        Task<Track> GetTrackAsync(string id, string? market = null);

        // /// <summary>
        // /// Get User&#x27;s Saved Tracks
        // /// </summary>
        // /// <remarks>
        // /// Get a list of the songs saved in the current Spotify user&#x27;s &#x27;Your Music&#x27; library. 
        // /// </remarks>
        // /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        // /// <param name="market"> (optional)</param>
        // /// <param name="limit"> (optional, default to 20)</param>
        // /// <param name="offset"> (optional, default to 0)</param>
        // /// <returns>Task of PagingObject</returns>
        // System.Threading.Tasks.Task<PagingObject> GetUsersSavedTracksAsync (string market = null, int? limit = null, int? offset = null);
        // /// <summary>
        // /// Get User&#x27;s Top Items 
        // /// </summary>
        // /// <remarks>
        // /// Get the current user&#x27;s top artists or tracks based on calculated affinity. 
        // /// </remarks>
        // /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        // /// <param name="type"></param>
        // /// <param name="timeRange"> (optional, default to medium_term)</param>
        // /// <param name="limit"> (optional, default to 20)</param>
        // /// <param name="offset"> (optional, default to 0)</param>
        // /// <returns>Task of PagingObject</returns>
        // System.Threading.Tasks.Task<PagingObject> GetUsersTopArtistsAndTracksAsync (string type, string timeRange = null, int? limit = null, int? offset = null);
        // /// <summary>
        // /// Remove Playlist Items 
        // /// </summary>
        // /// <remarks>
        // /// Remove one or more items from a user&#x27;s playlist. 
        // /// </remarks>
        // /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        // /// <param name="playlistId"></param>
        // /// <param name="body"> (optional)</param>
        // /// <returns>Task of InlineResponse2006</returns>
        // System.Threading.Tasks.Task<InlineResponse2006> RemoveTracksPlaylistAsync (string playlistId, PlaylistIdTracksBody2 body = null);
        // /// <summary>
        // /// Remove Tracks for Current User 
        // /// </summary>
        // /// <remarks>
        // /// Remove one or more tracks from the current user&#x27;s &#x27;Your Music&#x27; library. 
        // /// </remarks>
        // /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        // /// <param name="ids"></param>
        // /// <param name="body"> (optional)</param>
        // /// <returns>Task of void</returns>
        // System.Threading.Tasks.Task RemoveTracksUserAsync (string ids, Dictionary<string, Object> body = null);

        // /// <summary>
        // /// Update Playlist Items 
        // /// </summary>
        // /// <remarks>
        // /// Either reorder or replace items in a playlist depending on the request&#x27;s parameters. To reorder items, include &#x60;range_start&#x60;, &#x60;insert_before&#x60;, &#x60;range_length&#x60; and &#x60;snapshot_id&#x60; in the request&#x27;s body. To replace items, include &#x60;uris&#x60; as either a query parameter or in the request&#x27;s body. Replacing items in a playlist will overwrite its existing items. This operation can be used for replacing or clearing items in a playlist. &lt;br&gt; **Note**: Replace and reorder are mutually exclusive operations which share the same endpoint, but have different parameters. These operations can&#x27;t be applied together in a single request. 
        // /// </remarks>
        // /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        // /// <param name="playlistId"></param>
        // /// <param name="body"> (optional)</param>
        // /// <param name="uris"> (optional)</param>
        // /// <returns>Task of InlineResponse2006</returns>

        // System.Threading.Tasks.Task<InlineResponse2006> ReorderOrReplacePlaylistsTracksAsync (string playlistId, Dictionary<string, Object> body = null, string uris = null);
        // /// <summary>
        // /// Save Tracks for Current User 
        // /// </summary>
        // /// <remarks>
        // /// Save one or more tracks to the current user&#x27;s &#x27;Your Music&#x27; library. 
        // /// </remarks>
        // /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        // /// <param name="ids"></param>
        // /// <param name="body"> (optional)</param>
        // /// <returns>Task of void</returns>
        // System.Threading.Tasks.Task SaveTracksUserAsync (string ids, Dictionary<string, Object> body = null);
    }
}
