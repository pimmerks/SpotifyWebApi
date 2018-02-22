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
        public List<Device> GetAvailableDevices()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public CurrentlyPlayingContext GetCurrentlyPlayingContext(string market)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public CurrentlyPlaying GetCurrentlyPlaying(string market)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Next()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Previous()
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void Seek(int positionMs, Device device)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void SetRepeat(string state, Device device)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void SetVolume(int volumePercent, Device device)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc />
        public void SetShuffle(bool state, Device device)
        {
            throw new NotImplementedException();
        }
    }
}
