namespace SpotifyWebApi.Business
{
    using System.Collections.Generic;
    using Model.Exception;

    /// <summary>
    /// A static class used for validation a variance of objects.
    /// </summary>
    public static class Validation
    {
        /// <summary>
        /// Validates a list.
        /// </summary>
        /// <param name="list">The list to validate</param>
        /// <param name="min">The minimum number of items in the list.</param>
        /// <param name="max">The maximum number of items in the list.</param>
        /// <typeparam name="T">TODO</typeparam>
        /// <exception cref="ValidationException">Throws a validation exception when the list is null or invalid.</exception>
        public static void ValidateList<T>(ICollection<T> list, int min = -1, int max = -1)
        {
            if (list == null) { throw new ValidationException("The list is null."); }

            var c = list.Count;
            if (c == 0) { throw new ValidationException("The list is empty."); }
            if (c < min) { throw new ValidationException("The list is too small."); }
            if (c > max) { throw new ValidationException("The list is too big."); }
        }

        /// <summary>
        /// Validates a list.
        /// </summary>
        /// <param name="value">The value to validate</param>
        /// <param name="min">The minimum of the value.</param>
        /// <param name="max">The maximum of the value.</param>
        /// <exception cref="ValidationException">Throws a validation exception when the value is invalid.</exception>
        public static void ValidateInteger(int value, int min = int.MinValue, int max = int.MaxValue)
        {
            var c = value;
            if (c < min) { throw new ValidationException("The value is too small."); }
            if (c > max) { throw new ValidationException("The value is too big."); }
        }
    }
}