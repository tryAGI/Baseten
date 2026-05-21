
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Create a model by forking a library listing accessible to the caller's organization.
    /// </summary>
    public sealed partial class LibraryListingSourceV1
    {
        /// <summary>
        /// Default Value: library_listing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        public string? Kind { get; set; }

        /// <summary>
        /// Identifier of the publishing organization, as returned by `GET /v1/library_models`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_foundation_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgFoundationName { get; set; }

        /// <summary>
        /// Listing identifier within the publishing organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_defined_listing_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserDefinedListingId { get; set; }

        /// <summary>
        /// Optional name for the new deployed model. Defaults to the listing's configured name.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployed_model_name")]
        public string? DeployedModelName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryListingSourceV1" /> class.
        /// </summary>
        /// <param name="orgFoundationName">
        /// Identifier of the publishing organization, as returned by `GET /v1/library_models`.
        /// </param>
        /// <param name="userDefinedListingId">
        /// Listing identifier within the publishing organization.
        /// </param>
        /// <param name="kind">
        /// Default Value: library_listing
        /// </param>
        /// <param name="deployedModelName">
        /// Optional name for the new deployed model. Defaults to the listing's configured name.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LibraryListingSourceV1(
            string orgFoundationName,
            string userDefinedListingId,
            string? kind,
            string? deployedModelName)
        {
            this.Kind = kind;
            this.OrgFoundationName = orgFoundationName ?? throw new global::System.ArgumentNullException(nameof(orgFoundationName));
            this.UserDefinedListingId = userDefinedListingId ?? throw new global::System.ArgumentNullException(nameof(userDefinedListingId));
            this.DeployedModelName = deployedModelName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryListingSourceV1" /> class.
        /// </summary>
        public LibraryListingSourceV1()
        {
        }

    }
}