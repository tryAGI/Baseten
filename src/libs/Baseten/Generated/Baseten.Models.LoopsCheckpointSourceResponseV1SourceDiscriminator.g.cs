
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LoopsCheckpointSourceResponseV1SourceDiscriminator
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kind")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.LoopsCheckpointSourceResponseV1SourceDiscriminatorKindJsonConverter))]
        public global::Baseten.LoopsCheckpointSourceResponseV1SourceDiscriminatorKind? Kind { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsCheckpointSourceResponseV1SourceDiscriminator" /> class.
        /// </summary>
        /// <param name="kind"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoopsCheckpointSourceResponseV1SourceDiscriminator(
            global::Baseten.LoopsCheckpointSourceResponseV1SourceDiscriminatorKind? kind)
        {
            this.Kind = kind;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsCheckpointSourceResponseV1SourceDiscriminator" /> class.
        /// </summary>
        public LoopsCheckpointSourceResponseV1SourceDiscriminator()
        {
        }

    }
}