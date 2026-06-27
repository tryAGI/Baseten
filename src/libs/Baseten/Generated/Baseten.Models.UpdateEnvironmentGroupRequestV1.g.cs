
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to update an existing environment group.
    /// </summary>
    public sealed partial class UpdateEnvironmentGroupRequestV1
    {
        /// <summary>
        /// Manage-access settings to apply. Omit to leave manage access unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manage_access")]
        public global::Baseten.UpdateEnvironmentGroupManageAccessV1? ManageAccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEnvironmentGroupRequestV1" /> class.
        /// </summary>
        /// <param name="manageAccess">
        /// Manage-access settings to apply. Omit to leave manage access unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateEnvironmentGroupRequestV1(
            global::Baseten.UpdateEnvironmentGroupManageAccessV1? manageAccess)
        {
            this.ManageAccess = manageAccess;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEnvironmentGroupRequestV1" /> class.
        /// </summary>
        public UpdateEnvironmentGroupRequestV1()
        {
        }

    }
}