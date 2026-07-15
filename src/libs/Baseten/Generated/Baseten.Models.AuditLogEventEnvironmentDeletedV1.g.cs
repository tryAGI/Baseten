
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A model environment was deleted.
    /// </summary>
    public sealed partial class AuditLogEventEnvironmentDeletedV1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"ENVIRONMENT_DELETED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "ENVIRONMENT_DELETED";

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
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventEnvironmentDeletedV1" /> class.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="modelName"></param>
        /// <param name="environmentName"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventEnvironmentDeletedV1(
            string modelId,
            string modelName,
            string environmentName,
            string eventType = "ENVIRONMENT_DELETED")
        {
            this.EventType = eventType;
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.EnvironmentName = environmentName ?? throw new global::System.ArgumentNullException(nameof(environmentName));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventEnvironmentDeletedV1" /> class.
        /// </summary>
        public AuditLogEventEnvironmentDeletedV1()
        {
        }

    }
}