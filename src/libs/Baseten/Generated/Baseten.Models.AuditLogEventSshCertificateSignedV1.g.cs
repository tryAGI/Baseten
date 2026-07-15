
#nullable enable

namespace Baseten
{
    /// <summary>
    /// An SSH certificate was signed for a workload.
    /// </summary>
    public sealed partial class AuditLogEventSshCertificateSignedV1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"SSH_CERTIFICATE_SIGNED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "SSH_CERTIFICATE_SIGNED";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workload_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkloadType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workload_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WorkloadId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replica_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ReplicaId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("proxy_address")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProxyAddress { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExpiresAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventSshCertificateSignedV1" /> class.
        /// </summary>
        /// <param name="workloadType"></param>
        /// <param name="workloadId"></param>
        /// <param name="projectId"></param>
        /// <param name="replicaId"></param>
        /// <param name="proxyAddress"></param>
        /// <param name="expiresAt"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventSshCertificateSignedV1(
            string workloadType,
            string workloadId,
            string projectId,
            string replicaId,
            string proxyAddress,
            string expiresAt,
            string eventType = "SSH_CERTIFICATE_SIGNED")
        {
            this.EventType = eventType;
            this.WorkloadType = workloadType ?? throw new global::System.ArgumentNullException(nameof(workloadType));
            this.WorkloadId = workloadId ?? throw new global::System.ArgumentNullException(nameof(workloadId));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.ReplicaId = replicaId ?? throw new global::System.ArgumentNullException(nameof(replicaId));
            this.ProxyAddress = proxyAddress ?? throw new global::System.ArgumentNullException(nameof(proxyAddress));
            this.ExpiresAt = expiresAt ?? throw new global::System.ArgumentNullException(nameof(expiresAt));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventSshCertificateSignedV1" /> class.
        /// </summary>
        public AuditLogEventSshCertificateSignedV1()
        {
        }

    }
}