namespace Test.Business
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using SpotifyWebApi.Business;
    using System;

    [TestClass]
    public class ApiHelperTests
    {
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