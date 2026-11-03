#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Creates a machine user<br/>
        /// Creates a team-owned identity for an application, with its own Grid budget. Set `api_key` to also create its first API key, which the response returns only once. Set the machine user's spend limit with the user settings endpoint, using its `id` as the user ID. Requires team admin.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/grid/machine_users \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "team_id": "abc1234",<br/>
        ///   "name": "night-shift",<br/>
        ///   "api_key": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.CreatedGridMachineUserV1> CreateGridMachineUsersAsync(

            global::Baseten.CreateGridMachineUserRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a machine user<br/>
        /// Creates a team-owned identity for an application, with its own Grid budget. Set `api_key` to also create its first API key, which the response returns only once. Set the machine user's spend limit with the user settings endpoint, using its `id` as the user ID. Requires team admin.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/grid/machine_users \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "team_id": "abc1234",<br/>
        ///   "name": "night-shift",<br/>
        ///   "api_key": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.CreatedGridMachineUserV1>> CreateGridMachineUsersAsResponseAsync(

            global::Baseten.CreateGridMachineUserRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a machine user<br/>
        /// Creates a team-owned identity for an application, with its own Grid budget. Set `api_key` to also create its first API key, which the response returns only once. Set the machine user's spend limit with the user settings endpoint, using its `id` as the user ID. Requires team admin.
        /// </summary>
        /// <param name="teamId">
        /// Identifier of the team that owns the machine user. Defaults to your only team, if you belong to exactly one.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="name">
        /// Name of the machine user, unique within the team. At most 255 characters.
        /// </param>
        /// <param name="apiKey">
        /// When set, also creates the machine user's first API key.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.CreatedGridMachineUserV1> CreateGridMachineUsersAsync(
            string name,
            string? teamId = default,
            global::Baseten.CreateGridMachineUserAPIKeyRequestV1? apiKey = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}