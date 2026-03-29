#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Get the metrics for a training job.<br/>
        /// Get the metrics for a training job.
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="trainingJobId"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/training_projects/{training_project_id}/jobs/{training_job_id}/metrics \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "end_epoch_millis": null,<br/>
        ///   "start_epoch_millis": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.GetTrainingJobMetricsResponseV1> CreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdMetricsAsync(
            string trainingProjectId,
            string trainingJobId,

            global::Baseten.GetTrainingJobMetricsRequestV1 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get the metrics for a training job.<br/>
        /// Get the metrics for a training job.
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="trainingJobId"></param>
        /// <param name="endEpochMillis">
        /// Epoch millis timestamp to end fetching metrics<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="startEpochMillis">
        /// Epoch millis timestamp to start fetching metrics.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.GetTrainingJobMetricsResponseV1> CreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdMetricsAsync(
            string trainingProjectId,
            string trainingJobId,
            int? endEpochMillis = default,
            int? startEpochMillis = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}