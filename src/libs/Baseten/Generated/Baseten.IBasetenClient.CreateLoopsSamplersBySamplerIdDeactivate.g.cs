#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Deactivates a standalone Loops sampler<br/>
        /// Shuts down a standalone Loops sampler by ID. Succeeds if it is already inactive. A sampler paired to a run always returns 409 with the run's ID, even if it is inactive.
        /// </summary>
        /// <param name="samplerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/loops/samplers/{sampler_id}/deactivate \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.DeactivateLoopsSamplerResponseV1> CreateLoopsSamplersBySamplerIdDeactivateAsync(
            string samplerId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deactivates a standalone Loops sampler<br/>
        /// Shuts down a standalone Loops sampler by ID. Succeeds if it is already inactive. A sampler paired to a run always returns 409 with the run's ID, even if it is inactive.
        /// </summary>
        /// <param name="samplerId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/loops/samplers/{sampler_id}/deactivate \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.DeactivateLoopsSamplerResponseV1>> CreateLoopsSamplersBySamplerIdDeactivateAsResponseAsync(
            string samplerId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}