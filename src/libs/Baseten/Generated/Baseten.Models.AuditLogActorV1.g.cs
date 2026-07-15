
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The actor that performed an audited action.
    /// </summary>
    public sealed partial class AuditLogActorV1
    {
        /// <summary>
        /// Kind of actor that performed the action.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AuditLogActorTypeV1JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AuditLogActorTypeV1 Type { get; set; }

        /// <summary>
        /// Email of the acting user, when the actor is a user.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Prefix of the acting API key, when the actor is an API key.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_prefix")]
        public string? ApiKeyPrefix { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogActorV1" /> class.
        /// </summary>
        /// <param name="type">
        /// Kind of actor that performed the action.
        /// </param>
        /// <param name="email">
        /// Email of the acting user, when the actor is a user.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="apiKeyPrefix">
        /// Prefix of the acting API key, when the actor is an API key.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogActorV1(
            global::Baseten.AuditLogActorTypeV1 type,
            string? email,
            string? apiKeyPrefix)
        {
            this.Type = type;
            this.Email = email;
            this.ApiKeyPrefix = apiKeyPrefix;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogActorV1" /> class.
        /// </summary>
        public AuditLogActorV1()
        {
        }

    }
}