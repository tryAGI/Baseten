
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A list of library listings.
    /// </summary>
    public sealed partial class LibraryListingsV1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("listings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.LibraryListingV1> Listings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryListingsV1" /> class.
        /// </summary>
        /// <param name="listings"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LibraryListingsV1(
            global::System.Collections.Generic.IList<global::Baseten.LibraryListingV1> listings)
        {
            this.Listings = listings ?? throw new global::System.ArgumentNullException(nameof(listings));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LibraryListingsV1" /> class.
        /// </summary>
        public LibraryListingsV1()
        {
        }
    }
}