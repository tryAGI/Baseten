
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A metric for a training job.
    /// </summary>
    public sealed partial class TrainingJobMetricV1
    {
        /// <summary>
        /// The value of the metric.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Value { get; set; }

        /// <summary>
        /// The timestamp of the metric in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timestamp")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Timestamp { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingJobMetricV1" /> class.
        /// </summary>
        /// <param name="value">
        /// The value of the metric.
        /// </param>
        /// <param name="timestamp">
        /// The timestamp of the metric in ISO 8601 format.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainingJobMetricV1(
            double value,
            global::System.DateTime timestamp)
        {
            this.Value = value;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingJobMetricV1" /> class.
        /// </summary>
        public TrainingJobMetricV1()
        {
        }
    }
}