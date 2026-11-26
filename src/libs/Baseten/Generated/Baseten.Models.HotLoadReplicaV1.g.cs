
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A replica's lifecycle status and RL weight-sync state.
    /// </summary>
    public sealed partial class HotLoadReplicaV1
    {
        /// <summary>
        /// Replica ID, as in the deployment's replicas list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replica_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReplicaId { get; set; }

        /// <summary>
        /// Replica lifecycle status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replica_status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.HotLoadReplicaV1ReplicaStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.HotLoadReplicaV1ReplicaStatus ReplicaStatus { get; set; }

        /// <summary>
        /// The replica's weight-sync state, or null if it has not reported one.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("loading_state")]
        public global::Baseten.HotLoadLoadingStateV1? LoadingState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HotLoadReplicaV1" /> class.
        /// </summary>
        /// <param name="replicaId">
        /// Replica ID, as in the deployment's replicas list.
        /// </param>
        /// <param name="replicaStatus">
        /// Replica lifecycle status.
        /// </param>
        /// <param name="loadingState">
        /// The replica's weight-sync state, or null if it has not reported one.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HotLoadReplicaV1(
            string replicaId,
            global::Baseten.HotLoadReplicaV1ReplicaStatus replicaStatus,
            global::Baseten.HotLoadLoadingStateV1? loadingState)
        {
            this.ReplicaId = replicaId ?? throw new global::System.ArgumentNullException(nameof(replicaId));
            this.ReplicaStatus = replicaStatus;
            this.LoadingState = loadingState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HotLoadReplicaV1" /> class.
        /// </summary>
        public HotLoadReplicaV1()
        {
        }

    }
}