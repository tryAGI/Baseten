
#nullable enable

namespace Baseten
{
    /// <summary>
    /// An administrator changed which classes of API key the organization allows creating.
    /// </summary>
    public sealed partial class AuditLogEventOrganizationApiKeySettingsUpdatedV1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"ORGANIZATION_API_KEY_SETTINGS_UPDATED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "ORGANIZATION_API_KEY_SETTINGS_UPDATED";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_allow_personal_api_keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PreviousAllowPersonalApiKeys { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_allow_personal_api_keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool NewAllowPersonalApiKeys { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_allow_service_account_api_keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PreviousAllowServiceAccountApiKeys { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_allow_service_account_api_keys")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool NewAllowServiceAccountApiKeys { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventOrganizationApiKeySettingsUpdatedV1" /> class.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="previousAllowPersonalApiKeys"></param>
        /// <param name="newAllowPersonalApiKeys"></param>
        /// <param name="previousAllowServiceAccountApiKeys"></param>
        /// <param name="newAllowServiceAccountApiKeys"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventOrganizationApiKeySettingsUpdatedV1(
            string organizationId,
            bool previousAllowPersonalApiKeys,
            bool newAllowPersonalApiKeys,
            bool previousAllowServiceAccountApiKeys,
            bool newAllowServiceAccountApiKeys,
            string eventType = "ORGANIZATION_API_KEY_SETTINGS_UPDATED")
        {
            this.EventType = eventType;
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
            this.PreviousAllowPersonalApiKeys = previousAllowPersonalApiKeys;
            this.NewAllowPersonalApiKeys = newAllowPersonalApiKeys;
            this.PreviousAllowServiceAccountApiKeys = previousAllowServiceAccountApiKeys;
            this.NewAllowServiceAccountApiKeys = newAllowServiceAccountApiKeys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventOrganizationApiKeySettingsUpdatedV1" /> class.
        /// </summary>
        public AuditLogEventOrganizationApiKeySettingsUpdatedV1()
        {
        }

    }
}