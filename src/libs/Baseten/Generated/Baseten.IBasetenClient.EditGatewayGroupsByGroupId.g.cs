#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Updates a group<br/>
        /// Updates the group's mutable fields.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/gateway/groups/{group_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "metadata": {<br/>
        ///     "name": "Acme Prod"<br/>
        ///   },<br/>
        ///   "models": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.GroupV1> EditGatewayGroupsByGroupIdAsync(
            string groupId,

            global::Baseten.UpdateGroupRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a group<br/>
        /// Updates the group's mutable fields.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/gateway/groups/{group_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "metadata": {<br/>
        ///     "name": "Acme Prod"<br/>
        ///   },<br/>
        ///   "models": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.GroupV1>> EditGatewayGroupsByGroupIdAsResponseAsync(
            string groupId,

            global::Baseten.UpdateGroupRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a group<br/>
        /// Updates the group's mutable fields.
        /// </summary>
        /// <param name="groupId"></param>
        /// <param name="metadata">
        /// Mutable group metadata.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="models">
        /// Per-model rate and usage limit configuration.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.GroupV1> EditGatewayGroupsByGroupIdAsync(
            string groupId,
            global::Baseten.UpdateGroupMetadataV1? metadata = default,
            global::System.Collections.Generic.IList<global::Baseten.ModelConfigV1>? models = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}