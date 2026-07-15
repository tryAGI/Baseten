
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A single audit-log entry.
    /// </summary>
    public sealed partial class AuditLogEntryV1
    {
        /// <summary>
        /// Unique identifier of the audit-log entry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Time the action occurred, in ISO 8601 format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime Created { get; set; }

        /// <summary>
        /// Type of action that was recorded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AuditLogEventTypeV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AuditLogEventTypeV1 EventType { get; set; }

        /// <summary>
        /// Structured details of the action, discriminated by `event_type`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_data")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.EventDataJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.EventData EventData { get; set; }

        /// <summary>
        /// Surface that issued the action, if known.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public global::Baseten.AuditLogSourceV1? Source { get; set; }

        /// <summary>
        /// The actor that performed the action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("actor")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AuditLogActorV1 Actor { get; set; }

        /// <summary>
        /// Name of the client that issued the action, if known.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_name")]
        public string? ClientName { get; set; }

        /// <summary>
        /// Version of the client that issued the action, if known.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_version")]
        public string? ClientVersion { get; set; }

        /// <summary>
        /// Opaque identifier grouping actions from the same client session, if known.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_session_id")]
        public string? ClientSessionId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEntryV1" /> class.
        /// </summary>
        /// <param name="id">
        /// Unique identifier of the audit-log entry.
        /// </param>
        /// <param name="created">
        /// Time the action occurred, in ISO 8601 format.
        /// </param>
        /// <param name="eventType">
        /// Type of action that was recorded.
        /// </param>
        /// <param name="eventData">
        /// Structured details of the action, discriminated by `event_type`.
        /// </param>
        /// <param name="actor">
        /// The actor that performed the action.
        /// </param>
        /// <param name="source">
        /// Surface that issued the action, if known.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="clientName">
        /// Name of the client that issued the action, if known.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="clientVersion">
        /// Version of the client that issued the action, if known.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="clientSessionId">
        /// Opaque identifier grouping actions from the same client session, if known.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEntryV1(
            string id,
            global::System.DateTime created,
            global::Baseten.AuditLogEventTypeV1 eventType,
            global::Baseten.EventData eventData,
            global::Baseten.AuditLogActorV1 actor,
            global::Baseten.AuditLogSourceV1? source,
            string? clientName,
            string? clientVersion,
            string? clientSessionId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Created = created;
            this.EventType = eventType;
            this.EventData = eventData;
            this.Source = source;
            this.Actor = actor ?? throw new global::System.ArgumentNullException(nameof(actor));
            this.ClientName = clientName;
            this.ClientVersion = clientVersion;
            this.ClientSessionId = clientSessionId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEntryV1" /> class.
        /// </summary>
        public AuditLogEntryV1()
        {
        }

    }
}