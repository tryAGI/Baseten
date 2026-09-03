
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The caller's organization.
    /// </summary>
    public sealed partial class OrganizationInfoV1
    {
        /// <summary>
        /// Unique identifier for the organization
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("org_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string OrgId { get; set; }

        /// <summary>
        /// Display name of the organization<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Time the organization was created in ISO 8601 format
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime CreatedAt { get; set; }

        /// <summary>
        /// AWS AssumeRole trust-policy inputs; null while the method is not enabled for the organization<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aws_assume_role")]
        public global::Baseten.AwsAssumeRoleV1? AwsAssumeRole { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInfoV1" /> class.
        /// </summary>
        /// <param name="orgId">
        /// Unique identifier for the organization
        /// </param>
        /// <param name="createdAt">
        /// Time the organization was created in ISO 8601 format
        /// </param>
        /// <param name="name">
        /// Display name of the organization<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="awsAssumeRole">
        /// AWS AssumeRole trust-policy inputs; null while the method is not enabled for the organization<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationInfoV1(
            string orgId,
            global::System.DateTime createdAt,
            string? name,
            global::Baseten.AwsAssumeRoleV1? awsAssumeRole)
        {
            this.OrgId = orgId ?? throw new global::System.ArgumentNullException(nameof(orgId));
            this.Name = name;
            this.CreatedAt = createdAt;
            this.AwsAssumeRole = awsAssumeRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInfoV1" /> class.
        /// </summary>
        public OrganizationInfoV1()
        {
        }

    }
}