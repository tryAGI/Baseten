#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Updates a library listing<br/>
        /// Updates the display name of a library listing.
        /// </summary>
        /// <param name="userDefinedListingId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request PATCH \<br/>
        /// --url https://api.baseten.co/v1/library_listings/{user_defined_listing_id} \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "display_name": null,<br/>
        ///   "is_public": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.LibraryListingV1> EditLibraryListingsByUserDefinedListingIdAsync(
            string userDefinedListingId,

            global::Baseten.UpdateLibraryListingRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Updates a library listing<br/>
        /// Updates the display name of a library listing.
        /// </summary>
        /// <param name="userDefinedListingId"></param>
        /// <param name="displayName">
        /// New display name for the library listing<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="isPublic">
        /// Whether the listing is publicly accessible<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.LibraryListingV1> EditLibraryListingsByUserDefinedListingIdAsync(
            string userDefinedListingId,
            string? displayName = default,
            bool? isPublic = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}