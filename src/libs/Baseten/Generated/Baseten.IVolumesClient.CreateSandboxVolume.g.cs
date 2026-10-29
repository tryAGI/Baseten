#nullable enable

namespace Baseten
{
    public partial interface IVolumesClient
    {
        /// <summary>
        /// Create a volume<br/>
        /// Create a persistent volume that outlives the sandboxes it is mounted in. Mount it at sandbox creation with the volumes field; a volume is mounted in at most one sandbox at a time and must be in the same region. The name is generated when omitted. Volume size and count are limited by the team's plan.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.SandboxVolumeV1> CreateSandboxVolumeAsync(

            global::Baseten.CreateSandboxVolumeRequestV1 request,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a volume<br/>
        /// Create a persistent volume that outlives the sandboxes it is mounted in. Mount it at sandbox creation with the volumes field; a volume is mounted in at most one sandbox at a time and must be in the same region. The name is generated when omitted. Volume size and count are limited by the team's plan.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.SandboxVolumeV1>> CreateSandboxVolumeAsResponseAsync(

            global::Baseten.CreateSandboxVolumeRequestV1 request,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Create a volume<br/>
        /// Create a persistent volume that outlives the sandboxes it is mounted in. Mount it at sandbox creation with the volumes field; a volume is mounted in at most one sandbox at a time and must be in the same region. The name is generated when omitted. Volume size and count are limited by the team's plan.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="name">
        /// Volume name, unique in the team. Generated when omitted.<br/>
        /// Example: datasets
        /// </param>
        /// <param name="size">
        /// Capacity, as a size (e.g. "10Gi", "512Mi") or a number of Mi (e.g. 1024). Can grow later, never shrink.<br/>
        /// Example: 10Gi
        /// </param>
        /// <param name="region">
        /// Region of the volume. Defaults to the default sandbox region. Sandboxes mounting it must be in the same region.<br/>
        /// Example: us-pdx-1
        /// </param>
        /// <param name="labels">
        /// Key-value pairs for organizing and filtering resources. Labels can be used to categorize resources by environment, project, team, or any custom taxonomy.<br/>
        /// Example: {"env":"development","project":"api-review","team":"engineering"}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.SandboxVolumeV1> CreateSandboxVolumeAsync(
            global::Baseten.OneOf<string, int?> size,
            string? teamId = default,
            string? xTeamId = default,
            string? name = default,
            string? region = default,
            global::System.Collections.Generic.Dictionary<string, string>? labels = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}