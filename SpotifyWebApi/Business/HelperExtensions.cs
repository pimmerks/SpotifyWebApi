namespace SpotifyWebApi.Business
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Model;
    using Model.Auth;

    /// <summary>
    /// The <see cref="HelperExtensions"/>.
    /// </summary>
    internal static class HelperExtensions
    {
        /// <summary>
        /// Loads to list.
        /// </summary>
        /// <typeparam name="T">The type of the paging object.</typeparam>
        /// <param name="paging">The paging object.</param>
        /// <param name="token">The token.</param>
        /// <param name="maxItems">The maximum items to return.</param>
        /// <returns>The final list{T}</returns>
        public static async Task<IList<T>> LoadToList<T>(this Paging<T> paging, Token token, int maxItems = 100)
        {
            if (paging == null)
            {
                return new List<T>();
            }
            var curPage = paging;
            var result = curPage.Items;

            while (curPage.Next != null)
            {
                var next = await ApiClient.GetAsync<Paging<T>>(new Uri(curPage.Next), token).ConfigureAwait(false);

                if (next.Response is Paging<T> nextPage)
                {
                    result.AddRange(nextPage.Items);
                    curPage = nextPage;
                }
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

        /// <summary>
        /// Converts a list of strings to a single string with a separator.
        /// </summary>
        /// <param name="list">The list to convert.</param>
        /// <param name="separator">The separator to put between the list items.</param>
        /// <returns>The created string.</returns>
        public static string AsSingleString(this List<string> list, string separator = ",")
        {
            return string.Join(separator, list);
        }
    }
}
