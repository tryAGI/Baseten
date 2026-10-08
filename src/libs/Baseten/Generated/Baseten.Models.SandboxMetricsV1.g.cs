
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxMetricsV1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SandboxName { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime StartTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime EndTime { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int IntervalSeconds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.SandboxMetricsPointV1> Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxMetricsV1" /> class.
        /// </summary>
        /// <param name="sandboxName"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="intervalSeconds"></param>
        /// <param name="data"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxMetricsV1(
            string sandboxName,
            global::System.DateTime startTime,
            global::System.DateTime endTime,
            int intervalSeconds,
            global::System.Collections.Generic.IList<global::Baseten.SandboxMetricsPointV1> data)
        {
            this.SandboxName = sandboxName ?? throw new global::System.ArgumentNullException(nameof(sandboxName));
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.IntervalSeconds = intervalSeconds;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxMetricsV1" /> class.
        /// </summary>
        public SandboxMetricsV1()
        {
        }

    }
}