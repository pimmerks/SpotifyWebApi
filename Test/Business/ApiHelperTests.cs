namespace Test.Business
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SpotifyWebApi.Business;
    using System;

    /// <summary>
    /// The <see cref="ApiHelperTests" /> class.
    /// </summary>
    [TestClass]
    public class ApiHelperTests
    {
        /// <summary>
        /// Gets the URI test.
        /// </summary>
        [TestMethod]
        public void GetUriTest()
        {
            // Arange
            var expectedResult = new Uri("https://api.spotify.com/test");

            // Act
            var test1 = ApiHelper.GetUri("test");

            // Assert
            Assert.AreEqual(expectedResult, test1);
        }
    }
}