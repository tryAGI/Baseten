#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Create a group<br/>
        /// Creates a group and its endpoint configuration
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/gateway/groups \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "metadata": {<br/>
        ///     "name": "Acme prod",<br/>
        ///     "external_entity_id": "cust_42"<br/>
        ///   },<br/>
        ///   "models": null,<br/>
        ///   "hierarchy": {<br/>
        ///     "limit_enforcement": "INDEPENDENT",<br/>
        ///     "parent_group_id": "abc123"<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.GroupV1> CreateGatewayGroupsAsync(

            global::Baseten.CreateGroupRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a group<br/>
        /// Creates a group and its endpoint configuration
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/gateway/groups \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "metadata": {<br/>
        ///     "name": "Acme prod",<br/>
        ///     "external_entity_id": "cust_42"<br/>
        ///   },<br/>
        ///   "models": null,<br/>
        ///   "hierarchy": {<br/>
        ///     "limit_enforcement": "INDEPENDENT",<br/>
        ///     "parent_group_id": "abc123"<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.GroupV1>> CreateGatewayGroupsAsResponseAsync(

            global::Baseten.CreateGroupRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a group<br/>
        /// Creates a group and its endpoint configuration
        /// </summary>
        /// <param name="metadata">
        /// Group identity + display metadata.
        /// </param>
        /// <param name="models">
        /// Per-model rate and usage limit configuration. Defines the group's complete model set. Must be non-empty.
        /// </param>
        /// <param name="hierarchy">
        /// Parent linkage and limit enforcement mode. Immutable after creation.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.GroupV1> CreateGatewayGroupsAsync(
            global::Baseten.GroupMetadataV1 metadata,
            global::System.Collections.Generic.IList<global::Baseten.ModelConfigV1> models,
            global::Baseten.GroupHierarchyV1 hierarchy,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}