#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets a library listing version<br/>
        /// Returns a specific version of a library listing.
        /// </summary>
        /// <param name="userDefinedListingId"></param>
        /// <param name="versionTag"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/library_listings/{user_defined_listing_id}/versions/{version_tag} \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.LibraryListingVersionV1> GetLibraryListingsByUserDefinedListingIdVersionsByVersionTagAsync(
            string userDefinedListingId,
            string versionTag,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}