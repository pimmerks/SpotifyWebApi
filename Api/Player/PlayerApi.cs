namespace SpotifyWebApi.Api.Player
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Threading.Tasks;
    using Business;
    using Model;
    using Model.Auth;
    using Model.Enum;
    using Model.Uri;

    /// <summary>
    /// The <see cref="PlayerApi"/>.
    /// </summary>
    public class PlayerApi : BaseApi, IPlayerApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PlayerApi"/> class.
        /// </summary>
        /// <param name="token">A valid <see cref="Token" />.</param>
        public PlayerApi(Token token)
            : base(token)
        {
        }

        /// <inheritdoc />
        public async Task<List<Device>> GetAvailableDevices()
        {
            var r = await ApiClient.GetAsync<List<Device>>(
                        MakeUri("me/player/devices"), this.Token);

            if (r.Response is List<Device> res)
            {
                return res;
            }
            return new List<Device>();
        }

        /// <inheritdoc />
        public async Task<CurrentlyPlayingContext> GetCurrentlyPlayingContext(string market = "")
        {
            var r = await ApiClient.GetAsync<CurrentlyPlayingContext>(
                        MakeUri($"me/player{AddMarketCode("?", market)}"), this.Token);

            if (r.Response is CurrentlyPlayingContext res)
            {
                return res;
            }
            return new CurrentlyPlayingContext();
        }

        /// <inheritdoc />
        public async Task<CurrentlyPlaying> GetCurrentlyPlaying(string market = "")
        {
            var r = await ApiClient.GetAsync<CurrentlyPlaying>(
                        MakeUri($"me/player/currently-playing{AddMarketCode("?", market)}"), this.Token);

            if (r.Response is CurrentlyPlaying res)
            {
                return res;
            }
            return new CurrentlyPlaying();
        }

        /// <inheritdoc />
        public async Task TransferPlayback(List<Device> devices, bool? play = null)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public async Task StartPlayback(Device device = null, SpotifyUri contextUri = null, List<SpotifyUri> uris = null)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public async Task PausePlayback(Device device = null)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public async Task Next(Device device = null)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public async Task Previous(Device device = null)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public async Task Seek(int positionMs, Device device = null)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public async Task SetRepeat(RepeatState state, Device device = null)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public async Task SetVolume(int volumePercent, Device device = null)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public async Task SetShuffle(bool state, Device device = null)
        {
            throw new NotImplementedException();
        }
    }
}
