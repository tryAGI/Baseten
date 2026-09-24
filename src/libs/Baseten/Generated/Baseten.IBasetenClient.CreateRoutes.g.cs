#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Creates a route<br/>
        /// Dedicated deployment targets are not supported.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/routes \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "name": "my-org/assistant",<br/>
        ///   "team_id": "abc1234",<br/>
        ///   "display_name": "Assistant",<br/>
        ///   "target": {<br/>
        ///     "model": "zai-org/GLM-5.3",<br/>
        ///     "type": "BASETEN_MODEL_API"<br/>
        ///   },<br/>
        ///   "description": "Assistant for code review and debugging.",<br/>
        ///   "metadata_slug": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.RouteV1> CreateRoutesAsync(

            global::Baseten.CreateRouteRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a route<br/>
        /// Dedicated deployment targets are not supported.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/routes \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "name": "my-org/assistant",<br/>
        ///   "team_id": "abc1234",<br/>
        ///   "display_name": "Assistant",<br/>
        ///   "target": {<br/>
        ///     "model": "zai-org/GLM-5.3",<br/>
        ///     "type": "BASETEN_MODEL_API"<br/>
        ///   },<br/>
        ///   "description": "Assistant for code review and debugging.",<br/>
        ///   "metadata_slug": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.RouteV1>> CreateRoutesAsResponseAsync(

            global::Baseten.CreateRouteRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a route<br/>
        /// Dedicated deployment targets are not supported.
        /// </summary>
        /// <param name="name">
        /// Immutable, globally unique route name using an organization-owned prefix.
        /// </param>
        /// <param name="teamId">
        /// Identifier of the team that owns the route. When omitted, uses your organization's default team.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="displayName">
        /// Display label. Omit to use the route name; null is not accepted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="target">
        /// Upstream target for the route.
        /// </param>
        /// <param name="description">
        /// Short description of the route. Omit for no description; null is not accepted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="metadataSlug">
        /// Slug of a metadata row to link. Omit to auto-resolve from the target; required for OPENAI_COMPATIBLE and VERTEX targets.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.RouteV1> CreateRoutesAsync(
            string name,
            global::Baseten.Target2 target,
            string? teamId = default,
            string? displayName = default,
            string? description = default,
            string? metadataSlug = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}