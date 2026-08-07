
#nullable enable

namespace Baseten
{
    /// <summary>
    /// One time bucket and the usage recorded in it.
    /// </summary>
    public sealed partial class ModelApisUsageBucketV1
    {
        /// <summary>
        /// Start of the bucket (inclusive), UTC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        /// End of the bucket (exclusive), UTC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndTime { get; set; }

        /// <summary>
        /// Usage totals for this bucket, ordered by total tokens descending
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::Baseten.ModelApisUsageResultV1>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelApisUsageBucketV1" /> class.
        /// </summary>
        /// <param name="startTime">
        /// Start of the bucket (inclusive), UTC
        /// </param>
        /// <param name="endTime">
        /// End of the bucket (exclusive), UTC
        /// </param>
        /// <param name="results">
        /// Usage totals for this bucket, ordered by total tokens descending
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelApisUsageBucketV1(
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            global::System.Collections.Generic.IList<global::Baseten.ModelApisUsageResultV1>? results)
        {
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelApisUsageBucketV1" /> class.
        /// </summary>
        public ModelApisUsageBucketV1()
        {
        }

    }
}