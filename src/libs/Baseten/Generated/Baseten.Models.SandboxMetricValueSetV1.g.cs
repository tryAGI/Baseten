
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxMetricValueSetV1
    {
        /// <summary>
        /// Start of the SERIES interval or SUMMARY window; snapshot timestamp in CURRENT.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_epoch_millis")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long StartEpochMillis { get; set; }

        /// <summary>
        /// Values indexed first by metric_descriptors, then by that descriptor's label_sets. Null means no sample.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double?>> Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxMetricValueSetV1" /> class.
        /// </summary>
        /// <param name="startEpochMillis">
        /// Start of the SERIES interval or SUMMARY window; snapshot timestamp in CURRENT.
        /// </param>
        /// <param name="values">
        /// Values indexed first by metric_descriptors, then by that descriptor's label_sets. Null means no sample.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxMetricValueSetV1(
            long startEpochMillis,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double?>> values)
        {
            this.StartEpochMillis = startEpochMillis;
            this.Values = values ?? throw new global::System.ArgumentNullException(nameof(values));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxMetricValueSetV1" /> class.
        /// </summary>
        public SandboxMetricValueSetV1()
        {
        }

    }
}