
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
        /// Display name of the acting API key, when the actor is an API key.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_name")]
        public string? ApiKeyName { get; set; }

        /// <summary>
        /// ID of the acting service account, when the actor is a service account.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_id")]
        public string? ServiceAccountId { get; set; }

        /// <summary>
        /// Current name of the acting service account, when the actor is a service account.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_name")]
        public string? ServiceAccountName { get; set; }

        /// <summary>
        /// ID of the trust rule the acting workload identity federation token was exchanged through, when the actor is a service account.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trust_rule_id")]
        public string? TrustRuleId { get; set; }

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
        /// <param name="apiKeyName">
        /// Display name of the acting API key, when the actor is an API key.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="serviceAccountId">
        /// ID of the acting service account, when the actor is a service account.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="serviceAccountName">
        /// Current name of the acting service account, when the actor is a service account.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="trustRuleId">
        /// ID of the trust rule the acting workload identity federation token was exchanged through, when the actor is a service account.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogActorV1(
            global::Baseten.AuditLogActorTypeV1 type,
            string? email,
            string? apiKeyPrefix,
            string? apiKeyName,
            string? serviceAccountId,
            string? serviceAccountName,
            string? trustRuleId)
        {
            this.Type = type;
            this.Email = email;
            this.ApiKeyPrefix = apiKeyPrefix;
            this.ApiKeyName = apiKeyName;
            this.ServiceAccountId = serviceAccountId;
            this.ServiceAccountName = serviceAccountName;
            this.TrustRuleId = trustRuleId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogActorV1" /> class.
        /// </summary>
        public AuditLogActorV1()
        {
        }

    }
}