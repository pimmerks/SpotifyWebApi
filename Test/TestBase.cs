namespace SpotifyWebApiTest
{
    using Xunit;
    using Xunit.Abstractions;

    /// <summary>
    /// The <see cref="TestBase"/>.
    /// </summary>
    public class TestBase : IClassFixture<TestData>
    {
        /// <summary>
        /// An instance of test data.
        /// </summary>
        protected readonly TestData TestData;

        /// <summary>
        /// An instance of <see cref="ITestOutputHelper"/> to provide logging while testing.
        /// </summary>
        protected readonly ITestOutputHelper Output;

        /// <summary>
        /// The base test class.
        /// </summary>
        public TestBase(TestData testData, ITestOutputHelper output)
        {
            this.TestData = testData;
            this.Output = output;
            this.Output.WriteLine(testData.Token.ToString());
        }
    }
}
