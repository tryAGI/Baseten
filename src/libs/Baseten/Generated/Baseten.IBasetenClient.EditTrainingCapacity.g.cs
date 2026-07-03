#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Set a team's training GPU capacity.<br/>
        /// Sets the max concurrent GPUs of a given type a team may use. Creates the limit if one doesn't exist for this (team, gpu_type) pair, otherwise updates it in place. Org-admin only: this is a ceiling the org imposes on the team, not something the team manages for itself.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/training/capacity \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "team_id": null,<br/>
        ///   "gpu_type": null,<br/>
        ///   "max_gpus": 8<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.PatchTeamTrainingGpuCapacityResponseV1> EditTrainingCapacityAsync(

            global::Baseten.PatchTeamTrainingGpuCapacityRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a team's training GPU capacity.<br/>
        /// Sets the max concurrent GPUs of a given type a team may use. Creates the limit if one doesn't exist for this (team, gpu_type) pair, otherwise updates it in place. Org-admin only: this is a ceiling the org imposes on the team, not something the team manages for itself.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/training/capacity \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "team_id": null,<br/>
        ///   "gpu_type": null,<br/>
        ///   "max_gpus": 8<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.PatchTeamTrainingGpuCapacityResponseV1>> EditTrainingCapacityAsResponseAsync(

            global::Baseten.PatchTeamTrainingGpuCapacityRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Set a team's training GPU capacity.<br/>
        /// Sets the max concurrent GPUs of a given type a team may use. Creates the limit if one doesn't exist for this (team, gpu_type) pair, otherwise updates it in place. Org-admin only: this is a ceiling the org imposes on the team, not something the team manages for itself.
        /// </summary>
        /// <param name="teamId">
        /// Team identifier
        /// </param>
        /// <param name="gpuType">
        /// GPU type identifier (e.g. H100, A100-40GB)
        /// </param>
        /// <param name="maxGpus">
        /// Max concurrent GPUs of this type the team may use
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.PatchTeamTrainingGpuCapacityResponseV1> EditTrainingCapacityAsync(
            string teamId,
            string gpuType,
            int maxGpus,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}