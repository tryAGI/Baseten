#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Sets the snapshot a deployment's replicas hot-load<br/>
        /// Stores the request as the deployment's RL weight-sync target; every replica loads it, and the newest request wins. Returns 400 if the body is not a JSON object of at most 16384 bytes as compact JSON, or has an invalid identity or incremental_snapshot_metadata. Snapshots are not checked here; a replica that rejects one reports it in its status. Only RL deployments can hot-load, and source.token and source.api are not accepted.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/deployments/{deployment_id}/hot_load \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "identity": null,<br/>
        ///   "incremental_snapshot_metadata": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.HotLoadResponseV1> CreateModelsByModelIdDeploymentsByDeploymentIdHotLoadAsync(
            string modelId,
            string deploymentId,

            global::Baseten.HotLoadRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sets the snapshot a deployment's replicas hot-load<br/>
        /// Stores the request as the deployment's RL weight-sync target; every replica loads it, and the newest request wins. Returns 400 if the body is not a JSON object of at most 16384 bytes as compact JSON, or has an invalid identity or incremental_snapshot_metadata. Snapshots are not checked here; a replica that rejects one reports it in its status. Only RL deployments can hot-load, and source.token and source.api are not accepted.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/deployments/{deployment_id}/hot_load \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "identity": null,<br/>
        ///   "incremental_snapshot_metadata": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.HotLoadResponseV1>> CreateModelsByModelIdDeploymentsByDeploymentIdHotLoadAsResponseAsync(
            string modelId,
            string deploymentId,

            global::Baseten.HotLoadRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sets the snapshot a deployment's replicas hot-load<br/>
        /// Stores the request as the deployment's RL weight-sync target; every replica loads it, and the newest request wins. Returns 400 if the body is not a JSON object of at most 16384 bytes as compact JSON, or has an invalid identity or incremental_snapshot_metadata. Snapshots are not checked here; a replica that rejects one reports it in its status. Only RL deployments can hot-load, and source.token and source.api are not accepted.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="identity">
        /// Snapshot directory below the checkpoint prefix, for example, anchors/step000001.
        /// </param>
        /// <param name="incrementalSnapshotMetadata">
        /// Required when identity is a delta snapshot.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.HotLoadResponseV1> CreateModelsByModelIdDeploymentsByDeploymentIdHotLoadAsync(
            string modelId,
            string deploymentId,
            string identity,
            global::Baseten.HotLoadIncrementalSnapshotMetadataV1? incrementalSnapshotMetadata = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}