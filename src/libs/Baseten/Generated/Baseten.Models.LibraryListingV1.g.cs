
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A library listing.
    /// </summary>
    public sealed partial class LibraryListingV1
    {
        /// <summary>
        /// Display name of the library listing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DisplayName { get; set; }

        /// <summary>
        /// User-defined identifier of the library listing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_defined_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserDefinedId { get; set; }

        /// <summary>
        /// Whether the listing is publicly accessible
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsPublic { get; set; }

        /// <summary>
        /// Time the listing was created in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Time the listing was last modified
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
        /// Initializes a new instance of the <see cref="LibraryListingV1" /> class.
        /// </summary>
        /// <param name="displayName">
        /// Display name of the library listing
        /// </param>
        /// <param name="userDefinedId">
        /// User-defined identifier of the library listing
        /// </param>
        /// <param name="isPublic">
        /// Whether the listing is publicly accessible
        /// </param>
        /// <param name="createdAt">
        /// Time the listing was created in ISO 8601 format
        /// </param>
        /// <param name="modifiedAt">
        /// Time the listing was last modified
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LibraryListingV1(
            string displayName,
            string userDefinedId,
            bool isPublic,
            global::System.DateTime createdAt,
            global::System.DateTime modifiedAt)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.UserDefinedId = userDefinedId ?? throw new global::System.ArgumentNullException(nameof(userDefinedId));
            this.IsPublic = isPublic;
            this.CreatedAt = createdAt;
            this.ModifiedAt = modifiedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryListingV1" /> class.
        /// </summary>
        public LibraryListingV1()
        {
        }
    }
}