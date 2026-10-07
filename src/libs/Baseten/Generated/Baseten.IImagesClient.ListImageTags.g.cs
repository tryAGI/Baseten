#nullable enable

namespace Baseten
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// List image tags<br/>
        /// Return one cursor-paginated page of image versions.
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
        /// Default Value: name:asc
        /// </param>
        /// <param name="q"></param>
        /// <param name="name"></param>
        /// <param name="imageName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.ListImageTagsResponseV1> ListImageTagsAsync(
            string imageName,
            string? teamId = default,
            string? xTeamId = default,
            string? cursor = default,
            int? limit = default,
            string? sort = default,
            string? q = default,
            string? name = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// List image tags<br/>
        /// Return one cursor-paginated page of image versions.
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
        /// Default Value: name:asc
        /// </param>
        /// <param name="q"></param>
        /// <param name="name"></param>
        /// <param name="imageName"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.ListImageTagsResponseV1>> ListImageTagsAsResponseAsync(
            string imageName,
            string? teamId = default,
            string? xTeamId = default,
            string? cursor = default,
            int? limit = default,
            string? sort = default,
            string? q = default,
            string? name = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}