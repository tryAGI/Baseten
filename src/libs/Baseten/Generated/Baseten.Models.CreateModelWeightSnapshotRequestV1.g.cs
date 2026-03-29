
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to create a model weight snapshot.
    /// </summary>
    public sealed partial class CreateModelWeightSnapshotRequestV1
    {
        /// <summary>
        /// Unique identifier of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Path to the model weight snapshot
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("snapshot_uri")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SnapshotUri { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelWeightSnapshotRequestV1" /> class.
        /// </summary>
        /// <param name="model">
        /// Unique identifier of the model
        /// </param>
        /// <param name="snapshotUri">
        /// Path to the model weight snapshot
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateModelWeightSnapshotRequestV1(
            string model,
            string snapshotUri)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.SnapshotUri = snapshotUri ?? throw new global::System.ArgumentNullException(nameof(snapshotUri));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateModelWeightSnapshotRequestV1" /> class.
        /// </summary>
        public CreateModelWeightSnapshotRequestV1()
        {
        }
    }
}