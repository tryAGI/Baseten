
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeploymentReplicaV1
    {
        /// <summary>
        /// Pod-name suffix used for replica lookup and termination, usually five characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// ID of the replica's deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentId { get; set; }

        /// <summary>
        /// Name of the replica's deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentName { get; set; }

        /// <summary>
        /// Current replica lifecycle status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.DeploymentReplicaStatusV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.DeploymentReplicaStatusV1 Status { get; set; }

        /// <summary>
        /// Replica creation time in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Observed termination completion time in ISO 8601 format, or null if unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("terminated_at")]
        public global::System.DateTime? TerminatedAt { get; set; }

        /// <summary>
        /// Age in seconds since creation, frozen at termination.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("age_seconds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AgeSeconds { get; set; }

        /// <summary>
        /// Model container lifetime restart count, or null if unavailable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("restart_count")]
        public int? RestartCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentReplicaV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Pod-name suffix used for replica lookup and termination, usually five characters.
        /// </param>
        /// <param name="deploymentId">
        /// ID of the replica's deployment.
        /// </param>
        /// <param name="deploymentName">
        /// Name of the replica's deployment.
        /// </param>
        /// <param name="status">
        /// Current replica lifecycle status.
        /// </param>
        /// <param name="createdAt">
        /// Replica creation time in ISO 8601 format.
        /// </param>
        /// <param name="ageSeconds">
        /// Age in seconds since creation, frozen at termination.
        /// </param>
        /// <param name="terminatedAt">
        /// Observed termination completion time in ISO 8601 format, or null if unavailable.
        /// </param>
        /// <param name="restartCount">
        /// Model container lifetime restart count, or null if unavailable.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentReplicaV1(
            string id,
            string deploymentId,
            string deploymentName,
            global::Baseten.DeploymentReplicaStatusV1 status,
            global::System.DateTime createdAt,
            double ageSeconds,
            global::System.DateTime? terminatedAt,
            int? restartCount)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.DeploymentName = deploymentName ?? throw new global::System.ArgumentNullException(nameof(deploymentName));
            this.Status = status;
            this.CreatedAt = createdAt;
            this.TerminatedAt = terminatedAt;
            this.AgeSeconds = ageSeconds;
            this.RestartCount = restartCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentReplicaV1" /> class.
        /// </summary>
        public DeploymentReplicaV1()
        {
        }

    }
}