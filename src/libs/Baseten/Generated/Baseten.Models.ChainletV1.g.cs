
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A chainlet in a chain deployment.
    /// </summary>
    public sealed partial class ChainletV1
    {
        /// <summary>
        /// Unique identifier of the chainlet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Name of the chainlet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Autoscaling settings for the chainlet. If null, it has not finished deploying
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling_settings")]
        public global::Baseten.AutoscalingSettingsV1? AutoscalingSettings { get; set; }

        /// <summary>
        /// Name of the instance type the chainlet is deployed on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_type_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string InstanceTypeName { get; set; }

        /// <summary>
        /// Number of active replicas
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("active_replica_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ActiveReplicaCount { get; set; }

        /// <summary>
        /// Status of the chainlet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.DeploymentStatusV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.DeploymentStatusV1 Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainletV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the chainlet
        /// </param>
        /// <param name="name">
        /// Name of the chainlet
        /// </param>
        /// <param name="instanceTypeName">
        /// Name of the instance type the chainlet is deployed on
        /// </param>
        /// <param name="activeReplicaCount">
        /// Number of active replicas
        /// </param>
        /// <param name="status">
        /// Status of the chainlet
        /// </param>
        /// <param name="autoscalingSettings">
        /// Autoscaling settings for the chainlet. If null, it has not finished deploying
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChainletV1(
            string id,
            string name,
            string instanceTypeName,
            int activeReplicaCount,
            global::Baseten.DeploymentStatusV1 status,
            global::Baseten.AutoscalingSettingsV1? autoscalingSettings)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AutoscalingSettings = autoscalingSettings;
            this.InstanceTypeName = instanceTypeName ?? throw new global::System.ArgumentNullException(nameof(instanceTypeName));
            this.ActiveReplicaCount = activeReplicaCount;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainletV1" /> class.
        /// </summary>
        public ChainletV1()
        {
        }
    }
}