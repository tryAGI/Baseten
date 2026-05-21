
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroupHierarchyV1
    {
        /// <summary>
        /// Default Value: INDEPENDENT
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_enforcement")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.LimitEnforcementV1JsonConverter))]
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
        /// Initializes a new instance of the <see cref="GroupHierarchyV1" /> class.
        /// </summary>
        /// <param name="limitEnforcement">
        /// Default Value: INDEPENDENT
        /// </param>
        /// <param name="parentGroupId">
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroupHierarchyV1(
            global::Baseten.LimitEnforcementV1? limitEnforcement,
            string? parentGroupId)
        {
            this.LimitEnforcement = limitEnforcement;
            this.ParentGroupId = parentGroupId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupHierarchyV1" /> class.
        /// </summary>
        public GroupHierarchyV1()
        {
        }

    }
}