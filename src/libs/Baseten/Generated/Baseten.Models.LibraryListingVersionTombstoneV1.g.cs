
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A library listing version tombstone.
    /// </summary>
    public sealed partial class LibraryListingVersionTombstoneV1
    {
        /// <summary>
        /// Human-readable tag for this version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version_tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string VersionTag { get; set; }

        /// <summary>
        /// Whether the library listing version was deleted
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryListingVersionTombstoneV1" /> class.
        /// </summary>
        /// <param name="versionTag">
        /// Human-readable tag for this version
        /// </param>
        /// <param name="deleted">
        /// Whether the library listing version was deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LibraryListingVersionTombstoneV1(
            string versionTag,
            bool deleted)
        {
            this.VersionTag = versionTag ?? throw new global::System.ArgumentNullException(nameof(versionTag));
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryListingVersionTombstoneV1" /> class.
        /// </summary>
        public LibraryListingVersionTombstoneV1()
        {
        }
    }
}