
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A Loops run whose delete was accepted.
    /// </summary>
    public sealed partial class DeleteLoopsRunResponseV1
    {
        /// <summary>
        /// The deleted Loops run ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The run's checkpoints that were not deleted because something still uses them, such as a deployment. They stay usable until that stops.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kept_checkpoints")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.LoopsCheckpointV1> KeptCheckpoints { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteLoopsRunResponseV1" /> class.
        /// </summary>
        /// <param name="id">
        /// The deleted Loops run ID.
        /// </param>
        /// <param name="keptCheckpoints">
        /// The run's checkpoints that were not deleted because something still uses them, such as a deployment. They stay usable until that stops.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteLoopsRunResponseV1(
            string id,
            global::System.Collections.Generic.IList<global::Baseten.LoopsCheckpointV1> keptCheckpoints)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.KeptCheckpoints = keptCheckpoints ?? throw new global::System.ArgumentNullException(nameof(keptCheckpoints));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteLoopsRunResponseV1" /> class.
        /// </summary>
        public DeleteLoopsRunResponseV1()
        {
        }

    }
}