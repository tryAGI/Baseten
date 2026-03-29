
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A deployment of a model.
    /// </summary>
    public sealed partial class DeploymentV1
    {
        /// <summary>
        /// Unique identifier of the deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Time the deployment was created in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// Name of the deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Unique identifier of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// Whether the deployment is the production deployment of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_production")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsProduction { get; set; }

        /// <summary>
        /// Whether the deployment is the development deployment of the model
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_development")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsDevelopment { get; set; }

        /// <summary>
        /// Status of the deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.DeploymentStatusV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.DeploymentStatusV1 Status { get; set; }

        /// <summary>
        /// Number of active replicas
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_replica_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ActiveReplicaCount { get; set; }

        /// <summary>
        /// Autoscaling settings for the deployment. If null, the model has not finished deploying
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling_settings")]
        public global::Baseten.AutoscalingSettingsV1? AutoscalingSettings { get; set; }

        /// <summary>
        /// Name of the instance type the model deployment is running on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_type_name")]
        public string? InstanceTypeName { get; set; }

        /// <summary>
        /// The environment associated with the deployment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment")]
        public string? Environment { get; set; }

        /// <summary>
        /// User-provided key-value labels for the deployment<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("labels")]
        public object? Labels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the deployment
        /// </param>
        /// <param name="createdAt">
        /// Time the deployment was created in ISO 8601 format
        /// </param>
        /// <param name="name">
        /// Name of the deployment
        /// </param>
        /// <param name="modelId">
        /// Unique identifier of the model
        /// </param>
        /// <param name="isProduction">
        /// Whether the deployment is the production deployment of the model
        /// </param>
        /// <param name="isDevelopment">
        /// Whether the deployment is the development deployment of the model
        /// </param>
        /// <param name="status">
        /// Status of the deployment
        /// </param>
        /// <param name="activeReplicaCount">
        /// Number of active replicas
        /// </param>
        /// <param name="autoscalingSettings">
        /// Autoscaling settings for the deployment. If null, the model has not finished deploying
        /// </param>
        /// <param name="instanceTypeName">
        /// Name of the instance type the model deployment is running on
        /// </param>
        /// <param name="environment">
        /// The environment associated with the deployment
        /// </param>
        /// <param name="labels">
        /// User-provided key-value labels for the deployment<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentV1(
            string id,
            global::System.DateTime createdAt,
            string name,
            string modelId,
            bool isProduction,
            bool isDevelopment,
            global::Baseten.DeploymentStatusV1 status,
            int activeReplicaCount,
            global::Baseten.AutoscalingSettingsV1? autoscalingSettings,
            string? instanceTypeName,
            string? environment,
            object? labels)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.CreatedAt = createdAt;
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.IsProduction = isProduction;
            this.IsDevelopment = isDevelopment;
            this.Status = status;
            this.ActiveReplicaCount = activeReplicaCount;
            this.AutoscalingSettings = autoscalingSettings;
            this.InstanceTypeName = instanceTypeName;
            this.Environment = environment;
            this.Labels = labels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentV1" /> class.
        /// </summary>
        public DeploymentV1()
        {
        }
    }
}