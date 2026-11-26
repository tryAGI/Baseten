
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The RL weight-sync status of every replica in a deployment.
    /// </summary>
    public sealed partial class HotLoadStatusV1
    {
        /// <summary>
        /// Revision of the deployment's newest hot-load target, or null if none was set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("revision")]
        public int? Revision { get; set; }

        /// <summary>
        /// One entry per replica.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicas")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.HotLoadReplicaV1> Replicas { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HotLoadStatusV1" /> class.
        /// </summary>
        /// <param name="replicas">
        /// One entry per replica.
        /// </param>
        /// <param name="revision">
        /// Revision of the deployment's newest hot-load target, or null if none was set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HotLoadStatusV1(
            global::System.Collections.Generic.IList<global::Baseten.HotLoadReplicaV1> replicas,
            int? revision)
        {
            this.Revision = revision;
            this.Replicas = replicas ?? throw new global::System.ArgumentNullException(nameof(replicas));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HotLoadStatusV1" /> class.
        /// </summary>
        public HotLoadStatusV1()
        {
        }

    }
}