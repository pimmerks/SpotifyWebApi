namespace Spotify.WebApi.Tests.Business
{
    using System;
    using Model.Exceptions;
    using WebApi.Business;
    using Xunit;

    public class UriBuilderExtensionsTest
    {
        [Fact]
        public void AddParameter_AddsParametersToUri()
        {
            var uriBuilder = new UriBuilder(ISpotifyWebApi.BaseUri);
            uriBuilder.AddParameter("test", "test");
            Assert.Equal($"{ISpotifyWebApi.BaseUri}?test=test", uriBuilder.Uri.ToString());
        }
        
        [Fact]
        public void AddParameter_AddsMultipleParametersToUri()
        {
            var uriBuilder = new UriBuilder(ISpotifyWebApi.BaseUri);

            uriBuilder.AddParameter("test1", "1");
            uriBuilder.AddParameter("test2", "2");

            Assert.Equal($"{ISpotifyWebApi.BaseUri}?test1=1&test2=2", uriBuilder.Uri.ToString());
        }
        
        [Fact]
        public void AddParameter_AddsMultipleParametersToUriFluently()
        {
            var uriBuilder = new UriBuilder(ISpotifyWebApi.BaseUri);

            uriBuilder.AddParameter("test1", "1")
                .AddParameter("test2", "2");

            Assert.Equal($"{ISpotifyWebApi.BaseUri}?test1=1&test2=2", uriBuilder.Uri.ToString());
        }
        
        [Fact]
        public void AddParameter_DoesNotAddNullValuesToUri()
        {
            var uriBuilder = new UriBuilder(ISpotifyWebApi.BaseUri);

            uriBuilder.AddParameter("test1", null);

            Assert.Equal($"{ISpotifyWebApi.BaseUri}", uriBuilder.Uri.ToString());
        }
        
        [Fact]
        public void AddParameter_ThrowsWhenOverridingParam()
        {
            var uriBuilder = new UriBuilder(ISpotifyWebApi.BaseUri);

            uriBuilder.AddParameter("test", "test");
            Assert.Throws<BaseSpotifyException>(
                () => uriBuilder.AddParameter("test", "test"));
        }
        
        [Fact]
        public void AddParameter_DoesNotThrowWithIgnoreOverride()
        {
            var uriBuilder = new UriBuilder(ISpotifyWebApi.BaseUri);

            uriBuilder.AddParameter("test", "test");
            uriBuilder.AddParameter("test", "override", true);
            
            Assert.Equal($"{ISpotifyWebApi.BaseUri}?test=override", uriBuilder.Uri.ToString());
        }
    }
}
