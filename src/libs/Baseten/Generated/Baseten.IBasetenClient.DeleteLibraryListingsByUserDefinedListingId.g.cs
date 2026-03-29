#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Deletes a library listing<br/>
        /// Deletes a library listing and all of its associated versions. Any versions that are currently live will also be removed.
        /// </summary>
        /// <param name="userDefinedListingId"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/library_listings/{user_defined_listing_id} \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.LibraryListingTombstoneV1> DeleteLibraryListingsByUserDefinedListingIdAsync(
            string userDefinedListingId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}