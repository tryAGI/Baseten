
#nullable enable

namespace Baseten
{
    /// <summary>
    /// An API key was created.
    /// </summary>
    public sealed partial class AuditLogEventApiKeyCreatedV1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"API_KEY_CREATED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "API_KEY_CREATED";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKeyId { get; set; }

        /// <summary>
        /// Type of API key recorded on an API-key event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AuditLogApiKeyTypeV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AuditLogApiKeyTypeV1 ApiKeyType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prefix")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Prefix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventApiKeyCreatedV1" /> class.
        /// </summary>
        /// <param name="apiKeyId"></param>
        /// <param name="apiKeyType">
        /// Type of API key recorded on an API-key event.
        /// </param>
        /// <param name="prefix"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventApiKeyCreatedV1(
            string apiKeyId,
            global::Baseten.AuditLogApiKeyTypeV1 apiKeyType,
            string prefix,
            string eventType = "API_KEY_CREATED")
        {
            this.EventType = eventType;
            this.ApiKeyId = apiKeyId ?? throw new global::System.ArgumentNullException(nameof(apiKeyId));
            this.ApiKeyType = apiKeyType;
            this.Prefix = prefix ?? throw new global::System.ArgumentNullException(nameof(prefix));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventApiKeyCreatedV1" /> class.
        /// </summary>
        public AuditLogEventApiKeyCreatedV1()
        {
        }

    }
}