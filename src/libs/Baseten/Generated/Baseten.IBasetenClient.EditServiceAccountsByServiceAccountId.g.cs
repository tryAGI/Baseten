#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Updates a service account<br/>
        /// Updates the fields you send. Set `disabled` to true to stop the account being used, and back to false to restore it. `preset_permissions` replaces the account's access as a whole. The owning team can't change.
        /// </summary>
        /// <param name="serviceAccountId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/service_accounts/{service_account_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "disabled": true<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.ServiceAccountV1> EditServiceAccountsByServiceAccountIdAsync(
            string serviceAccountId,

            global::Baseten.UpdateServiceAccountRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a service account<br/>
        /// Updates the fields you send. Set `disabled` to true to stop the account being used, and back to false to restore it. `preset_permissions` replaces the account's access as a whole. The owning team can't change.
        /// </summary>
        /// <param name="serviceAccountId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/service_accounts/{service_account_id} \<br/>
        /// --header "Authorization: Bearer $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "disabled": true<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.AutoSDKHttpResponse<global::Baseten.ServiceAccountV1>> EditServiceAccountsByServiceAccountIdAsResponseAsync(
            string serviceAccountId,

            global::Baseten.UpdateServiceAccountRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a service account<br/>
        /// Updates the fields you send. Set `disabled` to true to stop the account being used, and back to false to restore it. `preset_permissions` replaces the account's access as a whole. The owning team can't change.
        /// </summary>
        /// <param name="serviceAccountId"></param>
        /// <param name="name">
        /// Name, unique in the organization<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="description">
        /// Description, up to 1,024 characters; null clears it<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="disabled">
        /// Disable the account to stop it being used, or enable it again<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="presetPermissions">
        /// Replaces the account's access as a whole. Temporary; may be removed once fine-grained access control is available.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.ServiceAccountV1> EditServiceAccountsByServiceAccountIdAsync(
            string serviceAccountId,
            string? name = default,
            string? description = default,
            bool? disabled = default,
            global::Baseten.ServiceAccountPresetPermissionsRequestV1? presetPermissions = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}