
#nullable enable

namespace Baseten
{
    /// <summary>
    /// One daily bucket and the costs attributed to it.
    /// </summary>
    public sealed partial class ModelApisCostBucketV1
    {
        /// <summary>
        /// UTC calendar date for this bucket, from midnight inclusive to the next midnight exclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Date { get; set; }

        /// <summary>
        /// Cost totals for the observed combinations of requested dimensions in this bucket, ordered by those dimensions. Empty when the day has no matching usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::Baseten.ModelApisCostResultV1>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelApisCostBucketV1" /> class.
        /// </summary>
        /// <param name="date">
        /// UTC calendar date for this bucket, from midnight inclusive to the next midnight exclusive.
        /// </param>
        /// <param name="results">
        /// Cost totals for the observed combinations of requested dimensions in this bucket, ordered by those dimensions. Empty when the day has no matching usage.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelApisCostBucketV1(
            global::System.DateTime date,
            global::System.Collections.Generic.IList<global::Baseten.ModelApisCostResultV1>? results)
        {
            this.Date = date;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelApisCostBucketV1" /> class.
        /// </summary>
        public ModelApisCostBucketV1()
        {
        }

    }
}