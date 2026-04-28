#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Sign an SSH certificate for an inference model.<br/>
        /// Signs a short-lived SSH certificate granting access to a running inference model pod. Returns the signed SSH certificate, a JWT token for SSH proxy authentication, the proxy address to connect through, and the certificate expiry time.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/models/{model_id}/deployments/{deployment_id}/ssh/sign \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "public_key": null,<br/>
        ///   "replica_id": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.SignSSHCertificateResponseV1> CreateModelsByModelIdDeploymentsByDeploymentIdSshSignAsync(
            string modelId,
            string deploymentId,

            global::Baseten.SignSSHCertificateRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sign an SSH certificate for an inference model.<br/>
        /// Signs a short-lived SSH certificate granting access to a running inference model pod. Returns the signed SSH certificate, a JWT token for SSH proxy authentication, the proxy address to connect through, and the certificate expiry time.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="deploymentId"></param>
        /// <param name="publicKey">
        /// The user's SSH public key (e.g., 'ssh-ed25519 AAAA... user@host').
        /// </param>
        /// <param name="replicaId">
        /// The replica to connect to. Required for training jobs (e.g. '0'). Optional for inference (server picks a running replica if omitted).<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.SignSSHCertificateResponseV1> CreateModelsByModelIdDeploymentsByDeploymentIdSshSignAsync(
            string modelId,
            string deploymentId,
            string publicKey,
            string? replicaId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}