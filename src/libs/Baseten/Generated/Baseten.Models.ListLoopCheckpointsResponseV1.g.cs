
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Checkpoints matching the query filter.
    /// </summary>
    public sealed partial class ListLoopCheckpointsResponseV1
    {
        /// <summary>
        /// Matching checkpoints.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("checkpoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.LoopCheckpointV1> Checkpoints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListLoopCheckpointsResponseV1" /> class.
        /// </summary>
        /// <param name="checkpoints">
        /// Matching checkpoints.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListLoopCheckpointsResponseV1(
            global::System.Collections.Generic.IList<global::Baseten.LoopCheckpointV1> checkpoints)
        {
            this.Checkpoints = checkpoints ?? throw new global::System.ArgumentNullException(nameof(checkpoints));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListLoopCheckpointsResponseV1" /> class.
        /// </summary>
        public ListLoopCheckpointsResponseV1()
        {
        }
    }
}