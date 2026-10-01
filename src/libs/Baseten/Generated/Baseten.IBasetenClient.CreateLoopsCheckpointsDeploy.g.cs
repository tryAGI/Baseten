#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Deploys Loops checkpoints<br/>
        /// Creates an inference deployment from one or more Loops sampler checkpoints. Confirm the user intends to create billable resources before calling it. This operation is not idempotent; repeating the request can create another deployment.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/loops/checkpoints/deploy \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "checkpoint_ids": null,<br/>
        ///   "model_name": null,<br/>
        ///   "instance_type_id": null,<br/>
        ///   "hf_secret_name": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.DeployLoopsCheckpointResponseV1> CreateLoopsCheckpointsDeployAsync(

            global::Baseten.DeployLoopsCheckpointRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deploys Loops checkpoints<br/>
        /// Creates an inference deployment from one or more Loops sampler checkpoints. Confirm the user intends to create billable resources before calling it. This operation is not idempotent; repeating the request can create another deployment.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/loops/checkpoints/deploy \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "checkpoint_ids": null,<br/>
        ///   "model_name": null,<br/>
        ///   "instance_type_id": null,<br/>
        ///   "hf_secret_name": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.DeployLoopsCheckpointResponseV1>> CreateLoopsCheckpointsDeployAsResponseAsync(

            global::Baseten.DeployLoopsCheckpointRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deploys Loops checkpoints<br/>
        /// Creates an inference deployment from one or more Loops sampler checkpoints. Confirm the user intends to create billable resources before calling it. This operation is not idempotent; repeating the request can create another deployment.
        /// </summary>
        /// <param name="checkpointIds">
        /// Sampler checkpoint IDs to deploy together.
        /// </param>
        /// <param name="modelName">
        /// Name for the created model.
        /// </param>
        /// <param name="instanceTypeId">
        /// Instance type ID for the deployment.
        /// </param>
        /// <param name="hfSecretName">
        /// Name of the team-scoped secret that supplies HF_TOKEN.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.DeployLoopsCheckpointResponseV1> CreateLoopsCheckpointsDeployAsync(
            global::System.Collections.Generic.IList<string> checkpointIds,
            string modelName,
            string instanceTypeId,
            string hfSecretName,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}