
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A library listing version.
    /// </summary>
    public sealed partial class LibraryListingVersionV1
    {
        /// <summary>
        /// Human-readable tag for this version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionTag { get; set; }

        /// <summary>
        /// Whether this version is the live version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_live")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsLive { get; set; }

        /// <summary>
        /// Whether users deploying this model can download the Truss
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_truss_download")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool AllowTrussDownload { get; set; }

        /// <summary>
        /// Id of the source model version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("oracle_version_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OracleVersionId { get; set; }

        /// <summary>
        /// Time the version was created in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Time the version was last modified
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("modified_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ModifiedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryListingVersionV1" /> class.
        /// </summary>
        /// <param name="versionTag">
        /// Human-readable tag for this version
        /// </param>
        /// <param name="isLive">
        /// Whether this version is the live version
        /// </param>
        /// <param name="allowTrussDownload">
        /// Whether users deploying this model can download the Truss
        /// </param>
        /// <param name="oracleVersionId">
        /// Id of the source model version
        /// </param>
        /// <param name="createdAt">
        /// Time the version was created in ISO 8601 format
        /// </param>
        /// <param name="modifiedAt">
        /// Time the version was last modified
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LibraryListingVersionV1(
            string versionTag,
            bool isLive,
            bool allowTrussDownload,
            string oracleVersionId,
            global::System.DateTime createdAt,
            global::System.DateTime modifiedAt)
        {
            this.VersionTag = versionTag ?? throw new global::System.ArgumentNullException(nameof(versionTag));
            this.IsLive = isLive;
            this.AllowTrussDownload = allowTrussDownload;
            this.OracleVersionId = oracleVersionId ?? throw new global::System.ArgumentNullException(nameof(oracleVersionId));
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryListingVersionV1" /> class.
        /// </summary>
        public LibraryListingVersionV1()
        {
        }
    }
}