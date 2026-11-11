#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Creates a Loops trainer<br/>
        /// Creates a trainer-only Loops run in the given session, without a sampler. To sample from it, create a sampler with POST /v1/loops/samplers and pass this run's ID as run_id to pair the two. List and read the trainer through the /v1/loops/runs endpoints.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/loops/trainers \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "session_id": null,<br/>
        ///   "base_model": null,<br/>
        ///   "name": null,<br/>
        ///   "max_seq_len": null,<br/>
        ///   "seed": null,<br/>
        ///   "availability_model": "spot",<br/>
        ///   "path": "bt://loops:k4q95w5/weights/step-100",<br/>
        ///   "reuse_from_run_id": null,<br/>
        ///   "reuse_from_session_id": null,<br/>
        ///   "base_checkpoint": null,<br/>
        ///   "base_checkpoint_auth": {<br/>
        ///     "auth_method": "CUSTOM_SECRET",<br/>
        ///     "auth_secret_name": "hf_read_my_checkpoint"<br/>
        ///   },<br/>
        ///   "scope": "default"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.CreateLoopsRunResponseV1> CreateLoopsTrainersAsync(

            global::Baseten.CreateLoopsTrainerRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a Loops trainer<br/>
        /// Creates a trainer-only Loops run in the given session, without a sampler. To sample from it, create a sampler with POST /v1/loops/samplers and pass this run's ID as run_id to pair the two. List and read the trainer through the /v1/loops/runs endpoints.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/loops/trainers \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "session_id": null,<br/>
        ///   "base_model": null,<br/>
        ///   "name": null,<br/>
        ///   "max_seq_len": null,<br/>
        ///   "seed": null,<br/>
        ///   "availability_model": "spot",<br/>
        ///   "path": "bt://loops:k4q95w5/weights/step-100",<br/>
        ///   "reuse_from_run_id": null,<br/>
        ///   "reuse_from_session_id": null,<br/>
        ///   "base_checkpoint": null,<br/>
        ///   "base_checkpoint_auth": {<br/>
        ///     "auth_method": "CUSTOM_SECRET",<br/>
        ///     "auth_secret_name": "hf_read_my_checkpoint"<br/>
        ///   },<br/>
        ///   "scope": "default"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.CreateLoopsRunResponseV1>> CreateLoopsTrainersAsResponseAsync(

            global::Baseten.CreateLoopsTrainerRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a Loops trainer<br/>
        /// Creates a trainer-only Loops run in the given session, without a sampler. To sample from it, create a sampler with POST /v1/loops/samplers and pass this run's ID as run_id to pair the two. List and read the trainer through the /v1/loops/runs endpoints.
        /// </summary>
        /// <param name="sessionId">
        /// ID of the Loops session this run belongs to.
        /// </param>
        /// <param name="baseModel">
        /// Base model ID (e.g. 'Qwen/Qwen3-8B').
        /// </param>
        /// <param name="name">
        /// Optional display name for the run. Defaults to the base model name when omitted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="maxSeqLen">
        /// Maximum prompt length (in tokens) the run must handle. Set this to the longest training example you plan to send. Defaults to the maximum supported by the model configuration.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="loraRank">
        /// LoRA rank.<br/>
        /// Default Value: 64
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="scaleDownDelaySeconds">
        /// Seconds of inactivity before the run scales to zero. Must be between 1 and 3600 (1 hour). Defaults to 900 (15 minutes).<br/>
        /// Default Value: 900
        /// </param>
        /// <param name="availabilityModel">
        /// Capacity the trainer runs on. 'standard' is not preempted. 'spot' runs below inference and reaches idle reserved capacity, but the run is stopped if its GPUs are reclaimed and cannot be resumed.<br/>
        /// Default Value: standard
        /// </param>
        /// <param name="replicas">
        /// Number of data-parallel trainer replicas. Each replica is one full copy of the model's preset node group, so the trainer deployment runs (preset node_count * replicas) nodes (e.g. replicas=4 on a 4-node preset → 16 nodes, 4 DP workers). Must be a positive integer. Defaults to 1.<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="path">
        /// Optional bt:// URI of an existing checkpoint to load weights from on startup. Form: bt://loops:&lt;run_id&gt;/weights/&lt;checkpoint_name&gt;.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="reuseFromRunId">
        /// Optional ID of a prior Loops run whose trainer and/or sampler should be reused for this run instead of provisioning fresh. The prior run must use the same base model and belong to the same team.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="reuseFromSessionId">
        /// Optional ID of a prior Loops session whose trainer and/or sampler should be reused for this run. Deprecated in favor of reuse_from_run_id.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="baseCheckpoint">
        /// Optional checkpoint to start training from instead of the base model's weights: a Hugging Face repo (hf://&lt;org&gt;/&lt;repo&gt;[@&lt;revision&gt;]), an object store path (s3://, gs://, r2://, cw://, or azure://), or a full Baseten Training checkpoint in the run's team (bt://&lt;project&gt;@&lt;job_id&gt;/&lt;checkpoint&gt;, with the checkpoint named). It must be a complete, merged checkpoint in safetensors format with the same architecture as base_model, which still selects the hardware and training configuration. It must include tokenizer files: the run's sampler loads the tokenizer and chat template from the checkpoint. A Hugging Face revision is pinned to a commit when the run is created, and its files are checked then. Any other source is read again by each sampler and resumed run, so do not change it while the run is in use. Checkpoints from a run on a source outside Hugging Face cannot be deployed yet. Cannot be combined with path, reuse_from_run_id, or reuse_from_session_id.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="baseCheckpointAuth">
        /// Optional credentials that read base_checkpoint. Only CUSTOM_SECRET is supported: set auth_secret_name to the team secret that holds a Hugging Face token for a Hugging Face repo, or the credentials for an object store. A Baseten Training checkpoint takes no auth. The run, its samplers, resumed runs, and checkpoint deployments all use this secret. When omitted, a Hugging Face repo is read with the team secret hf_access_token if it exists. Requires base_checkpoint.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="scope">
        /// Choose where this runs. 'default' lets Baseten choose. 'serverless' runs on Baseten's shared capacity, and fails instead of falling back when shared capacity can't serve the request. 'dedicated' gives it its own deployment, which you size and pay for.<br/>
        /// Default Value: default
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.CreateLoopsRunResponseV1> CreateLoopsTrainersAsync(
            string sessionId,
            string baseModel,
            string? name = default,
            int? maxSeqLen = default,
            int? loraRank = default,
            int? seed = default,
            int? scaleDownDelaySeconds = default,
            global::Baseten.AvailabilityModelV1? availabilityModel = default,
            int? replicas = default,
            string? path = default,
            string? reuseFromRunId = default,
            string? reuseFromSessionId = default,
            string? baseCheckpoint = default,
            global::Baseten.TrainingWeightAuthV1? baseCheckpointAuth = default,
            global::Baseten.LoopsPlacementScopeV1? scope = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}