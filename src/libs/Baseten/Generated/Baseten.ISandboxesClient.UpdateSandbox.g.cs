#nullable enable

namespace Baseten
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Update a sandbox<br/>
        /// Partially update configuration. Omitted fields remain unchanged; supplied arrays and maps replace their previous values. Structured objects update only supplied fields. Changes to image may reset running state. The name, memory, and network configuration are immutable after creation. Supplying memory or network returns 400, including unchanged, empty, or null values.
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
        /// Partially update configuration. Omitted fields remain unchanged; supplied arrays and maps replace their previous values. Structured objects update only supplied fields. Changes to image may reset running state. The name, memory, and network configuration are immutable after creation. Supplying memory or network returns 400, including unchanged, empty, or null values.
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
        /// Partially update configuration. Omitted fields remain unchanged; supplied arrays and maps replace their previous values. Structured objects update only supplied fields. Changes to image may reset running state. The name, memory, and network configuration are immutable after creation. Supplying memory or network returns 400, including unchanged, empty, or null values.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="sandboxName"></param>
        /// <param name="enabled">
        /// When false, the sandbox is disabled and will not accept connections<br/>
        /// Example: true
        /// </param>
        /// <param name="lifecycle">
        /// Lifecycle configuration controlling automatic sandbox deletion based on idle time, max age, or specific dates<br/>
        /// Example: {"expiration_policies":[{"action":"DELETE","type":"TTL_IDLE","value":"24h"},{"action":"DELETE","type":"TTL_MAX_AGE","value":"7d"},{"action":"DELETE","type":"DATE","value":"2026-09-23T21:26:58Z"}],"terminated_retention":"24h"}
        /// </param>
        /// <param name="region">
        /// Region where the sandbox runs (for example us-pdx-1 or eu-lon-1). When omitted at creation, the closest region is selected.<br/>
        /// Example: us-pdx-1
        /// </param>
        /// <param name="envs">
        /// Environment variables injected into the sandbox.<br/>
        /// Example: [{"name":"NODE_ENV","secret":false,"value":"production"}, {"name":"PORT","secret":false,"value":"3000"}]
        /// </param>
        /// <param name="image">
        /// Image reference including its tag. Use blaxel/base-image:latest to get started with the built-in sandbox execution API. This image is available directly without building, pushing, or listing images through GET /v1/sandboxes/images.<br/>
        /// Example: blaxel/base-image:latest
        /// </param>
        /// <param name="ports">
        /// Set of ports for a resource<br/>
        /// Example: [{"name":"http","protocol":"HTTP","target":3000}]
        /// </param>
        /// <param name="displayName">
        /// Human-readable name for display in the UI. Can contain spaces and special characters, max 63 characters.<br/>
        /// Example: Baseten API review - revised
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
            bool? enabled = default,
            global::Baseten.SandboxLifecycleV1? lifecycle = default,
            string? region = default,
            global::System.Collections.Generic.IList<global::Baseten.SandboxEnvV1>? envs = default,
            string? image = default,
            global::System.Collections.Generic.IList<global::Baseten.SandboxPortV1>? ports = default,
            string? displayName = default,
            string? externalId = default,
            global::System.Collections.Generic.Dictionary<string, string>? labels = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}