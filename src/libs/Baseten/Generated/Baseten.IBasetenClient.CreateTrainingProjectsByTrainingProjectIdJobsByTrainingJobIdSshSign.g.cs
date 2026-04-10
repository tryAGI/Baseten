#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Sign an SSH certificate for a training job.<br/>
        /// Signs a short-lived SSH certificate granting access to a specific training job pod. Returns the signed SSH certificate, a JWT token for SSH proxy authentication, the proxy address to connect through, and the certificate expiry time.
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="trainingJobId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/training_projects/{training_project_id}/jobs/{training_job_id}/ssh/sign \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "public_key": null,<br/>
        ///   "replica_id": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.SignSSHCertificateResponseV1> CreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdSshSignAsync(
            string trainingProjectId,
            string trainingJobId,

            global::Baseten.SignSSHCertificateRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Sign an SSH certificate for a training job.<br/>
        /// Signs a short-lived SSH certificate granting access to a specific training job pod. Returns the signed SSH certificate, a JWT token for SSH proxy authentication, the proxy address to connect through, and the certificate expiry time.
        /// </summary>
        /// <param name="trainingProjectId"></param>
        /// <param name="trainingJobId"></param>
        /// <param name="publicKey">
        /// The user's SSH public key (e.g., 'ssh-ed25519 AAAA... user@host').
        /// </param>
        /// <param name="replicaId">
        /// The replica to connect to (0-indexed).<br/>
        /// Default Value: 0
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.SignSSHCertificateResponseV1> CreateTrainingProjectsByTrainingProjectIdJobsByTrainingJobIdSshSignAsync(
            string trainingProjectId,
            string trainingJobId,
            string publicKey,
            int? replicaId = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}