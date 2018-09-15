namespace SpotifyWebApiTest.Business
{
    using System.Collections.Generic;
    using SpotifyWebApi.Business;
    using SpotifyWebApi.Model.Auth;
    using SpotifyWebApi.Model.Exception;
    using Xunit;

    /// <summary>
    /// The <see cref="ValidationTest"/>.
    /// </summary>
    public class ValidationTest
    {
        /// <summary>
        /// Test method for <see cref="Validation.ValidateList{T}"/>.
        /// </summary>
        [Fact]
        public void ValidateValidListTest()
        {
            var validList = new List<int> {0, 1, 2};
            Validation.ValidateList(validList, 0, 3);
            Validation.ValidateList(validList, 1, 3);
            Validation.ValidateList(validList, 2, 3);
        }

        /// <summary>
        /// Test method for <see cref="Validation.ValidateList{T}"/>.
        /// </summary>
        [Fact]
        public void ValidateNonValidListTest()
        {
            var nonvalidList = new List<int>();
            Assert.Throws<ValidationException>(() => Validation.ValidateList(nonvalidList, 0, 3));
            Assert.Throws<ValidationException>(() => Validation.ValidateList(nonvalidList, 1, 3));
            Assert.Throws<ValidationException>(() => Validation.ValidateList(nonvalidList, 2, 3));
        }

        /// <summary>
        /// Test method for <see cref="Validation.ValidateInteger"/>.
        /// </summary>
        [Fact]
        public void ValidateIntegerTest()
        {
            Validation.ValidateInteger(0, 0, 2);
            Validation.ValidateInteger(1, 0, 2);
            Validation.ValidateInteger(2, 0, 2);

            Assert.Throws<ValidationException>(() => Validation.ValidateInteger(5, 0, 2));
            Assert.Throws<ValidationException>(() => Validation.ValidateInteger(5, 0, 2));
            Assert.Throws<ValidationException>(() => Validation.ValidateInteger(5, 0, 2));
            Assert.Throws<ValidationException>(() => Validation.ValidateInteger(5, 0, 2));
        }

        /// <summary>
        /// Test method for <see cref="Validation.ValidateToken"/>.
        /// </summary>
        [Fact]
        public void ValidateTokenTest()
        {
            Assert.Throws<ValidationException>(() => Validation.ValidateToken(null));
            Assert.Throws<ValidationException>(() => Validation.ValidateToken(new Token()));
        }
    }
}
