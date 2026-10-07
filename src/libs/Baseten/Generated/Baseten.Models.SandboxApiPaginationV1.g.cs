
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Cursor pagination information. The cursor is present only when another page is available.<br/>
    /// Example: {"has_more":true,"cursor":"eyJ2IjoxLCJsYXN0X2tleSI6ImJhc2V0ZW4tYXBpLXJldmlldy0wOTE2Iiwic29ydCI6ImRlc2MifQ"}
    /// </summary>
    public sealed partial class SandboxApiPaginationV1
    {
        /// <summary>
        /// Whether another page is available.<br/>
        /// Example: true
        /// </summary>
        /// <example>true</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Opaque cursor to pass to the next list request. Keep the same filters.<br/>
        /// Example: eyJ2IjoxLCJsYXN0X2tleSI6ImJhc2V0ZW4tYXBpLXJldmlldy0wOTE2Iiwic29ydCI6ImRlc2MifQ
        /// </summary>
        /// <example>eyJ2IjoxLCJsYXN0X2tleSI6ImJhc2V0ZW4tYXBpLXJldmlldy0wOTE2Iiwic29ydCI6ImRlc2MifQ</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("cursor")]
        public string? Cursor { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxApiPaginationV1" /> class.
        /// </summary>
        /// <param name="hasMore">
        /// Whether another page is available.<br/>
        /// Example: true
        /// </param>
        /// <param name="cursor">
        /// Opaque cursor to pass to the next list request. Keep the same filters.<br/>
        /// Example: eyJ2IjoxLCJsYXN0X2tleSI6ImJhc2V0ZW4tYXBpLXJldmlldy0wOTE2Iiwic29ydCI6ImRlc2MifQ
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxApiPaginationV1(
            bool hasMore,
            string? cursor)
        {
            this.HasMore = hasMore;
            this.Cursor = cursor;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxApiPaginationV1" /> class.
        /// </summary>
        public SandboxApiPaginationV1()
        {
        }

    }
}