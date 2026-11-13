
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A service account's access, as recorded on a service account event. Not itself an event<br/>
    /// payload.
    /// </summary>
    public sealed partial class AuditLogEventServiceAccountPresetPermissionsV1
    {
        /// <summary>
        /// The API key type whose permissions the account has, as API key events record it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ApiKeyType { get; set; }

        /// <summary>
        /// Models the access is limited to; empty for all.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ModelIds { get; set; }

        /// <summary>
        /// Environments the access is limited to, or may also manage; empty for none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_names")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> EnvironmentNames { get; set; }

        /// <summary>
        /// Model APIs the access is limited to; empty for all.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_api_slugs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ModelApiSlugs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventServiceAccountPresetPermissionsV1" /> class.
        /// </summary>
        /// <param name="apiKeyType">
        /// The API key type whose permissions the account has, as API key events record it.
        /// </param>
        /// <param name="modelIds">
        /// Models the access is limited to; empty for all.
        /// </param>
        /// <param name="environmentNames">
        /// Environments the access is limited to, or may also manage; empty for none.
        /// </param>
        /// <param name="modelApiSlugs">
        /// Model APIs the access is limited to; empty for all.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventServiceAccountPresetPermissionsV1(
            string apiKeyType,
            global::System.Collections.Generic.IList<string> modelIds,
            global::System.Collections.Generic.IList<string> environmentNames,
            global::System.Collections.Generic.IList<string> modelApiSlugs)
        {
            this.ApiKeyType = apiKeyType ?? throw new global::System.ArgumentNullException(nameof(apiKeyType));
            this.ModelIds = modelIds ?? throw new global::System.ArgumentNullException(nameof(modelIds));
            this.EnvironmentNames = environmentNames ?? throw new global::System.ArgumentNullException(nameof(environmentNames));
            this.ModelApiSlugs = modelApiSlugs ?? throw new global::System.ArgumentNullException(nameof(modelApiSlugs));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventServiceAccountPresetPermissionsV1" /> class.
        /// </summary>
        public AuditLogEventServiceAccountPresetPermissionsV1()
        {
        }

    }
}