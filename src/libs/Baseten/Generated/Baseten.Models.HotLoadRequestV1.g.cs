
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The snapshot the deployment's replicas should load. Other keys are passed through.
    /// </summary>
    public sealed partial class HotLoadRequestV1
    {
        /// <summary>
        /// Snapshot directory below the checkpoint prefix, for example, anchors/step000001.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("identity")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Identity { get; set; }

        /// <summary>
        /// Required when identity is a delta snapshot.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("incremental_snapshot_metadata")]
        public global::Baseten.HotLoadIncrementalSnapshotMetadataV1? IncrementalSnapshotMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HotLoadRequestV1" /> class.
        /// </summary>
        /// <param name="identity">
        /// Snapshot directory below the checkpoint prefix, for example, anchors/step000001.
        /// </param>
        /// <param name="incrementalSnapshotMetadata">
        /// Required when identity is a delta snapshot.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HotLoadRequestV1(
            string identity,
            global::Baseten.HotLoadIncrementalSnapshotMetadataV1? incrementalSnapshotMetadata)
        {
            this.Identity = identity ?? throw new global::System.ArgumentNullException(nameof(identity));
            this.IncrementalSnapshotMetadata = incrementalSnapshotMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HotLoadRequestV1" /> class.
        /// </summary>
        public HotLoadRequestV1()
        {
        }

    }
}