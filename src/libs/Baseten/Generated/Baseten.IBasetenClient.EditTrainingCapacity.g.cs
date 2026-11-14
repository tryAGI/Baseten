#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Sets a team's training GPU quota<br/>
        /// Sets a team's GPU quota for a given type. It counts the team's on-demand jobs, plus its spot jobs when the organization has no separate on-demand quota, and on-demand jobs can borrow past it from the organization's shared pool when one exists. Creates the quota if one doesn't exist for this (team, gpu_type) pair, otherwise updates it in place. Org-admin only: this is a quota the org imposes on the team, not something the team manages for itself.
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
        /// Sets a team's training GPU quota<br/>
        /// Sets a team's GPU quota for a given type. It counts the team's on-demand jobs, plus its spot jobs when the organization has no separate on-demand quota, and on-demand jobs can borrow past it from the organization's shared pool when one exists. Creates the quota if one doesn't exist for this (team, gpu_type) pair, otherwise updates it in place. Org-admin only: this is a quota the org imposes on the team, not something the team manages for itself.
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
        /// Sets a team's training GPU quota<br/>
        /// Sets a team's GPU quota for a given type. It counts the team's on-demand jobs, plus its spot jobs when the organization has no separate on-demand quota, and on-demand jobs can borrow past it from the organization's shared pool when one exists. Creates the quota if one doesn't exist for this (team, gpu_type) pair, otherwise updates it in place. Org-admin only: this is a quota the org imposes on the team, not something the team manages for itself.
        /// </summary>
        /// <param name="teamId">
        /// Team identifier
        /// </param>
        /// <param name="gpuType">
        /// GPU type identifier (e.g. H100, A100-40GB)
        /// </param>
        /// <param name="maxGpus">
        /// The team's GPU quota for this type. It counts the team's on-demand jobs, plus its spot jobs when the organization has no separate on-demand quota. On-demand jobs can run past it by borrowing from the organization's shared pool, when one exists.
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