#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Upserts a secret in a team<br/>
        /// Creates a new secret or updates an existing secret if one with the provided name already exists. The name and creation date of the created or updated secret is returned. This secret belongs to the specified team
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/teams/{team_id}/secrets \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "name": "my_secret",<br/>
        ///   "value": "my_secret_value"<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.SecretV1> CreateTeamsByTeamIdSecretsAsync(
            string teamId,

            global::Baseten.UpsertSecretRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upserts a secret in a team<br/>
        /// Creates a new secret or updates an existing secret if one with the provided name already exists. The name and creation date of the created or updated secret is returned. This secret belongs to the specified team
        /// </summary>
        /// <param name="teamId"></param>
        /// <param name="name">
        /// Name of the new or existing secret
        /// </param>
        /// <param name="value">
        /// Value of the secret
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.SecretV1> CreateTeamsByTeamIdSecretsAsync(
            string teamId,
            string name,
            string value,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}