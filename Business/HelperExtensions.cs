namespace SpotifyWebApi.Business
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Model;
    using Model.Auth;

    /// <summary>
    /// The <see cref="HelperExtensions"/>.
    /// </summary>
    public static class HelperExtensions
    {
        /// <summary>
        /// Loads to list.
        /// </summary>
        /// <typeparam name="T">The type of the paging object.</typeparam>
        /// <param name="paging">The paging object.</param>
        /// <param name="token">The token.</param>
        /// <returns>The final list{T}</returns>
        public static IList<T> LoadToList<T>(Paging<T> paging, Token token)
        {
            var curPage = paging;
            var result = new List<T>();
            while (curPage.Next != null)
            {
                result.AddRange(curPage.Items);

                var nextPage = ApiHelper.GetObjectFromUrl<Paging<T>>(new Uri(curPage.Next), token);

                throw new NotImplementedException(); // curPage = nextPage.Response;
            }

            return result;
        }

        /// <summary>
        /// Chunk a list by <paramref name="chunkSize"/>.
        /// </summary>
        /// <typeparam name="T">The type of the list.</typeparam>
        /// <param name="source">The source list.</param>
        /// <param name="chunkSize">Size of the chunks.</param>
        /// <returns>A List of lists containing the chunked lists.</returns>
        public static List<List<T>> ChunkBy<T>(this IEnumerable<T> source, int chunkSize)
        {
            return source
                .Select((x, i) => new { Index = i, Value = x })
                .GroupBy(x => x.Index / chunkSize)
                .Select(x => x.Select(v => v.Value).ToList())
                .ToList();
        }
    }
}
