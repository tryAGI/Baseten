
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxMetricDescriptorV1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.SandboxMetricNameV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.SandboxMetricNameV1 Name { get; set; }

        /// <summary>
        /// Requests use COUNT, CPU uses CORES (1 means one fully used core), and memory uses BYTES.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit_hint")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.SandboxMetricDescriptorV1UnitHintJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.SandboxMetricDescriptorV1UnitHint UnitHint { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.SandboxMetricDescriptorV1KindJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.SandboxMetricDescriptorV1Kind Kind { get; set; }

        /// <summary>
        /// Requests use status=2xx,4xx,5xx; CPU and memory use stat=avg,max.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("label_sets")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>> LabelSets { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxMetricDescriptorV1" /> class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="unitHint">
        /// Requests use COUNT, CPU uses CORES (1 means one fully used core), and memory uses BYTES.
        /// </param>
        /// <param name="kind"></param>
        /// <param name="labelSets">
        /// Requests use status=2xx,4xx,5xx; CPU and memory use stat=avg,max.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxMetricDescriptorV1(
            global::Baseten.SandboxMetricNameV1 name,
            global::Baseten.SandboxMetricDescriptorV1UnitHint unitHint,
            global::Baseten.SandboxMetricDescriptorV1Kind kind,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.Dictionary<string, string>> labelSets)
        {
            this.Name = name;
            this.UnitHint = unitHint;
            this.Kind = kind;
            this.LabelSets = labelSets ?? throw new global::System.ArgumentNullException(nameof(labelSets));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxMetricDescriptorV1" /> class.
        /// </summary>
        public SandboxMetricDescriptorV1()
        {
        }

    }
}