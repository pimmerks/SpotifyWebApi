namespace SpotifyWebApi.NewModels
{
    /// <summary>
    ///     * &#x60;NO_PREV_TRACK&#x60; - The command requires a previous track, but there is none in the context. * &#x60;
    ///     NO_NEXT_TRACK&#x60; - The command requires a next track, but there is none in the context. * &#x60;
    ///     NO_SPECIFIC_TRACK&#x60; - The requested track does not exist. * &#x60;ALREADY_PAUSED&#x60; - The command requires
    ///     playback to not be paused. * &#x60;NOT_PAUSED&#x60; - The command requires playback to be paused. * &#x60;
    ///     NOT_PLAYING_LOCALLY&#x60; - The command requires playback on the local device. * &#x60;NOT_PLAYING_TRACK&#x60; -
    ///     The command requires that a track is currently playing. * &#x60;NOT_PLAYING_CONTEXT&#x60; - The command requires
    ///     that a context is currently playing. * &#x60;ENDLESS_CONTEXT&#x60; - The shuffle command cannot be applied on an
    ///     endless context. * &#x60;CONTEXT_DISALLOW&#x60; - The command could not be performed on the context. * &#x60;
    ///     ALREADY_PLAYING&#x60; - The track should not be restarted if the same track and context is already playing, and
    ///     there is a resume point. * &#x60;RATE_LIMITED&#x60; - The user is rate limited due to too frequent track play, also
    ///     known as cat-on-the-keyboard spamming. * &#x60;REMOTE_CONTROL_DISALLOW&#x60; - The context cannot be
    ///     remote-controlled. * &#x60;DEVICE_NOT_CONTROLLABLE&#x60; - Not possible to remote control the device. * &#x60;
    ///     VOLUME_CONTROL_DISALLOW&#x60; - Not possible to remote control the device&#x27;s volume. * &#x60;NO_ACTIVE_DEVICE
    ///     &#x60; - Requires an active device and the user has none. * &#x60;PREMIUM_REQUIRED&#x60; - The request is
    ///     prohibited for non-premium users. * &#x60;UNKNOWN&#x60; - Certain actions are restricted because of unknown
    ///     reasons.
    /// </summary>
    public class PlayerErrorReasons
    {
    }
}
