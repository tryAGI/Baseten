
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Query-string filters for ``GET /v1/model_apis``.
    /// </summary>
    public sealed partial class ModelAPIsRequestV1
    {
        /// <summary>
        /// Opaque cursor returned by a previous page. Omit to fetch the first page.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Maximum number of items to return.<br/>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// When true, restrict the result to Model APIs the workspace has added. Defaults to the full visible catalog.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_only")]
        public bool? AddedOnly { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelAPIsRequestV1" /> class.
        /// </summary>
        /// <param name="cursor">
        /// Opaque cursor returned by a previous page. Omit to fetch the first page.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="limit">
        /// Maximum number of items to return.<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="addedOnly">
        /// When true, restrict the result to Model APIs the workspace has added. Defaults to the full visible catalog.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelAPIsRequestV1(
            string? cursor,
            int? limit,
            bool? addedOnly)
        {
            this.Cursor = cursor;
            this.Limit = limit;
            this.AddedOnly = addedOnly;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelAPIsRequestV1" /> class.
        /// </summary>
        public ModelAPIsRequestV1()
        {
        }

    }
}