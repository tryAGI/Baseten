
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A model deployment's request backpressure policy was changed.
    /// </summary>
    public sealed partial class AuditLogEventModelDeploymentBackpressurePolicyChangedV1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"MODEL_DEPLOYMENT_BACKPRESSURE_POLICY_CHANGED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "MODEL_DEPLOYMENT_BACKPRESSURE_POLICY_CHANGED";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deployment_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string DeploymentName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_backpressure_policy")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RequestBackpressurePolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventModelDeploymentBackpressurePolicyChangedV1" /> class.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="modelName"></param>
        /// <param name="deploymentId"></param>
        /// <param name="deploymentName"></param>
        /// <param name="requestBackpressurePolicy"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventModelDeploymentBackpressurePolicyChangedV1(
            string modelId,
            string modelName,
            string deploymentId,
            string deploymentName,
            string requestBackpressurePolicy,
            string eventType = "MODEL_DEPLOYMENT_BACKPRESSURE_POLICY_CHANGED")
        {
            this.EventType = eventType;
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.DeploymentName = deploymentName ?? throw new global::System.ArgumentNullException(nameof(deploymentName));
            this.RequestBackpressurePolicy = requestBackpressurePolicy ?? throw new global::System.ArgumentNullException(nameof(requestBackpressurePolicy));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventModelDeploymentBackpressurePolicyChangedV1" /> class.
        /// </summary>
        public AuditLogEventModelDeploymentBackpressurePolicyChangedV1()
        {
        }

    }
}