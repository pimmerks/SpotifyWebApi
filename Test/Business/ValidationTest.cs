namespace SpotifyWebApiTest.Business
{
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SpotifyWebApi.Business;
    using SpotifyWebApi.Model.Auth;
    using SpotifyWebApi.Model.Exception;

    /// <summary>
    /// The <see cref="ValidationTest"/>.
    /// </summary>
    [TestClass]
    public class ValidationTest
    {
        /// <summary>
        /// Test method for  <see cref="Validation.ValidateList{T}"/>
        /// </summary>
        [TestMethod]
        public void ValidateValidListTest()
        {
            var validList = new List<int> {0, 1, 2};
            Validation.ValidateList(validList, 0, 3);
            Validation.ValidateList(validList, 1, 3);
            Validation.ValidateList(validList, 2, 3);
        }

        /// <summary>
        /// Test method for  <see cref="Validation.ValidateList{T}"/>
        /// </summary>
        [TestMethod]
        public void ValidateNonValidListTest()
        {
            var nonvalidList = new List<int>();
            Assert.ThrowsException<ValidationException>(() => Validation.ValidateList(nonvalidList, 0, 3));
            Assert.ThrowsException<ValidationException>(() => Validation.ValidateList(nonvalidList, 1, 3));
            Assert.ThrowsException<ValidationException>(() => Validation.ValidateList(nonvalidList, 2, 3));
        }

        /// <summary>
        /// Test method for <see cref="Validation.ValidateInteger"/>
        /// </summary>
        [TestMethod]
        public void ValidateIntegerTest()
        {
            Validation.ValidateInteger(0, 0, 2);
            Validation.ValidateInteger(1, 0, 2);
            Validation.ValidateInteger(2, 0, 2);

            Assert.ThrowsException<ValidationException>(() => Validation.ValidateInteger(5, 0, 2));
            Assert.ThrowsException<ValidationException>(() => Validation.ValidateInteger(5, 0, 2));
            Assert.ThrowsException<ValidationException>(() => Validation.ValidateInteger(5, 0, 2));
            Assert.ThrowsException<ValidationException>(() => Validation.ValidateInteger(5, 0, 2));
        }

        [TestMethod]
        public void ValidateTokenTest()
        {
            Assert.ThrowsException<ValidationException>(() => Validation.ValidateToken(null));
            Assert.ThrowsException<ValidationException>(() => Validation.ValidateToken(new Token()));
        }
    }
}
