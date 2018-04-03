# Changelog

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