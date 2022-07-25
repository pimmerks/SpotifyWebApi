namespace SpotifyWebApi.Extensions;

using System.Net.Http.Json;
using SpotifyWebApi.Exceptions;

internal static class HttpClientExtensions
{
    /// <summary>
    /// Extension method to retrieve a specific type from an API using the provided <paramref name="httpClient"/>.
    /// Throws an <see cref="ApiException"/> when an error occurs.
    /// </summary>
    /// <param name="httpClient"></param>
    /// <param name="uri"></param>
    /// <param name="cancellationToken"></param>
    /// <param name="queryParameters"></param>
    /// <typeparam name="T">The response type.</typeparam>
    /// <returns></returns>
    /// <exception cref="ApiException">Throw when the api request has failed.</exception>
    public static async Task<T> GetAsync<T>(
        this HttpClient httpClient, string uri, CancellationToken cancellationToken = default, params KeyValuePair<string?, string?>[] queryParameters)
    {
        var query = GetQueryParameterString(queryParameters);
        var response = await httpClient.GetAsync(uri + query, cancellationToken);

        if (!response.IsSuccessStatusCode)
        {
            throw new ApiException(response.ReasonPhrase);
        }

        var obj = await response.Content.ReadFromJsonAsync<T>(cancellationToken: cancellationToken);

        if (obj is null)
        {
            throw new ApiException("Deserialization failed");
        }

        return obj;
    }

    /// <summary>
    /// Returns a query parameter string to append to an existing uri.
    /// Will only retrieve parameters where the Key and Value are both values (not null/empty).
    /// </summary>
    /// <param name="queryParameters">A array of query parameters, where the Key is the query, and the Value is the
    /// value.</param>
    /// <returns>A string based on the provided <paramref name="queryParameters"/>.</returns>
    private static string GetQueryParameterString(params KeyValuePair<string?, string?>[] queryParameters)
    {
        var param = queryParameters
                    .Where(x => !string.IsNullOrEmpty(x.Key) && !string.IsNullOrEmpty(x.Value))
                    .ToList();

        var append = string.Empty;
        if (param.Any())
        {
            append += "?" + string.Join("&", param.Select(x => $"{x.Key}={x.Value}"));
        }

        return append;
    }
}
