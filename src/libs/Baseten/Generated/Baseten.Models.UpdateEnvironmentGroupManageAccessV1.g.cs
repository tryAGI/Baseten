
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Manage-access settings to apply to an environment group.
    /// </summary>
    public sealed partial class UpdateEnvironmentGroupManageAccessV1
    {
        /// <summary>
        /// Whether to restrict this environment to a specific set of users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_restricted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsRestricted { get; set; }

        /// <summary>
        /// IDs of users granted manage access while restricted. Only meaningful when is_restricted is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_ids")]
        public global::System.Collections.Generic.IList<string>? UserIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEnvironmentGroupManageAccessV1" /> class.
        /// </summary>
        /// <param name="isRestricted">
        /// Whether to restrict this environment to a specific set of users.
        /// </param>
        /// <param name="userIds">
        /// IDs of users granted manage access while restricted. Only meaningful when is_restricted is true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateEnvironmentGroupManageAccessV1(
            bool isRestricted,
            global::System.Collections.Generic.IList<string>? userIds)
        {
            this.IsRestricted = isRestricted;
            this.UserIds = userIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEnvironmentGroupManageAccessV1" /> class.
        /// </summary>
        public UpdateEnvironmentGroupManageAccessV1()
        {
        }

    }
}