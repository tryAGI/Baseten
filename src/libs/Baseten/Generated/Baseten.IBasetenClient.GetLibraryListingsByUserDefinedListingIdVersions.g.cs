#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Gets all versions for a library listing<br/>
        /// Returns all versions for a specific library listing.
        /// </summary>
        /// <param name="userDefinedListingId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request GET \<br/>
        /// --url https://api.baseten.co/v1/library_listings/{user_defined_listing_id}/versions \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.LibraryListingVersionsV1> GetLibraryListingsByUserDefinedListingIdVersionsAsync(
            string userDefinedListingId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}