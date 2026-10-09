
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The duration distribution of one cold start phase.
    /// </summary>
    public sealed partial class ColdStartPhasePercentilesV1
    {
        /// <summary>
        /// The phase.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phase")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.ColdStartPhaseV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.ColdStartPhaseV1 Phase { get; set; }

        /// <summary>
        /// Durations of the phase.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.ColdStartPercentilesV1 DurationMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ColdStartPhasePercentilesV1" /> class.
        /// </summary>
        /// <param name="phase">
        /// The phase.
        /// </param>
        /// <param name="durationMs">
        /// Durations of the phase.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ColdStartPhasePercentilesV1(
            global::Baseten.ColdStartPhaseV1 phase,
            global::Baseten.ColdStartPercentilesV1 durationMs)
        {
            this.Phase = phase;
            this.DurationMs = durationMs ?? throw new global::System.ArgumentNullException(nameof(durationMs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColdStartPhasePercentilesV1" /> class.
        /// </summary>
        public ColdStartPhasePercentilesV1()
        {
        }

    }
}