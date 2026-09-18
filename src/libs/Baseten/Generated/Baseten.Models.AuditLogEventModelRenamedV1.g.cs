
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A model was renamed. `model_name` is the new name.
    /// </summary>
    public sealed partial class AuditLogEventModelRenamedV1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"MODEL_RENAMED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "MODEL_RENAMED";

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
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_name")]
        public string? PreviousName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventModelRenamedV1" /> class.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="modelName"></param>
        /// <param name="previousName"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventModelRenamedV1(
            string modelId,
            string modelName,
            string? previousName,
            string eventType = "MODEL_RENAMED")
        {
            this.EventType = eventType;
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.ModelName = modelName ?? throw new global::System.ArgumentNullException(nameof(modelName));
            this.PreviousName = previousName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventModelRenamedV1" /> class.
        /// </summary>
        public AuditLogEventModelRenamedV1()
        {
        }

    }
}