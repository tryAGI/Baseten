#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Create a training job.<br/>
        /// Creates a training job with the specified configuration.
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/training_projects/{training_project_id}/jobs \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "training_job": {<br/>
        ///     "image": {<br/>
        ///       "base_image": "hello-world",<br/>
        ///       "docker_auth": null<br/>
        ///     },<br/>
        ///     "compute": {<br/>
        ///       "node_count": 1,<br/>
        ///       "cpu_count": 1,<br/>
        ///       "memory": "2Gi",<br/>
        ///       "accelerator": {<br/>
        ///         "accelerator": "H100",<br/>
        ///         "count": 2<br/>
        ///       }<br/>
        ///     },<br/>
        ///     "runtime": {<br/>
        ///       "start_commands": [<br/>
        ///         "python main.py"<br/>
        ///       ],<br/>
        ///       "environment_variables": {<br/>
        ///         "API_KEY": "your_api_key_here",<br/>
        ///         "PATH": "/usr/bin"<br/>
        ///       },<br/>
        ///       "artifacts": null,<br/>
        ///       "enable_cache": true,<br/>
        ///       "cache_config": {<br/>
        ///         "enable_legacy_hf_mount": true,<br/>
        ///         "enabled": true,<br/>
        ///         "mount_base_path": "/root/.cache",<br/>
        ///         "require_cache_affinity": true<br/>
        ///       },<br/>
        ///       "checkpointing_config": {<br/>
        ///         "enabled": true,<br/>
        ///         "checkpoint_path": "/mnt/ckpts",<br/>
        ///         "volume_size_gib": 10<br/>
        ///       },<br/>
        ///       "load_checkpoint_config": null<br/>
        ///     },<br/>
        ///     "name": "gpt-oss-job",<br/>
        ///     "truss_user_env": null,<br/>
        ///     "interactive_session": null,<br/>
        ///     "weights": [<br/>
        ///       {<br/>
        ///         "allow_patterns": null,<br/>
        ///         "auth": null,<br/>
        ///         "auth_secret_name": null,<br/>
        ///         "ignore_patterns": null,<br/>
        ///         "mount_location": "/app/models/base",<br/>
        ///         "source": "hf://meta-llama/Llama-3-8B@main"<br/>
        ///       }<br/>
        ///     ],<br/>
        ///     "enable_baseten_workdir": false,<br/>
        ///     "priority": 0<br/>
        ///   }<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.CreateTrainingJobResponseV1> CreateTrainingProjectsByTrainingProjectIdJobsAsync(
            string trainingProjectId,

            global::Baseten.CreateTrainingJobRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a training job.<br/>
        /// Creates a training job with the specified configuration.
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="trainingJob">
        /// The training job to create.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.CreateTrainingJobResponseV1> CreateTrainingProjectsByTrainingProjectIdJobsAsync(
            string trainingProjectId,
            global::Baseten.CreateTrainingJobV1 trainingJob,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}