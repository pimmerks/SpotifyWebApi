namespace SpotifyWebApi.Api.Player
{
    using System;
    using System.Collections.Generic;
    using Model;

    /// <summary>
    /// The player api.
    /// </summary>
    public interface IPlayerApi
    {
        List<Device> GetAvailableDevices();

        CurrentlyPlayingContext GetCurrentlyPlayingContext(string market = "");

        CurrentlyPlaying GetCurrentlyPlaying(string market = "");

        void Next();

        void Previous();

        void Seek(int positionMs, Device device = null);

        void SetRepeat(string state, Device device = null);

        void SetVolume(int volumePercent, Device device = null);

        void SetShuffle(bool state, Device device = null);
    }
}