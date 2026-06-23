#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Patch the caller's Loops user config.<br/>
        /// Updates the caller's Loops user config using JSON Merge Patch (RFC 7396) semantics per field: omit a field to leave it unchanged, send null to clear (inherit the org-level allowlist), or send a list to set the allowlist. Empty lists are rejected.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/loops/user_config \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "trainer_accelerator_priority": [<br/>
        ///     "H100",<br/>
        ///     "H200"<br/>
        ///   ],<br/>
        ///   "sampler_accelerator_priority": [<br/>
        ///     "H100",<br/>
        ///     "H200"<br/>
        ///   ]<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.PatchLoopsUserConfigResponseV1> EditLoopsUserConfigAsync(

            global::Baseten.PatchLoopsUserConfigRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch the caller's Loops user config.<br/>
        /// Updates the caller's Loops user config using JSON Merge Patch (RFC 7396) semantics per field: omit a field to leave it unchanged, send null to clear (inherit the org-level allowlist), or send a list to set the allowlist. Empty lists are rejected.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/loops/user_config \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "trainer_accelerator_priority": [<br/>
        ///     "H100",<br/>
        ///     "H200"<br/>
        ///   ],<br/>
        ///   "sampler_accelerator_priority": [<br/>
        ///     "H100",<br/>
        ///     "H200"<br/>
        ///   ]<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.PatchLoopsUserConfigResponseV1>> EditLoopsUserConfigAsResponseAsync(

            global::Baseten.PatchLoopsUserConfigRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Patch the caller's Loops user config.<br/>
        /// Updates the caller's Loops user config using JSON Merge Patch (RFC 7396) semantics per field: omit a field to leave it unchanged, send null to clear (inherit the org-level allowlist), or send a list to set the allowlist. Empty lists are rejected.
        /// </summary>
        /// <param name="trainerAcceleratorPriority">
        /// Ordered list of GPU types for trainer deployments, highest priority first. Send a list to set; send null to clear (inherit org allowlist); omit to leave unchanged. Empty list is rejected.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="samplerAcceleratorPriority">
        /// Ordered list of GPU types for sampler deployments, highest priority first. Send a list to set; send null to clear (inherit org allowlist); omit to leave unchanged. Empty list is rejected.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.PatchLoopsUserConfigResponseV1> EditLoopsUserConfigAsync(
            global::System.Collections.Generic.IList<string>? trainerAcceleratorPriority = default,
            global::System.Collections.Generic.IList<string>? samplerAcceleratorPriority = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}