
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A service account was created.
    /// </summary>
    public sealed partial class AuditLogEventServiceAccountCreatedV1
    {
        /// <summary>
        ///
        /// </summary>
        /// <default>"SERVICE_ACCOUNT_CREATED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "SERVICE_ACCOUNT_CREATED";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_account_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ServiceAccountId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Null when the account was created without one.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// The team that owns the account. Null for an organization account.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owner_team_id")]
        public string? OwnerTeamId { get; set; }

        /// <summary>
        /// A service account's access, as recorded on a service account event. Not itself an event<br/>
        /// payload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("preset_permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.AuditLogEventServiceAccountPresetPermissionsV1 PresetPermissions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventServiceAccountCreatedV1" /> class.
        /// </summary>
        /// <param name="serviceAccountId"></param>
        /// <param name="name"></param>
        /// <param name="presetPermissions">
        /// A service account's access, as recorded on a service account event. Not itself an event<br/>
        /// payload.
        /// </param>
        /// <param name="description">
        /// Null when the account was created without one.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="ownerTeamId">
        /// The team that owns the account. Null for an organization account.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventServiceAccountCreatedV1(
            string serviceAccountId,
            string name,
            global::Baseten.AuditLogEventServiceAccountPresetPermissionsV1 presetPermissions,
            string? description,
            string? ownerTeamId,
            string eventType = "SERVICE_ACCOUNT_CREATED")
        {
            this.EventType = eventType;
            this.ServiceAccountId = serviceAccountId ?? throw new global::System.ArgumentNullException(nameof(serviceAccountId));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.OwnerTeamId = ownerTeamId;
            this.PresetPermissions = presetPermissions ?? throw new global::System.ArgumentNullException(nameof(presetPermissions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventServiceAccountCreatedV1" /> class.
        /// </summary>
        public AuditLogEventServiceAccountCreatedV1()
        {
        }

    }
}