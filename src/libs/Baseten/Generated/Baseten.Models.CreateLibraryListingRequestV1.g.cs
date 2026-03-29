
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request to create a new library listing.
    /// </summary>
    public sealed partial class CreateLibraryListingRequestV1
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
        /// Whether the listing is publicly accessible<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_public")]
        public bool? IsPublic { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLibraryListingRequestV1" /> class.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateLibraryListingRequestV1(
            string displayName,
            string userDefinedId,
            bool? isPublic)
        {
            this.DisplayName = displayName ?? throw new global::System.ArgumentNullException(nameof(displayName));
            this.UserDefinedId = userDefinedId ?? throw new global::System.ArgumentNullException(nameof(userDefinedId));
            this.IsPublic = isPublic;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLibraryListingRequestV1" /> class.
        /// </summary>
        public CreateLibraryListingRequestV1()
        {
        }
    }
}