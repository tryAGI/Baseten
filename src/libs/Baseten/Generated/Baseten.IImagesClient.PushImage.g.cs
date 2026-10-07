#nullable enable

namespace Baseten
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Push a sandbox image<br/>
        /// With image supplied, import the registry image asynchronously. Otherwise return an upload URL for a ZIP source archive containing its Dockerfile and build context. Processing starts after upload. No sandbox is created. Poll the image until BUILT or FAILED.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.PushImageResponseV1> PushImageAsync(

            global::Baseten.PushImageRequestV1 request,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Push a sandbox image<br/>
        /// With image supplied, import the registry image asynchronously. Otherwise return an upload URL for a ZIP source archive containing its Dockerfile and build context. Processing starts after upload. No sandbox is created. Poll the image until BUILT or FAILED.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.PushImageResponseV1>> PushImageAsResponseAsync(

            global::Baseten.PushImageRequestV1 request,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Push a sandbox image<br/>
        /// With image supplied, import the registry image asynchronously. Otherwise return an upload URL for a ZIP source archive containing its Dockerfile and build context. Processing starts after upload. No sandbox is created. Poll the image until BUILT or FAILED.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="name">
        /// Target image repository name. Reusing a name pushes a new version to the existing repository.<br/>
        /// Example: base-image
        /// </param>
        /// <param name="image">
        /// Optional source registry image reference including a registry hostname. When omitted, the response provides an archive upload URL.<br/>
        /// Example: docker.io/b10/base-image:latest
        /// </param>
        /// <param name="dockerConfig">
        /// Optional serialized registry authentication configuration for importing a private image. Used only when image is supplied; never returned.<br/>
        /// Included only in requests<br/>
        /// Example: {"auths":{"https://index.docker.io/v1/":{"auth":"YjEwLXJldmlldzpkZW1vLW5vdC1hLXZhbGlkLXJlZ2lzdHJ5LXRva2Vu"}}}
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.PushImageResponseV1> PushImageAsync(
            string name,
            string? teamId = default,
            string? xTeamId = default,
            string? image = default,
            string? dockerConfig = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}