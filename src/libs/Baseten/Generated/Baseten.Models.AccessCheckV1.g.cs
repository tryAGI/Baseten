
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A permission to check: for the organization, in a team, or on a resource.
    /// </summary>
    public sealed partial class AccessCheckV1
    {
        /// <summary>
        /// Name of the permission, such as `model.deployment.write`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permission")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Permission { get; set; }

        /// <summary>
        /// ID of a team to check the permission in. To check whether you can create a resource, check its write permission in the team you create it in.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// A resource to check the permission on. Omit `team_id` and `resource` to check the permission for the organization.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource")]
        public global::Baseten.AccessResourceUpdateV1? Resource { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessCheckV1" /> class.
        /// </summary>
        /// <param name="permission">
        /// Name of the permission, such as `model.deployment.write`
        /// </param>
        /// <param name="teamId">
        /// ID of a team to check the permission in. To check whether you can create a resource, check its write permission in the team you create it in.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="resource">
        /// A resource to check the permission on. Omit `team_id` and `resource` to check the permission for the organization.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessCheckV1(
            string permission,
            string? teamId,
            global::Baseten.AccessResourceUpdateV1? resource)
        {
            this.Permission = permission ?? throw new global::System.ArgumentNullException(nameof(permission));
            this.TeamId = teamId;
            this.Resource = resource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessCheckV1" /> class.
        /// </summary>
        public AccessCheckV1()
        {
        }

    }
}