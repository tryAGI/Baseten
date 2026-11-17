#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Lists replicas for an environment<br/>
        /// Includes retained terminated replicas from deployments active in the preceding hour. Orders replicas oldest first, with replica ID breaking ties. Pass pagination.cursor with unchanged filters for subsequent pages. Cursors pin deployment membership and expire after one hour.
        /// </summary>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="statuses"></param>
        /// <param name="modelId"></param>
        /// <param name="envName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/environments/{env_name}/replicas \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.DeploymentReplicasV1> GetModelsByModelIdEnvironmentsByEnvNameReplicasAsync(
            string modelId,
            string envName,
            string? cursor = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::Baseten.DeploymentReplicaStatusV1>? statuses = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Lists replicas for an environment<br/>
        /// Includes retained terminated replicas from deployments active in the preceding hour. Orders replicas oldest first, with replica ID breaking ties. Pass pagination.cursor with unchanged filters for subsequent pages. Cursors pin deployment membership and expire after one hour.
        /// </summary>
        /// <param name="cursor">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Default Value: 100
        /// </param>
        /// <param name="statuses"></param>
        /// <param name="modelId"></param>
        /// <param name="envName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/environments/{env_name}/replicas \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.DeploymentReplicasV1>> GetModelsByModelIdEnvironmentsByEnvNameReplicasAsResponseAsync(
            string modelId,
            string envName,
            string? cursor = default,
            int? limit = default,
            global::System.Collections.Generic.IList<global::Baseten.DeploymentReplicaStatusV1>? statuses = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}