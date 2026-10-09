
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A page of cold start attempts, newest first by default.
    /// </summary>
    public sealed partial class ColdStartAttemptsV1
    {
        /// <summary>
        /// Items in this page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.ColdStartAttemptV1> Items { get; set; }

        /// <summary>
        /// Pagination metadata for the page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("pagination")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.PaginationResponseV1 Pagination { get; set; }

        /// <summary>
        /// Number of attempts matching the filters, counted within the 1,000 most recent cold starts in the window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ColdStartAttemptsV1" /> class.
        /// </summary>
        /// <param name="items">
        /// Items in this page.
        /// </param>
        /// <param name="pagination">
        /// Pagination metadata for the page.
        /// </param>
        /// <param name="totalCount">
        /// Number of attempts matching the filters, counted within the 1,000 most recent cold starts in the window.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ColdStartAttemptsV1(
            global::System.Collections.Generic.IList<global::Baseten.ColdStartAttemptV1> items,
            global::Baseten.PaginationResponseV1 pagination,
            int totalCount)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
            this.Pagination = pagination ?? throw new global::System.ArgumentNullException(nameof(pagination));
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColdStartAttemptsV1" /> class.
        /// </summary>
        public ColdStartAttemptsV1()
        {
        }

    }
}