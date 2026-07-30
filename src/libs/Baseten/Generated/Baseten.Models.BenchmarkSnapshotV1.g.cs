
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class BenchmarkSnapshotV1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("run_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RunId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hardware")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hardware { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("measured_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime MeasuredAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metrics")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, double> Metrics { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BenchmarkSnapshotV1" /> class.
        /// </summary>
        /// <param name="runId"></param>
        /// <param name="hardware"></param>
        /// <param name="measuredAt"></param>
        /// <param name="metrics"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BenchmarkSnapshotV1(
            string runId,
            string hardware,
            global::System.DateTime measuredAt,
            global::System.Collections.Generic.Dictionary<string, double> metrics)
        {
            this.RunId = runId ?? throw new global::System.ArgumentNullException(nameof(runId));
            this.Hardware = hardware ?? throw new global::System.ArgumentNullException(nameof(hardware));
            this.MeasuredAt = measuredAt;
            this.Metrics = metrics ?? throw new global::System.ArgumentNullException(nameof(metrics));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BenchmarkSnapshotV1" /> class.
        /// </summary>
        public BenchmarkSnapshotV1()
        {
        }

    }
}