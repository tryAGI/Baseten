#nullable enable

namespace Baseten
{
    public partial interface ISandboxesClient
    {
        /// <summary>
        /// Get sandbox configuration<br/>
        /// Return available Carbon-compatible sandbox regions. Configuration is the same for every team, so no team is selected. Only enabled regions supporting Carbon are returned. This describes regional capability, not the runtime selected for a particular team or sandbox. Region configuration is cached for up to 30 seconds.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.GetSandboxConfigurationResponseV1> GetSandboxConfigurationAsync(
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get sandbox configuration<br/>
        /// Return available Carbon-compatible sandbox regions. Configuration is the same for every team, so no team is selected. Only enabled regions supporting Carbon are returned. This describes regional capability, not the runtime selected for a particular team or sandbox. Region configuration is cached for up to 30 seconds.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.GetSandboxConfigurationResponseV1>> GetSandboxConfigurationAsResponseAsync(
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}