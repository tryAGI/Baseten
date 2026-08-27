
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class CreateGroupHierarchyV1
    {
        /// <summary>
        /// Limit behavior. Child groups inherit their parent's behavior when omitted; root groups default to Independent for backwards compatibility.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_enforcement")]
        public global::Baseten.LimitEnforcementV1? LimitEnforcement { get; set; }

        /// <summary>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_group_id")]
        public string? ParentGroupId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGroupHierarchyV1" /> class.
        /// </summary>
        /// <param name="limitEnforcement">
        /// Limit behavior. Child groups inherit their parent's behavior when omitted; root groups default to Independent for backwards compatibility.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="parentGroupId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateGroupHierarchyV1(
            global::Baseten.LimitEnforcementV1? limitEnforcement,
            string? parentGroupId)
        {
            this.LimitEnforcement = limitEnforcement;
            this.ParentGroupId = parentGroupId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateGroupHierarchyV1" /> class.
        /// </summary>
        public CreateGroupHierarchyV1()
        {
        }

    }
}