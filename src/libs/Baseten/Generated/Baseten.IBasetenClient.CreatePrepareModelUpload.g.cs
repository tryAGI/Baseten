#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Validates a model push payload and issues upload credentials
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/prepare_model_upload \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "deployment": {<br/>
        ///     "config": null,<br/>
        ///     "raw_config": null,<br/>
        ///     "user_env": null,<br/>
        ///     "environment_name": null,<br/>
        ///     "deploy_timeout_minutes": null,<br/>
        ///     "deployment_name": null,<br/>
        ///     "labels": null<br/>
        ///   },<br/>
        ///   "name": null,<br/>
        ///   "team_id": null,<br/>
        ///   "model_id": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.PrepareModelUploadResponseV1> CreatePrepareModelUploadAsync(

            global::Baseten.PrepareModelUploadRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validates a model push payload and issues upload credentials
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/prepare_model_upload \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "deployment": {<br/>
        ///     "config": null,<br/>
        ///     "raw_config": null,<br/>
        ///     "user_env": null,<br/>
        ///     "environment_name": null,<br/>
        ///     "deploy_timeout_minutes": null,<br/>
        ///     "deployment_name": null,<br/>
        ///     "labels": null<br/>
        ///   },<br/>
        ///   "name": null,<br/>
        ///   "team_id": null,<br/>
        ///   "model_id": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.PrepareModelUploadResponseV1>> CreatePrepareModelUploadAsResponseAsync(

            global::Baseten.PrepareModelUploadRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Validates a model push payload and issues upload credentials
        /// </summary>
        /// <param name="deployment">
        /// Deployment-level payload, identical to the payload sent at commit.
        /// </param>
        /// <param name="name">
        /// Set to validate a new-model push. Exactly one of `name` or `model_id` is required.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="teamId">
        /// Team the new model will belong to. Only valid when `name` is set; defaults to the organization's default team when omitted. Must not be set when `model_id` is set (the existing model already has a team).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="modelId">
        /// Set to validate an add-deployment push to an existing model. Exactly one of `name` or `model_id` is required.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="dryRun">
        /// If true, validate the payload only and do not issue upload credentials. The response sets `creds`, `s3_bucket`, and `s3_key` to `null`.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.PrepareModelUploadResponseV1> CreatePrepareModelUploadAsync(
            global::Baseten.DeploymentArchivePayloadV1 deployment,
            string? name = default,
            string? teamId = default,
            string? modelId = default,
            bool? dryRun = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}