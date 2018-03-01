namespace SpotifyWebApi.Api.Player
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Model;
    using Model.Enum;
    using Model.Uri;

    /// <summary>
    /// The player api.
    /// </summary>
    /// <remarks>These endpoints are in Beta.</remarks>
    public interface IPlayerApi
    {
        /// <summary>
        /// Get information about a user’s available devices.
        /// </summary>
        /// <returns>A list of available devices.</returns>
        Task<List<Device>> GetAvailableDevices();

        /// <summary>
        /// Get information about the user’s current playback state, including track, track progress, and active device.
        /// </summary>
        /// <param name="market">Optional. An ISO 3166-1 alpha-2 country code. Provide this parameter if you want to apply Track Relinking.</param>
        /// <returns>The users <see cref="CurrentlyPlayingContext"/> instance.</returns>
        Task<CurrentlyPlayingContext> GetCurrentlyPlayingContext(string market = "");

        /// <summary>
        /// Get the object currently being played on the user’s Spotify account.
        /// </summary>
        /// <param name="market">Optional. An ISO 3166-1 alpha-2 country code. Provide this parameter if you want to apply Track Relinking.</param>
        /// <returns>The users <see cref="CurrentlyPlaying"/> object.</returns>
        Task<CurrentlyPlaying> GetCurrentlyPlaying(string market = "");

        /// <summary>
        /// Transfer playback to a new device and determine if it should start playing.
        /// </summary>
        /// <param name="devices">Required. A list containing the devices on which playback should be started/transferred.
        /// NOTE: Although an list is accepted, only a single <see cref="Device"/> is currently supported.</param>
        /// <param name="play">Optional.
        /// <c>True</c>: ensure playback happens on new device.
        /// <c>False</c> or not provided: keep the current playback state.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task TransferPlayback(List<Device> devices, bool? play = null);

        /// <summary>
        /// Start a new context or resume current playback on the user’s active device.
        /// TODO: Add offset parameter.
        /// </summary>
        /// <param name="device">Optional. The device this command is targeting. If not supplied, the user's currently active device is the target.</param>
        /// <param name="contextUri">Optional. Spotify URI of the context to play. Valid contexts are albums, artists &amp; playlists.</param>
        /// <param name="uris">Optional. A list of the Spotify track URIs to play.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task StartPlayback(Device device = null, SpotifyUri contextUri = null, List<SpotifyUri> uris = null);

        /// <summary>
        /// Pause playback on the user’s account.
        /// </summary>
        /// <param name="device">Optional. The device this command is targeting. If not supplied, the user's currently active device is the target.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task PausePlayback(Device device = null);

        /// <summary>
        /// Skips to next track in the user’s queue.
        /// </summary>
        /// <param name="device">Optional. The device this command is targeting. If not supplied, the user's currently active device is the target.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task Next(Device device = null);

        /// <summary>
        /// Skips to previous track in the user’s queue.
        /// Note that this will ALWAYS skip to the previous track, regardless of the current track’s progress.
        /// Returning to the start of the current track should be performed using the <see cref="SeekAsync"/> function.
        /// </summary>
        /// <param name="device">Optional. The device this command is targeting. If not supplied, the user's currently active device is the target.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task Previous(Device device = null);

        /// <summary>
        /// Seeks to the given position in the user’s currently playing track.
        /// </summary>
        /// <param name="positionMs">The position in milliseconds to seek to. Must be a positive number. Passing in a position that is greater than the length of the track will cause the player to start playing the next song.</param>
        /// <param name="device">Optional. The device this command is targeting. If not supplied, the user's currently active device is the target.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task Seek(int positionMs, Device device = null);

        /// <summary>
        /// Set the repeat mode for the user’s playback. Options are repeat-track, repeat-context, and off.
        /// </summary>
        /// <param name="state">The state of repeat.</param>
        /// <param name="device">Optional. The device this command is targeting. If not supplied, the user's currently active device is the target.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task SetRepeat(RepeatState state, Device device = null);

        /// <summary>
        /// Set the volume for the user’s current playback device.
        /// </summary>
        /// <param name="volumePercent">The volume to set. Must be a value from 0 to 100 inclusive.</param>
        /// <param name="device">Optional. The device this command is targeting. If not supplied, the user's currently active device is the target.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task SetVolume(int volumePercent, Device device = null);

        /// <summary>
        /// Toggle shuffle on or off for user’s playback.
        /// </summary>
        /// <param name="state"><c>True</c>: Shuffle user's playback. <c>False</c>: Do not shuffle user's playback</param>
        /// <param name="device">Optional. The device this command is targeting. If not supplied, the user's currently active device is the target.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        Task SetShuffle(bool state, Device device = null);
    }
}