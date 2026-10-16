#nullable enable

namespace Baseten
{
    public partial interface IPreviewsClient
    {
        /// <summary>
        /// List preview tokens<br/>
        /// Return the tokens of a private preview in the paginated list format, including expired tokens until they are removed. cursor and limit are accepted but not applied yet; all tokens fit on one page, so has_more is false. Follow pagination.cursor while has_more is true to stay compatible when they are applied.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="cursor">
        /// Example: eyJ2IjoxLCJsYXN0X2tleSI6ImJhc2V0ZW4tYXBpLXJldmlldy0wOTE2Iiwic29ydCI6ImRlc2MifQ
        /// </param>
        /// <param name="limit">
        /// Default Value: 20<br/>
        /// Example: 20
        /// </param>
        /// <param name="sandboxName"></param>
        /// <param name="previewName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.ListSandboxPreviewTokensResponseV1> ListSandboxPreviewTokensAsync(
            string sandboxName,
            string previewName,
            string? teamId = default,
            string? xTeamId = default,
            string? cursor = default,
            int? limit = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List preview tokens<br/>
        /// Return the tokens of a private preview in the paginated list format, including expired tokens until they are removed. cursor and limit are accepted but not applied yet; all tokens fit on one page, so has_more is false. Follow pagination.cursor while has_more is true to stay compatible when they are applied.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="cursor">
        /// Example: eyJ2IjoxLCJsYXN0X2tleSI6ImJhc2V0ZW4tYXBpLXJldmlldy0wOTE2Iiwic29ydCI6ImRlc2MifQ
        /// </param>
        /// <param name="limit">
        /// Default Value: 20<br/>
        /// Example: 20
        /// </param>
        /// <param name="sandboxName"></param>
        /// <param name="previewName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.ListSandboxPreviewTokensResponseV1>> ListSandboxPreviewTokensAsResponseAsync(
            string sandboxName,
            string previewName,
            string? teamId = default,
            string? xTeamId = default,
            string? cursor = default,
            int? limit = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}