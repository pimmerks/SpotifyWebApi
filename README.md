[![NuGet version (SpotifyWebApi-Core)](https://img.shields.io/nuget/v/SpotifyWebApi-Core.svg)](https://www.nuget.org/packages/SpotifyWebApi-Core/) 
[![NuGet](https://img.shields.io/nuget/dt/SpotifyWebApi-Core.svg)](https://www.nuget.org/packages/SpotifyWebApi-Core/) 
[![Read the Docs](https://img.shields.io/readthedocs/pip.svg)](https://pimmerks.github.io/SpotifyWebApi/) 
[![license](https://img.shields.io/github/license/mashape/apistatus.svg)](https://github.com/pimmerks/SpotifyWebApi/blob/master/LICENSE) 


# SpotifyWebApi - Core
A .net Core wrapper for the Spotify Web Api.

# Nuget package
Installing the package is easy.

Using the package manager console:
> `PM> Install-Package SpotifyWebApi-Core`


Using the dotnet CLI:
> `> dotnet add package SpotifyWebApi-Core`

## Getting an authentication token

### Client credentials:

```csharp
var token = ClientCredentials.GetToken(new AuthParameters
{
    ClientId = "clientId",
    ClientSecret = "clientSecret",
    Scopes = Scope.All,
});
```
Note: A client credentials token cannot access any personal data.  
The `Token` class has a usefull property to check this: `token.CanAccessPersonalData`  

### Authorization code:
Start the authorization code process by retrieving the authentication url:
```csharp
var state = Guid.NewGuid().ToString(); // Save this state because you must check it later

var parameters = new AuthParameters
{
    ClientId = "clientId",
    ClientSecret = "clientSecret",
    RedirectUri = "https://.../callback",
    Scopes = Scope.All,
    ShowDialog = true
};

var url = AuthorizationCode.GetUrl(parameters, state);
```
At this point you should start a webserver listening on the `RedirectUri` and the the client/user should login to Spotify.  
The webserver should expect the following query parameters: `?code=code&state=state&error=error`
```csharp
// The retreived callback:
var retrievedState = "retrievedState";
var retrievedCode = "code";
var retreivedError = "";

if (state != retrievedState)
{
    throw new Exception("State did not match!");
}

var token = AuthorizationCode.ProcessCallback(parameters, retrievedCode, retreivedError);

// Use the api with access to personal data.
var api = new SpotifyWebApi(token);
var me = await api.UserProfile.GetMe();
```

A token received with the `AuthorizationCode` can also be refreshed:
```csharp
// Refresh a token when its expired
if (token.IsExpired)
{
    token = AuthorizationCode.RefreshToken(parameters, token);
}
```

## Using the api
After a token has been retrieved, we can use the api:

Getting a playlist and the playlist tracks:
```csharp
ISpotifyWebApi api = new SpotifyWebApi(token);

var playlist = await spotify.Playlist.GetPlaylist(id);
var tracks = await spotify.Playlist.GetPlaylistTracks(id);
```

## TODO:
 - TODO: Add documentation  
 - TODO: Add api examples
