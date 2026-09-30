#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Clears default models for a coding harness<br/>
        /// Removes the team's routes for every role of the harness, so each role uses Baseten's default. Requires team admin.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="harness"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/routes/harness-configs/{harness} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.RouteHarnessConfigTombstoneV1> DeleteRoutesHarnessConfigsByHarnessAsync(
            string teamId,
            string harness,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Clears default models for a coding harness<br/>
        /// Removes the team's routes for every role of the harness, so each role uses Baseten's default. Requires team admin.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="harness"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/routes/harness-configs/{harness} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.RouteHarnessConfigTombstoneV1>> DeleteRoutesHarnessConfigsByHarnessAsResponseAsync(
            string teamId,
            string harness,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}