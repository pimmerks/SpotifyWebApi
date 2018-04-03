namespace SpotifyWebApi.Business
{
    using System.Collections.Generic;
    using Model.Auth;
    using Model.Exception;

    /// <summary>
    /// A static class used for validation a variance of objects.
    /// </summary>
    public static class Validation
    {
        /// <summary>
        /// Validates a list and throws a <see cref="ValidationException"/> when failed.
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
        /// Validates a integer and throws a <see cref="ValidationException"/> when failed.
        /// </summary>
        /// <param name="value">The value to validate</param>
        /// <param name="min">The minimum of the value.</param>
        /// <param name="max">The maximum of the value.</param>
        /// <exception cref="ValidationException">Throws a validation exception when the value is invalid.</exception>
        public static void ValidateInteger(int value, int min = int.MinValue, int max = int.MaxValue)
        {
            if (value < min) { throw new ValidationException("The value is too small."); }
            if (value > max) { throw new ValidationException("The value is too big."); }
        }

        /// <summary>
        /// Validates a <see cref="Token"/>.
        /// Note this function does not check for expired tokens!
        /// </summary>
        /// <param name="token">The token to validate.</param>
        /// <exception cref="ValidationException">Throws a validation exception when the value is invalid.</exception>
        public static void ValidateToken(Token token)
        {
            if (token == null) { throw new ValidationException("The token is null."); }

            if (token.Type != "Bearer") throw new ValidationException("The token type is not \"Bearer\".");

            if (string.IsNullOrWhiteSpace(token.AccessToken))
                throw new ValidationException("The token's 'AccessToken' is empty or null");

            // if (string.IsNullOrWhiteSpace(token.RefreshToken))
            //    throw new ValidationException("The token's 'RefreshToken' is empty or null");
        }
    }
}