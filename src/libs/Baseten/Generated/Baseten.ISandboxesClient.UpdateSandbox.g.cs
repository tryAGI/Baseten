#nullable enable

namespace Baseten
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Update a sandbox<br/>
        /// Partially update configuration. Omitted fields remain unchanged; supplied arrays and maps replace their previous values. Structured objects update only supplied fields. The name, memory, network, region, image, and ports are immutable after creation. Supplying any of these fields returns 400, including unchanged, empty, or null values.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="sandboxName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.SandboxV1> UpdateSandboxAsync(
            string sandboxName,

            global::Baseten.UpdateSandboxRequestV1 request,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a sandbox<br/>
        /// Partially update configuration. Omitted fields remain unchanged; supplied arrays and maps replace their previous values. Structured objects update only supplied fields. The name, memory, network, region, image, and ports are immutable after creation. Supplying any of these fields returns 400, including unchanged, empty, or null values.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="sandboxName"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.SandboxV1>> UpdateSandboxAsResponseAsync(
            string sandboxName,

            global::Baseten.UpdateSandboxRequestV1 request,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Update a sandbox<br/>
        /// Partially update configuration. Omitted fields remain unchanged; supplied arrays and maps replace their previous values. Structured objects update only supplied fields. The name, memory, network, region, image, and ports are immutable after creation. Supplying any of these fields returns 400, including unchanged, empty, or null values.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="sandboxName"></param>
        /// <param name="lifecycle">
        /// Lifecycle configuration controlling automatic sandbox deletion based on idle time, max age, or specific dates<br/>
        /// Example: {"expiration_policies":[{"action":"DELETE","type":"TTL_IDLE","value":"24h"},{"action":"DELETE","type":"TTL_MAX_AGE","value":"7d"},{"action":"DELETE","type":"DATE","value":"2026-09-23T21:26:58Z"}],"terminated_retention":"24h"}
        /// </param>
        /// <param name="envs">
        /// Environment variables injected into the sandbox.<br/>
        /// Example: [{"name":"NODE_ENV","secret":false,"value":"production"}, {"name":"PORT","secret":false,"value":"3000"}]
        /// </param>
        /// <param name="externalId">
        /// Caller-owned identifier for external lookups. Max 64 chars, alphanumeric + dash.<br/>
        /// Example: api-review-20260916-001
        /// </param>
        /// <param name="labels">
        /// Key-value pairs for organizing and filtering resources. Labels can be used to categorize resources by environment, project, team, or any custom taxonomy.<br/>
        /// Example: {"env":"development","project":"api-review","team":"engineering","revision":"2"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.SandboxV1> UpdateSandboxAsync(
            string sandboxName,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.SandboxLifecycleV1? lifecycle = default,
            global::System.Collections.Generic.IList<global::Baseten.SandboxEnvV1>? envs = default,
            string? externalId = default,
            global::System.Collections.Generic.Dictionary<string, string>? labels = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}