
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Page of Model APIs visible to the caller.
    /// </summary>
    public sealed partial class ModelAPIsResponseV1
    {
        /// <summary>
        /// Items in this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.ModelAPIV1> Items { get; set; }

        /// <summary>
        /// Pagination metadata for the page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.PaginationResponseV1 Pagination { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelAPIsResponseV1" /> class.
        /// </summary>
        /// <param name="items">
        /// Items in this page.
        /// </param>
        /// <param name="pagination">
        /// Pagination metadata for the page.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelAPIsResponseV1(
            global::System.Collections.Generic.IList<global::Baseten.ModelAPIV1> items,
            global::Baseten.PaginationResponseV1 pagination)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelAPIsResponseV1" /> class.
        /// </summary>
        public ModelAPIsResponseV1()
        {
        }

    }
}