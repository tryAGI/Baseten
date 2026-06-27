
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Who is allowed to manage an environment group.
    /// </summary>
    public sealed partial class EnvironmentGroupManageAccessV1
    {
        /// <summary>
        /// Whether the environment is restricted to a specific set of users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_restricted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsRestricted { get; set; }

        /// <summary>
        /// Users who can manage the environment while it is restricted, including organization and team admins who always have access. Empty when the environment is unrestricted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::System.Collections.Generic.IList<global::Baseten.EnvironmentGroupUserV1>? Users { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentGroupManageAccessV1" /> class.
        /// </summary>
        /// <param name="isRestricted">
        /// Whether the environment is restricted to a specific set of users.
        /// </param>
        /// <param name="users">
        /// Users who can manage the environment while it is restricted, including organization and team admins who always have access. Empty when the environment is unrestricted.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentGroupManageAccessV1(
            bool isRestricted,
            global::System.Collections.Generic.IList<global::Baseten.EnvironmentGroupUserV1>? users)
        {
            this.IsRestricted = isRestricted;
            this.Users = users;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentGroupManageAccessV1" /> class.
        /// </summary>
        public EnvironmentGroupManageAccessV1()
        {
        }

    }
}