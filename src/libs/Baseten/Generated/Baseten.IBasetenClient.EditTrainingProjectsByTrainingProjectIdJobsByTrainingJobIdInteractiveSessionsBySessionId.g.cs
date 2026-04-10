#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Patch an interactive session.<br/>
        /// Update specific fields on a training job's interactive session. Only provided (non-null) fields are updated.
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="trainingJobId"></param>
        /// <param name="sessionId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/training_projects/{training_project_id}/jobs/{training_job_id}/interactive_sessions/{session_id} \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "timeout_minutes": null,<br/>
        ///   "trigger": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.PatchInteractiveSessionResponseV1> EditTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdInteractiveSessionsBySessionIdAsync(
            string trainingProjectId,
            string trainingJobId,
            string sessionId,

            global::Baseten.PatchInteractiveSessionRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch an interactive session.<br/>
        /// Update specific fields on a training job's interactive session. Only provided (non-null) fields are updated.
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="trainingJobId"></param>
        /// <param name="sessionId"></param>
        /// <param name="timeoutMinutes">
        /// For on_startup sessions, minutes to add to the expiration. For on_demand/on_failure sessions, minutes to add to the timeout. Use -1 for infinite timeout (bumps by 10 years).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="trigger">
        /// Update when the interactive session is created. Cannot be changed if the session trigger is 'on_startup'.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.PatchInteractiveSessionResponseV1> EditTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdInteractiveSessionsBySessionIdAsync(
            string trainingProjectId,
            string trainingJobId,
            string sessionId,
            int? timeoutMinutes = default,
            global::Baseten.V1InteractiveSessionTrigger? trigger = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}