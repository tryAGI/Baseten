#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Creates a new library listing<br/>
        /// Creates a new library listing for the authenticated user's organization.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/library_listings \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "display_name": null,<br/>
        ///   "user_defined_id": null,<br/>
        ///   "is_public": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.LibraryListingV1> CreateLibraryListingsAsync(

            global::Baseten.CreateLibraryListingRequestV1 request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new library listing<br/>
        /// Creates a new library listing for the authenticated user's organization.
        /// </summary>
        /// <param name="displayName">
        /// Display name of the library listing
        /// </param>
        /// <param name="userDefinedId">
        /// User-defined identifier of the library listing
        /// </param>
        /// <param name="isPublic">
        /// Whether the listing is publicly accessible<br/>
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.LibraryListingV1> CreateLibraryListingsAsync(
            string displayName,
            string userDefinedId,
            bool? isPublic = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}