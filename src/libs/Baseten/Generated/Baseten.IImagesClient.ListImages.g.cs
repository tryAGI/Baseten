#nullable enable

namespace Baseten
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// List sandbox images<br/>
        /// Return one cursor-paginated page of image repository summaries. Tags are listed separately. Pages can be empty when non-sandbox repositories are excluded; follow pagination.cursor while pagination.has_more is true. Prefix search forces ascending name order.
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
        /// <param name="sort">
        /// Default Value: createdAt:desc
        /// </param>
        /// <param name="q"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.ListImagesResponseV1> ListImagesAsync(
            string? teamId = default,
            string? xTeamId = default,
            string? cursor = default,
            int? limit = default,
            string? sort = default,
            string? q = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List sandbox images<br/>
        /// Return one cursor-paginated page of image repository summaries. Tags are listed separately. Pages can be empty when non-sandbox repositories are excluded; follow pagination.cursor while pagination.has_more is true. Prefix search forces ascending name order.
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
        /// <param name="sort">
        /// Default Value: createdAt:desc
        /// </param>
        /// <param name="q"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.ListImagesResponseV1>> ListImagesAsResponseAsync(
            string? teamId = default,
            string? xTeamId = default,
            string? cursor = default,
            int? limit = default,
            string? sort = default,
            string? q = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}