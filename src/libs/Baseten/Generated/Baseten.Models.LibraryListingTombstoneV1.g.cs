
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A library listing tombstone.
    /// </summary>
    public sealed partial class LibraryListingTombstoneV1
    {
        /// <summary>
        /// User-defined identifier of the library listing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_defined_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserDefinedId { get; set; }

        /// <summary>
        /// Whether the library listing was deleted
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
        /// Initializes a new instance of the <see cref="LibraryListingTombstoneV1" /> class.
        /// </summary>
        /// <param name="userDefinedId">
        /// User-defined identifier of the library listing
        /// </param>
        /// <param name="deleted">
        /// Whether the library listing was deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LibraryListingTombstoneV1(
            string userDefinedId,
            bool deleted)
        {
            this.UserDefinedId = userDefinedId ?? throw new global::System.ArgumentNullException(nameof(userDefinedId));
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryListingTombstoneV1" /> class.
        /// </summary>
        public LibraryListingTombstoneV1()
        {
        }
    }
}