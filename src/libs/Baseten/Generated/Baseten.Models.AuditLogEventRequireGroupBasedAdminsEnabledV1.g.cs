
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Group-based admin enforcement was enabled for the organization.
    /// </summary>
    public sealed partial class AuditLogEventRequireGroupBasedAdminsEnabledV1
    {
        /// <summary>
        /// 
        /// </summary>
        /// <default>"REQUIRE_GROUP_BASED_ADMINS_ENABLED"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        public string EventType { get; set; } = "REQUIRE_GROUP_BASED_ADMINS_ENABLED";

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("organization_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrganizationId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventRequireGroupBasedAdminsEnabledV1" /> class.
        /// </summary>
        /// <param name="organizationId"></param>
        /// <param name="eventType"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogEventRequireGroupBasedAdminsEnabledV1(
            string organizationId,
            string eventType = "REQUIRE_GROUP_BASED_ADMINS_ENABLED")
        {
            this.EventType = eventType;
            this.OrganizationId = organizationId ?? throw new global::System.ArgumentNullException(nameof(organizationId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogEventRequireGroupBasedAdminsEnabledV1" /> class.
        /// </summary>
        public AuditLogEventRequireGroupBasedAdminsEnabledV1()
        {
        }

        /// <summary>
        /// Creates a new <see cref="AuditLogEventRequireGroupBasedAdminsEnabledV1"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static AuditLogEventRequireGroupBasedAdminsEnabledV1 FromOrganizationId(string organizationId)
        {
            return new AuditLogEventRequireGroupBasedAdminsEnabledV1
            {
                OrganizationId = organizationId,
            };
        }

    }
}