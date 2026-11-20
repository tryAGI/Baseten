
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AccessRoleRequestV1
    {
        /// <summary>
        /// ID of a team. Gets the role only if `GET /v1/access/roles` lists it for that team, and checks your access in that team.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRoleRequestV1" /> class.
        /// </summary>
        /// <param name="teamId">
        /// ID of a team. Gets the role only if `GET /v1/access/roles` lists it for that team, and checks your access in that team.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AccessRoleRequestV1(
            string? teamId)
        {
            this.TeamId = teamId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRoleRequestV1" /> class.
        /// </summary>
        public AccessRoleRequestV1()
        {
        }

    }
}