namespace Baseten;

public sealed partial class BasetenClient
{
    /// <summary>
    /// Rewrites the Authorization header value to use the <c>Api-Key</c> prefix
    /// expected by the Baseten API.
    /// The generated code sets the raw API key value; this hook prepends <c>Api-Key </c>.
    /// </summary>
#pragma warning disable CA1822 // Mark members as static
    partial void Authorizing(
        global::System.Net.Http.HttpClient client,
        ref string apiKey)
    {
#pragma warning restore CA1822
        if (!apiKey.StartsWith("Api-Key ", StringComparison.OrdinalIgnoreCase))
        {
            apiKey = $"Api-Key {apiKey}";
        }
    }
}
