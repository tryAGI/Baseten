#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Look up trainer checkpoint info by bt:// URI.<br/>
        /// Look up the metadata for a trainer checkpoint by its bt://trainers:&lt;trainer_id&gt;/(weights|sampler_weights)/&lt;name&gt; URI.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/trainers/checkpoints/search \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "checkpoint_path": "bt://trainers:k4q95w5/sampler_weights/step-100"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.CheckpointSearchResponseV1> CreateTrainersCheckpointsSearchAsync(

            global::Baseten.CheckpointSearchRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Look up trainer checkpoint info by bt:// URI.<br/>
        /// Look up the metadata for a trainer checkpoint by its bt://trainers:&lt;trainer_id&gt;/(weights|sampler_weights)/&lt;name&gt; URI.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/trainers/checkpoints/search \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "checkpoint_path": "bt://trainers:k4q95w5/sampler_weights/step-100"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.CheckpointSearchResponseV1>> CreateTrainersCheckpointsSearchAsResponseAsync(

            global::Baseten.CheckpointSearchRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Look up trainer checkpoint info by bt:// URI.<br/>
        /// Look up the metadata for a trainer checkpoint by its bt://trainers:&lt;trainer_id&gt;/(weights|sampler_weights)/&lt;name&gt; URI.
        /// </summary>
        /// <param name="checkpointPath">
        /// bt:// URI of a trainer checkpoint. Form: bt://trainers:&lt;trainer_id&gt;/(weights|sampler_weights)/&lt;checkpoint_name&gt;.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.CheckpointSearchResponseV1> CreateTrainersCheckpointsSearchAsync(
            string checkpointPath,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}