
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A replica's RL weight-sync state, as last reported by the replica.
    /// </summary>
    public sealed partial class HotLoadLoadingStateV1
    {
        /// <summary>
        /// One of loading, done, rejected, or error. A replica behind the deployment's revision is reported as loading.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hotload_stage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string HotloadStage { get; set; }

        /// <summary>
        /// Identity of the snapshot the replica serves.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("current_snapshot_identity")]
        public string? CurrentSnapshotIdentity { get; set; }

        /// <summary>
        /// Identity of the snapshot the replica is loading or last tried to load.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target_snapshot_identity")]
        public string? TargetSnapshotIdentity { get; set; }

        /// <summary>
        /// Why the replica rejected or failed its target.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Revision of the target the replica last took, or null if it has taken none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        public int? Revision { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HotLoadLoadingStateV1" /> class.
        /// </summary>
        /// <param name="hotloadStage">
        /// One of loading, done, rejected, or error. A replica behind the deployment's revision is reported as loading.
        /// </param>
        /// <param name="currentSnapshotIdentity">
        /// Identity of the snapshot the replica serves.
        /// </param>
        /// <param name="targetSnapshotIdentity">
        /// Identity of the snapshot the replica is loading or last tried to load.
        /// </param>
        /// <param name="reason">
        /// Why the replica rejected or failed its target.
        /// </param>
        /// <param name="revision">
        /// Revision of the target the replica last took, or null if it has taken none.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HotLoadLoadingStateV1(
            string hotloadStage,
            string? currentSnapshotIdentity,
            string? targetSnapshotIdentity,
            string? reason,
            int? revision)
        {
            this.HotloadStage = hotloadStage ?? throw new global::System.ArgumentNullException(nameof(hotloadStage));
            this.CurrentSnapshotIdentity = currentSnapshotIdentity;
            this.TargetSnapshotIdentity = targetSnapshotIdentity;
            this.Reason = reason;
            this.Revision = revision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HotLoadLoadingStateV1" /> class.
        /// </summary>
        public HotLoadLoadingStateV1()
        {
        }

    }
}