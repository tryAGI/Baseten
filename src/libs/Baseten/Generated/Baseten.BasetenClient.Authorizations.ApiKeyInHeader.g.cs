
#nullable enable

namespace Baseten
{
    public sealed partial class BasetenClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::Baseten.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "Authorization",
                Value = apiKey,
            });
        }
    }
}