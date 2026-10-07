
#nullable enable

namespace Baseten
{
    /// <summary>
    /// One page of image repository summaries. Fetch tags through the separate tag listing endpoint.
    /// </summary>
    public sealed partial class ListImagesResponseV1
    {
        /// <summary>
        /// Image repositories on this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.ImageV1> Items { get; set; }

        /// <summary>
        /// Cursor pagination information. The cursor is present only when another page is available.<br/>
        /// Example: {"has_more":true,"cursor":"eyJ2IjoxLCJsYXN0X2tleSI6ImJhc2V0ZW4tYXBpLXJldmlldy0wOTE2Iiwic29ydCI6ImRlc2MifQ"}
        /// </summary>
        /// <example>{"has_more":true,"cursor":"eyJ2IjoxLCJsYXN0X2tleSI6ImJhc2V0ZW4tYXBpLXJldmlldy0wOTE2Iiwic29ydCI6ImRlc2MifQ"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.SandboxApiPaginationV1 Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListImagesResponseV1" /> class.
        /// </summary>
        /// <param name="items">
        /// Image repositories on this page.
        /// </param>
        /// <param name="pagination">
        /// Cursor pagination information. The cursor is present only when another page is available.<br/>
        /// Example: {"has_more":true,"cursor":"eyJ2IjoxLCJsYXN0X2tleSI6ImJhc2V0ZW4tYXBpLXJldmlldy0wOTE2Iiwic29ydCI6ImRlc2MifQ"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListImagesResponseV1(
            global::System.Collections.Generic.IList<global::Baseten.ImageV1> items,
            global::Baseten.SandboxApiPaginationV1 pagination)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListImagesResponseV1" /> class.
        /// </summary>
        public ListImagesResponseV1()
        {
        }

    }
}