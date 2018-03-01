namespace SpotifyWebApi.Api
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// The <see cref="AsyncExtension"/>.
    /// </summary>
    public static class AsyncExtension
    {
        /// <summary>
        /// Converts a async method to a non async method.
        /// </summary>
        /// <typeparam name="T">The type of the Task.</typeparam>
        /// <param name="task">The task to convert.</param>
        /// <returns>The result of the task.</returns>
        public static T NonAsync<T>(this Task<T> task)
        {
            return task.GetAwaiter().GetResult();
        }
    }
}
