
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request to create a new library listing version from an existing model version.
    /// </summary>
    public sealed partial class CreateLibraryListingVersionRequestV1
    {
        /// <summary>
        /// Display name of the library listing. Required when creating a new listing.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Whether the listing is publicly accessible. Only used when creating a new listing.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// Id of the source model version to publish
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oracle_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OracleVersionId { get; set; }

        /// <summary>
        /// Whether users deploying this model can download the Truss<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_truss_download")]
        public bool? AllowTrussDownload { get; set; }

        /// <summary>
        /// Human-readable tag for this version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionTag { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLibraryListingVersionRequestV1" /> class.
        /// </summary>
        /// <param name="oracleVersionId">
        /// Id of the source model version to publish
        /// </param>
        /// <param name="versionTag">
        /// Human-readable tag for this version
        /// </param>
        /// <param name="displayName">
        /// Display name of the library listing. Required when creating a new listing.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="isPublic">
        /// Whether the listing is publicly accessible. Only used when creating a new listing.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="allowTrussDownload">
        /// Whether users deploying this model can download the Truss<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateLibraryListingVersionRequestV1(
            string oracleVersionId,
            string versionTag,
            string? displayName,
            bool? isPublic,
            bool? allowTrussDownload)
        {
            this.DisplayName = displayName;
            this.IsPublic = isPublic;
            this.OracleVersionId = oracleVersionId ?? throw new global::System.ArgumentNullException(nameof(oracleVersionId));
            this.AllowTrussDownload = allowTrussDownload;
            this.VersionTag = versionTag ?? throw new global::System.ArgumentNullException(nameof(versionTag));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLibraryListingVersionRequestV1" /> class.
        /// </summary>
        public CreateLibraryListingVersionRequestV1()
        {
        }
    }
}