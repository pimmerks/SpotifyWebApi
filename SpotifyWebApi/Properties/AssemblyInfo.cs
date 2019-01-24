// Internals only visible for testing purpose.

using System.Runtime.CompilerServices;
using Fody;

[assembly: InternalsVisibleTo("SpotifyWebApiTest")]
[assembly: ConfigureAwait(false)]