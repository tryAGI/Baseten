
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A model weight snapshot.
    /// </summary>
    public sealed partial class ModelWeightSnapshotV1
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
        /// Time of the snapshot
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("received_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime ReceivedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelWeightSnapshotV1" /> class.
        /// </summary>
        /// <param name="model">
        /// Unique identifier of the model
        /// </param>
        /// <param name="snapshotUri">
        /// Path to the model weight snapshot
        /// </param>
        /// <param name="receivedAt">
        /// Time of the snapshot
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelWeightSnapshotV1(
            string model,
            string snapshotUri,
            global::System.DateTime receivedAt)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.SnapshotUri = snapshotUri ?? throw new global::System.ArgumentNullException(nameof(snapshotUri));
            this.ReceivedAt = receivedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelWeightSnapshotV1" /> class.
        /// </summary>
        public ModelWeightSnapshotV1()
        {
        }
    }
}