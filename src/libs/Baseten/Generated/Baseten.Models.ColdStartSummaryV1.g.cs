
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Cold start duration distributions over a time window.
    /// </summary>
    public sealed partial class ColdStartSummaryV1
    {
        /// <summary>
        /// Start of the returned window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_epoch_millis")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartEpochMillis { get; set; }

        /// <summary>
        /// End of the returned window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_epoch_millis")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndEpochMillis { get; set; }

        /// <summary>
        /// Durations of whole cold starts, sampled from the 1,000 most recent in the window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.ColdStartPercentilesV1 TotalDurationMs { get; set; }

        /// <summary>
        /// Durations of each phase that was recorded in the window.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phase_duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.ColdStartPhasePercentilesV1> PhaseDurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ColdStartSummaryV1" /> class.
        /// </summary>
        /// <param name="startEpochMillis">
        /// Start of the returned window.
        /// </param>
        /// <param name="endEpochMillis">
        /// End of the returned window.
        /// </param>
        /// <param name="totalDurationMs">
        /// Durations of whole cold starts, sampled from the 1,000 most recent in the window.
        /// </param>
        /// <param name="phaseDurationMs">
        /// Durations of each phase that was recorded in the window.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ColdStartSummaryV1(
            int startEpochMillis,
            int endEpochMillis,
            global::Baseten.ColdStartPercentilesV1 totalDurationMs,
            global::System.Collections.Generic.IList<global::Baseten.ColdStartPhasePercentilesV1> phaseDurationMs)
        {
            this.StartEpochMillis = startEpochMillis;
            this.EndEpochMillis = endEpochMillis;
            this.TotalDurationMs = totalDurationMs ?? throw new global::System.ArgumentNullException(nameof(totalDurationMs));
            this.PhaseDurationMs = phaseDurationMs ?? throw new global::System.ArgumentNullException(nameof(phaseDurationMs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColdStartSummaryV1" /> class.
        /// </summary>
        public ColdStartSummaryV1()
        {
        }

    }
}