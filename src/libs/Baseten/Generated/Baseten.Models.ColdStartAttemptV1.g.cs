
#nullable enable

namespace Baseten
{
    /// <summary>
    /// One cold start attempt of a replica.
    /// </summary>
    public sealed partial class ColdStartAttemptV1
    {
        /// <summary>
        /// Unique identifier of the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// Unique identifier of the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_id")]
        public string? DeploymentId { get; set; }

        /// <summary>
        /// Name of the deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentName { get; set; }

        /// <summary>
        /// Name of the environment. Null when querying a deployment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_name")]
        public string? EnvironmentName { get; set; }

        /// <summary>
        /// Identifier of the replica that started.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replica_id")]
        public string? ReplicaId { get; set; }

        /// <summary>
        /// Time the attempt started, in epoch milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("started_at_epoch_millis")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long StartedAtEpochMillis { get; set; }

        /// <summary>
        /// Time the replica became ready, in epoch milliseconds. Null if it never did.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ready_at_epoch_millis")]
        public long? ReadyAtEpochMillis { get; set; }

        /// <summary>
        /// Duration of the attempt, in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("duration_ms")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int DurationMs { get; set; }

        /// <summary>
        /// Outcome of the attempt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outcome")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.ColdStartOutcomeV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.ColdStartOutcomeV1 Outcome { get; set; }

        /// <summary>
        /// Phases recorded during the attempt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("phase_summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.ColdStartPhaseSummaryV1> PhaseSummary { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ColdStartAttemptV1" /> class.
        /// </summary>
        /// <param name="modelId">
        /// Unique identifier of the model.
        /// </param>
        /// <param name="deploymentName">
        /// Name of the deployment.
        /// </param>
        /// <param name="startedAtEpochMillis">
        /// Time the attempt started, in epoch milliseconds.
        /// </param>
        /// <param name="durationMs">
        /// Duration of the attempt, in milliseconds.
        /// </param>
        /// <param name="outcome">
        /// Outcome of the attempt.
        /// </param>
        /// <param name="phaseSummary">
        /// Phases recorded during the attempt.
        /// </param>
        /// <param name="deploymentId">
        /// Unique identifier of the deployment.
        /// </param>
        /// <param name="environmentName">
        /// Name of the environment. Null when querying a deployment.
        /// </param>
        /// <param name="replicaId">
        /// Identifier of the replica that started.
        /// </param>
        /// <param name="readyAtEpochMillis">
        /// Time the replica became ready, in epoch milliseconds. Null if it never did.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ColdStartAttemptV1(
            string modelId,
            string deploymentName,
            long startedAtEpochMillis,
            int durationMs,
            global::Baseten.ColdStartOutcomeV1 outcome,
            global::System.Collections.Generic.IList<global::Baseten.ColdStartPhaseSummaryV1> phaseSummary,
            string? deploymentId,
            string? environmentName,
            string? replicaId,
            long? readyAtEpochMillis)
        {
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.DeploymentId = deploymentId;
            this.DeploymentName = deploymentName ?? throw new global::System.ArgumentNullException(nameof(deploymentName));
            this.EnvironmentName = environmentName;
            this.ReplicaId = replicaId;
            this.StartedAtEpochMillis = startedAtEpochMillis;
            this.ReadyAtEpochMillis = readyAtEpochMillis;
            this.DurationMs = durationMs;
            this.Outcome = outcome;
            this.PhaseSummary = phaseSummary ?? throw new global::System.ArgumentNullException(nameof(phaseSummary));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ColdStartAttemptV1" /> class.
        /// </summary>
        public ColdStartAttemptV1()
        {
        }

    }
}