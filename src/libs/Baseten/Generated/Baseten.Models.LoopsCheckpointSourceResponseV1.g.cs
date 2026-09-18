
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Where a checkpoint's files are fetched from, and how.
    /// </summary>
    public sealed partial class LoopsCheckpointSourceResponseV1
    {
        /// <summary>
        /// `s3` means the files endpoint serves presigned URLs for this checkpoint; `volume` carries the ref to pull instead.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.Source2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.Source2 Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsCheckpointSourceResponseV1" /> class.
        /// </summary>
        /// <param name="source">
        /// `s3` means the files endpoint serves presigned URLs for this checkpoint; `volume` carries the ref to pull instead.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoopsCheckpointSourceResponseV1(
            global::Baseten.Source2 source)
        {
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsCheckpointSourceResponseV1" /> class.
        /// </summary>
        public LoopsCheckpointSourceResponseV1()
        {
        }

    }
}