#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Deletes a service account<br/>
        /// Deletes a disabled service account that no trust rule uses. Disable the account and delete its trust rules first.
        /// </summary>
        /// <param name="serviceAccountId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/service_accounts/{service_account_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.DeletedServiceAccountV1> DeleteServiceAccountsByServiceAccountIdAsync(
            string serviceAccountId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Deletes a service account<br/>
        /// Deletes a disabled service account that no trust rule uses. Disable the account and delete its trust rules first.
        /// </summary>
        /// <param name="serviceAccountId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/service_accounts/{service_account_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.DeletedServiceAccountV1>> DeleteServiceAccountsByServiceAccountIdAsResponseAsync(
            string serviceAccountId,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}