
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A model deployment's instance type was changed.
    /// </summary>
    public sealed partial class AuditLogEventModelDeploymentInstanceTypeChangedV1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"MODEL_DEPLOYMENT_INSTANCE_TYPE_CHANGED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "MODEL_DEPLOYMENT_INSTANCE_TYPE_CHANGED";

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
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_type_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InstanceTypeName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventModelDeploymentInstanceTypeChangedV1" /> class.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="modelName"></param>
        /// <param name="deploymentId"></param>
        /// <param name="deploymentName"></param>
        /// <param name="instanceTypeName"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventModelDeploymentInstanceTypeChangedV1(
            string modelId,
            string modelName,
            string deploymentId,
            string deploymentName,
            string instanceTypeName,
            string eventType = "MODEL_DEPLOYMENT_INSTANCE_TYPE_CHANGED")
        {
            this.EventType = eventType;
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.DeploymentId = deploymentId ?? throw new global::System.ArgumentNullException(nameof(deploymentId));
            this.DeploymentName = deploymentName ?? throw new global::System.ArgumentNullException(nameof(deploymentName));
            this.InstanceTypeName = instanceTypeName ?? throw new global::System.ArgumentNullException(nameof(instanceTypeName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventModelDeploymentInstanceTypeChangedV1" /> class.
        /// </summary>
        public AuditLogEventModelDeploymentInstanceTypeChangedV1()
        {
        }

    }
}