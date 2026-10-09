
#nullable enable

namespace Baseten
{
    /// <summary>
    /// One phase recorded during a cold start attempt.
    /// </summary>
    public sealed partial class ColdStartPhaseSummaryV1
    {
        /// <summary>
        /// The phase.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phase")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.ColdStartPhaseV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.ColdStartPhaseV1 Phase { get; set; }

        /// <summary>
        /// Outcome of the phase.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.ColdStartPhaseStatusV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.ColdStartPhaseStatusV1 Status { get; set; }

        /// <summary>
        /// Time from the start of the attempt to the start of the phase, in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("offset_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OffsetMs { get; set; }

        /// <summary>
        /// Duration of the phase, in milliseconds. Can be 0 for a phase that finished within a second. Null if the phase did not finish.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        public int? DurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ColdStartPhaseSummaryV1" /> class.
        /// </summary>
        /// <param name="phase">
        /// The phase.
        /// </param>
        /// <param name="status">
        /// Outcome of the phase.
        /// </param>
        /// <param name="offsetMs">
        /// Time from the start of the attempt to the start of the phase, in milliseconds.
        /// </param>
        /// <param name="durationMs">
        /// Duration of the phase, in milliseconds. Can be 0 for a phase that finished within a second. Null if the phase did not finish.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ColdStartPhaseSummaryV1(
            global::Baseten.ColdStartPhaseV1 phase,
            global::Baseten.ColdStartPhaseStatusV1 status,
            int offsetMs,
            int? durationMs)
        {
            this.Phase = phase;
            this.Status = status;
            this.OffsetMs = offsetMs;
            this.DurationMs = durationMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColdStartPhaseSummaryV1" /> class.
        /// </summary>
        public ColdStartPhaseSummaryV1()
        {
        }

    }
}