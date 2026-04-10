#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Create a model weight snapshot<br/>
        /// Creates a model weight snapshot for the specified model and returns the snapshot.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/model_apis/snapshots/{model_id} \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "model": null,<br/>
        ///   "snapshot_uri": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.ModelWeightSnapshotV1> CreateModelApisSnapshotsByModelIdAsync(
            string modelId,

            global::Baseten.CreateModelWeightSnapshotRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a model weight snapshot<br/>
        /// Creates a model weight snapshot for the specified model and returns the snapshot.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="model">
        /// Unique identifier of the model
        /// </param>
        /// <param name="snapshotUri">
        /// Path to the model weight snapshot
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.ModelWeightSnapshotV1> CreateModelApisSnapshotsByModelIdAsync(
            string modelId,
            string model,
            string snapshotUri,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}