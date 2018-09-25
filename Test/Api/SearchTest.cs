namespace SpotifyWebApiTest.Api
{
    using System.Threading.Tasks;
    using SpotifyWebApi.Api.Search;
    using Xunit;
    using Xunit.Abstractions;

    /// <summary>
    /// A test for the <see cref="ISearchApi"/>.
    /// </summary>
    public class SearchTest : TestBase
    {
        /// <inheritdoc />
        public SearchTest(TestData testData, ITestOutputHelper output) : base(testData, output)
        {
        }

        /// <summary>
        /// Tests the <see cref="ISearchApi.Search"/> function.
        /// </summary>
        [Fact]
        public async Task Search()
        {
            var result = await this.Api.Search.Search("test");
            Assert.NotNull(result);
        }
    }
}
