# Changelog

## v0.0.11
 - Change Scopes enum to bit shift style in order to make it easier to spot typos

## v0.0.10

## v0.0.9
 - Fixed a JSON deserialisation exception when trying to deserialise the timestamp into an int.

## v0.0.8
**Note:** This version might introduce some breaking changes.
 - Merged all projects to one project.
 - Added `RefreshToken()` to `AuthorizationCode`.
 - Updated Continious integration to support deployment to nuget.
 - Updated Player api.
 - Initial release that supports unit testing.
 - Initial release of the Browse api.
 - Initial release of the Search api (might not work).

## v0.0.7
 - Added implicit grant flow.

## v0.0.6
 - Updated Token with a `CanAccessPersonalData` boolean.
 - Moved Authorization code and added Client credentials auth.

## v0.0.5
 - Added TrackApi
 - Added Token.Make()
 - Added getter for SpotifyUri on Spotify objects.

## v0.0.4
 - Removed `SpotifyUri` constructor (You can now use `SpotifyUri.Make()` for various uris and ids)
 - Fixed `AddMarketCode` exception
 - `GetPlaylistTracks` now returns proper `PlaylistTracks`

## v0.0.3
 - Added Playlist api

## v0.0.2
 - Added 'netcoreapp2.0' as target framework
 - Cleanup of code

## v0.0.1
 - Initial prerelease