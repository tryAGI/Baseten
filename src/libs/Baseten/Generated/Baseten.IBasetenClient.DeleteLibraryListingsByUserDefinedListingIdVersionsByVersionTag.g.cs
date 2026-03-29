#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Deletes a library listing version<br/>
        /// Deletes a specific version of a library listing. Deleting a live version will fail with a 400 error — demote the version first by setting another version as live.
        /// </summary>
        /// <param name="userDefinedListingId"></param>
        /// <param name="versionTag"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request DELETE \<br/>
        /// --url https://api.baseten.co/v1/library_listings/{user_defined_listing_id}/versions/{version_tag} \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY"
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.LibraryListingVersionTombstoneV1> DeleteLibraryListingsByUserDefinedListingIdVersionsByVersionTagAsync(
            string userDefinedListingId,
            string versionTag,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}