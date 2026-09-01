#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Creates a volume access token<br/>
        /// Exchanges your API key for a short-lived token that authenticates against Baseten volume storage. A volume token is needed only to push and pull volume data; other volume operations use your API key directly. Tokens expire after one hour and cannot be renewed; exchange again for a fresh token. Push and tag capabilities require organization-level model management permission. Pass correlation_id to link the issued token to a client operation in server logs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/volumes/token \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "scopes": null,<br/>
        ///   "namespaces": null,<br/>
        ///   "correlation_id": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.CreateVolumeTokenResponseV1> CreateVolumesTokenAsync(

            global::Baseten.CreateVolumeTokenRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a volume access token<br/>
        /// Exchanges your API key for a short-lived token that authenticates against Baseten volume storage. A volume token is needed only to push and pull volume data; other volume operations use your API key directly. Tokens expire after one hour and cannot be renewed; exchange again for a fresh token. Push and tag capabilities require organization-level model management permission. Pass correlation_id to link the issued token to a client operation in server logs.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/volumes/token \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "scopes": null,<br/>
        ///   "namespaces": null,<br/>
        ///   "correlation_id": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.CreateVolumeTokenResponseV1>> CreateVolumesTokenAsResponseAsync(

            global::Baseten.CreateVolumeTokenRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a volume access token<br/>
        /// Exchanges your API key for a short-lived token that authenticates against Baseten volume storage. A volume token is needed only to push and pull volume data; other volume operations use your API key directly. Tokens expire after one hour and cannot be renewed; exchange again for a fresh token. Push and tag capabilities require organization-level model management permission. Pass correlation_id to link the issued token to a client operation in server logs.
        /// </summary>
        /// <param name="scopes">
        /// Capabilities the token grants, at least one. Requesting PUSH or TAG requires organization-level model management permission.
        /// </param>
        /// <param name="namespaces">
        /// Volume namespaces the token is limited to, lowercase ASCII, at least one. Pass only the namespaces the operation needs.
        /// </param>
        /// <param name="correlationId">
        /// Optional client-chosen identifier, at most 128 printable ASCII characters. Echoed into server logs to link the issued token to a client operation.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.CreateVolumeTokenResponseV1> CreateVolumesTokenAsync(
            global::System.Collections.Generic.IList<global::Baseten.VolumeTokenScopeV1> scopes,
            global::System.Collections.Generic.IList<string> namespaces,
            string? correlationId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}