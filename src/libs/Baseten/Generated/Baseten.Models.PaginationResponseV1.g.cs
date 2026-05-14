
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class PaginationResponseV1
    {
        /// <summary>
        /// Whether more items exist after this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Opaque cursor to pass into the next request. Null when there is no next page.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationResponseV1" /> class.
        /// </summary>
        /// <param name="hasMore">
        /// Whether more items exist after this page.
        /// </param>
        /// <param name="cursor">
        /// Opaque cursor to pass into the next request. Null when there is no next page.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PaginationResponseV1(
            bool hasMore,
            string? cursor)
        {
            this.HasMore = hasMore;
            this.Cursor = cursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaginationResponseV1" /> class.
        /// </summary>
        public PaginationResponseV1()
        {
        }

    }
}