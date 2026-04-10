#nullable enable

namespace Baseten
{
    public partial interface IBasetenClient
    {
        /// <summary>
        /// Creates a new library listing version<br/>
        /// Creates a new library listing version from an existing model version. The model version must be fully built (have an image_uri). If a listing with the given id already exists for the org, a new version is added. Otherwise, a new listing is created.
        /// </summary>
        /// <param name="userDefinedListingId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Baseten.ApiException"></exception>
        /// <remarks>
        /// curl --request POST \<br/>
        /// --url https://api.baseten.co/v1/library_listings/{user_defined_listing_id}/versions \<br/>
        /// --header "Authorization: Api-Key $BASETEN_API_KEY" \<br/>
        /// --data '{<br/>
        ///   "display_name": null,<br/>
        ///   "is_public": null,<br/>
        ///   "oracle_version_id": null,<br/>
        ///   "allow_truss_download": null,<br/>
        ///   "version_tag": null<br/>
        /// }'
        /// </remarks>
        global::System.Threading.Tasks.Task<global::Baseten.LibraryListingVersionV1> CreateLibraryListingsByUserDefinedListingIdVersionsAsync(
            string userDefinedListingId,

            global::Baseten.CreateLibraryListingVersionRequestV1 request,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Creates a new library listing version<br/>
        /// Creates a new library listing version from an existing model version. The model version must be fully built (have an image_uri). If a listing with the given id already exists for the org, a new version is added. Otherwise, a new listing is created.
        /// </summary>
        /// <param name="userDefinedListingId"></param>
        /// <param name="displayName">
        /// Display name of the library listing. Required when creating a new listing.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="isPublic">
        /// Whether the listing is publicly accessible. Only used when creating a new listing.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="oracleVersionId">
        /// Id of the source model version to publish
        /// </param>
        /// <param name="allowTrussDownload">
        /// Whether users deploying this model can download the Truss<br/>
        /// Default Value: false
        /// </param>
        /// <param name="versionTag">
        /// Human-readable tag for this version
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Baseten.LibraryListingVersionV1> CreateLibraryListingsByUserDefinedListingIdVersionsAsync(
            string userDefinedListingId,
            string oracleVersionId,
            string versionTag,
            string? displayName = default,
            bool? isPublic = default,
            bool? allowTrussDownload = default,
            global::Baseten.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}