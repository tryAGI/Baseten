
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RoutesUsageBucketV1
    {
        /// <summary>
        /// UTC calendar date for this bucket, from midnight inclusive to the next midnight exclusive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("date")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Date { get; set; }

        /// <summary>
        /// Usage broken down by the requested dimensions. Empty when there is no usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.RoutesUsageResultV1> Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RoutesUsageBucketV1" /> class.
        /// </summary>
        /// <param name="date">
        /// UTC calendar date for this bucket, from midnight inclusive to the next midnight exclusive.
        /// </param>
        /// <param name="results">
        /// Usage broken down by the requested dimensions. Empty when there is no usage.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RoutesUsageBucketV1(
            global::System.DateTime date,
            global::System.Collections.Generic.IList<global::Baseten.RoutesUsageResultV1> results)
        {
            this.Date = date;
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoutesUsageBucketV1" /> class.
        /// </summary>
        public RoutesUsageBucketV1()
        {
        }

    }
}