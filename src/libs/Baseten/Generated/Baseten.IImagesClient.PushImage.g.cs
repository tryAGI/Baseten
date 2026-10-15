#nullable enable

namespace Baseten
{
    public partial interface IImagesClient
    {
        /// <summary>
        /// Push a sandbox image<br/>
        /// With image supplied, import the registry image asynchronously. Otherwise return an upload URL for a ZIP source archive containing its Dockerfile and build context. The uploaded ZIP archive must not exceed 5 GB. Processing starts after upload. No sandbox is created. Poll the image until BUILT or FAILED. Set memory and volume to size the temporary environment that builds or imports the image; for a source archive, upload with the returned upload_headers.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.PushSandboxImageResponseV1> PushImageAsync(

            global::Baseten.PushSandboxImageRequestV1 request,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Push a sandbox image<br/>
        /// With image supplied, import the registry image asynchronously. Otherwise return an upload URL for a ZIP source archive containing its Dockerfile and build context. The uploaded ZIP archive must not exceed 5 GB. Processing starts after upload. No sandbox is created. Poll the image until BUILT or FAILED. Set memory and volume to size the temporary environment that builds or imports the image; for a source archive, upload with the returned upload_headers.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.PushSandboxImageResponseV1>> PushImageAsResponseAsync(

            global::Baseten.PushSandboxImageRequestV1 request,
            string? teamId = default,
            string? xTeamId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Push a sandbox image<br/>
        /// With image supplied, import the registry image asynchronously. Otherwise return an upload URL for a ZIP source archive containing its Dockerfile and build context. The uploaded ZIP archive must not exceed 5 GB. Processing starts after upload. No sandbox is created. Poll the image until BUILT or FAILED. Set memory and volume to size the temporary environment that builds or imports the image; for a source archive, upload with the returned upload_headers.
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="xTeamId"></param>
        /// <param name="name">
        /// Target image repository name. Reusing a name pushes a new version to the existing repository.<br/>
        /// Example: base-image
        /// </param>
        /// <param name="image">
        /// Optional source registry image reference including a registry hostname. When omitted, the response provides an archive upload URL. The uploaded ZIP archive must not exceed 5 GB.<br/>
        /// Example: docker.io/b10/base-image:latest
        /// </param>
        /// <param name="dockerConfig">
        /// Optional serialized registry authentication configuration for importing a private image. Used only when image is supplied; never returned.<br/>
        /// Included only in requests<br/>
        /// Example: {"auths":{"https://index.docker.io/v1/":{"auth":"YjEwLXJldmlldzpkZW1vLW5vdC1hLXZhbGlkLXJlZ2lzdHJ5LXRva2Vu"}}}
        /// </param>
        /// <param name="memory">
        /// Memory in megabytes of the temporary environment that builds the source archive or imports the registry image. Omit it to use the default size. Does not change the memory of sandboxes created from the image.<br/>
        /// Example: 16384
        /// </param>
        /// <param name="volume">
        /// Scratch disk in megabytes attached to the temporary build environment for intermediate layers. Set it for large images that run out of space while building or importing. 0 builds in memory, which is the default. Teams with HIPAA compliance enabled accept only 0.<br/>
        /// Example: 32768
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.PushSandboxImageResponseV1> PushImageAsync(
            string name,
            string? teamId = default,
            string? xTeamId = default,
            string? image = default,
            string? dockerConfig = default,
            long? memory = default,
            long? volume = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}