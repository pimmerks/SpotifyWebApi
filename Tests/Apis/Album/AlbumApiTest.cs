﻿namespace Spotify.WebApi.Tests.Apis.Album
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Model.Authentication;
    using Model.Objects.Albums;
    using Moq;
    using Moq.Protected;
    using WebApi.Apis.Album;
    using WebApi.Business;
    using Xunit;

    public class AlbumApiTest
    {
        [Fact]
        public async Task GetAlbumAsyncTest()
        {
            // Arrange
            var handlerMock = new Mock<HttpMessageHandler>(MockBehavior.Strict);
            handlerMock
                .Protected()
                .Setup<Task<HttpResponseMessage>>(
                    "SendAsync",
                    ItExpr.IsAny<HttpRequestMessage>(),
                    ItExpr.IsAny<CancellationToken>()
                )
                .ReturnsAsync(new HttpResponseMessage
                {
                    StatusCode = HttpStatusCode.OK,
                    Content = new StringContent(AlbumApiTest.GetAlbumResult),
                })
                .Verifiable();
            
            var albumApi = new AlbumApi(Token.Make(""), new HttpClient(handlerMock.Object), new Serializer());

            // Act
            var album = await albumApi.GetAlbumAsync("0sNOF9WDwhWunNAHPD3Baj");

            // Assert
            Assert.NotNull(album);
            Assert.Equal("album", album.Type);
        }
        
        private const string GetAlbumResult = @"{
  ""album_type"" : ""album"",
  ""artists"" : [ {
    ""external_urls"" : {
      ""spotify"" : ""https://open.spotify.com/artist/2BTZIqw0ntH9MvilQ3ewNY""
    },
    ""href"" : ""https://api.spotify.com/v1/artists/2BTZIqw0ntH9MvilQ3ewNY"",
    ""id"" : ""2BTZIqw0ntH9MvilQ3ewNY"",
    ""name"" : ""Cyndi Lauper"",
    ""type"" : ""artist"",
    ""uri"" : ""spotify:artist:2BTZIqw0ntH9MvilQ3ewNY""
  } ],
  ""available_markets"" : [ ""AD"", ""AR"", ""AT"", ""AU"", ""BE"", ""BG"", ""BO"", ""BR"", ""CA"", ""CH"", ""CL"", ""CO"", ""CR"", ""CY"", ""CZ"", ""DE"", ""DK"", ""DO"", ""EC"", ""EE"", ""ES"", ""FI"", ""FR"", ""GB"", ""GR"", ""GT"", ""HK"", ""HN"", ""HU"", ""IE"", ""IS"", ""IT"", ""LI"", ""LT"", ""LU"", ""LV"", ""MC"", ""MT"", ""MX"", ""MY"", ""NI"", ""NL"", ""NO"", ""NZ"", ""PA"", ""PE"", ""PH"", ""PT"", ""PY"", ""RO"", ""SE"", ""SG"", ""SI"", ""SK"", ""SV"", ""TW"", ""UY"" ],
  ""copyrights"" : [ {
    ""text"" : ""(P) 2000 Sony Music Entertainment Inc."",
    ""type"" : ""P""
  } ],
  ""external_ids"" : {
    ""upc"" : ""5099749994324""
  },
  ""external_urls"" : {
    ""spotify"" : ""https://open.spotify.com/album/0sNOF9WDwhWunNAHPD3Baj""
  },
  ""genres"" : [ ],
  ""href"" : ""https://api.spotify.com/v1/albums/0sNOF9WDwhWunNAHPD3Baj"",
  ""id"" : ""0sNOF9WDwhWunNAHPD3Baj"",
  ""images"" : [ {
    ""height"" : 640,
    ""url"" : ""https://i.scdn.co/image/07c323340e03e25a8e5dd5b9a8ec72b69c50089d"",
    ""width"" : 640
  }, {
    ""height"" : 300,
    ""url"" : ""https://i.scdn.co/image/8b662d81966a0ec40dc10563807696a8479cd48b"",
    ""width"" : 300
  }, {
    ""height"" : 64,
    ""url"" : ""https://i.scdn.co/image/54b3222c8aaa77890d1ac37b3aaaa1fc9ba630ae"",
    ""width"" : 64
  } ],
  ""name"" : ""She's So Unusual"",
  ""popularity"" : 39,
  ""release_date"" : ""1983"",
  ""release_date_precision"" : ""year"",
  ""tracks"" : {
    ""href"" : ""https://api.spotify.com/v1/albums/0sNOF9WDwhWunNAHPD3Baj/tracks?offset=0&limit=50"",
    ""items"" : [ {
      ""artists"" : [ {
        ""external_urls"" : {
          ""spotify"" : ""https://open.spotify.com/artist/2BTZIqw0ntH9MvilQ3ewNY""
        },
        ""href"" : ""https://api.spotify.com/v1/artists/2BTZIqw0ntH9MvilQ3ewNY"",
        ""id"" : ""2BTZIqw0ntH9MvilQ3ewNY"",
        ""name"" : ""Cyndi Lauper"",
        ""type"" : ""artist"",
        ""uri"" : ""spotify:artist:2BTZIqw0ntH9MvilQ3ewNY""
      } ],
      ""available_markets"" : [ ""AD"", ""AR"", ""AT"", ""AU"", ""BE"", ""BG"", ""BO"", ""BR"", ""CA"", ""CH"", ""CL"", ""CO"", ""CR"", ""CY"", ""CZ"", ""DE"", ""DK"", ""DO"", ""EC"", ""EE"", ""ES"", ""FI"", ""FR"", ""GB"", ""GR"", ""GT"", ""HK"", ""HN"", ""HU"", ""IE"", ""IS"", ""IT"", ""LI"", ""LT"", ""LU"", ""LV"", ""MC"", ""MT"", ""MX"", ""MY"", ""NI"", ""NL"", ""NO"", ""NZ"", ""PA"", ""PE"", ""PH"", ""PT"", ""PY"", ""RO"", ""SE"", ""SG"", ""SI"", ""SK"", ""SV"", ""TW"", ""UY"" ],
      ""disc_number"" : 1,
      ""duration_ms"" : 305560,
      ""explicit"" : false,
      ""external_urls"" : {
        ""spotify"" : ""https://open.spotify.com/track/3f9zqUnrnIq0LANhmnaF0V""
      },
      ""href"" : ""https://api.spotify.com/v1/tracks/3f9zqUnrnIq0LANhmnaF0V"",
      ""id"" : ""3f9zqUnrnIq0LANhmnaF0V"",
      ""name"" : ""Money Changes Everything"",
      ""preview_url"" : ""https://p.scdn.co/mp3-preview/01bb2a6c9a89c05a4300aea427241b1719a26b06"",
      ""track_number"" : 1,
      ""type"" : ""track"",
      ""uri"" : ""spotify:track:3f9zqUnrnIq0LANhmnaF0V""
    }],
    ""limit"" : 50,
    ""next"" : null,
    ""offset"" : 0,
    ""previous"" : null,
    ""total"" : 13
  },
  ""type"" : ""album"",
  ""uri"" : ""spotify:album:0sNOF9WDwhWunNAHPD3Baj""
}";
    }
}
