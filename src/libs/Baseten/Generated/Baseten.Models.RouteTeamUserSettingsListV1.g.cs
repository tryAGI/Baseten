
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteTeamUserSettingsListV1
    {
        /// <summary>
        /// Settings of each user with a role in the team and of anyone with Code spend in the team this month.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.RouteTeamUserSettingsV1> Users { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteTeamUserSettingsListV1" /> class.
        /// </summary>
        /// <param name="users">
        /// Settings of each user with a role in the team and of anyone with Code spend in the team this month.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteTeamUserSettingsListV1(
            global::System.Collections.Generic.IList<global::Baseten.RouteTeamUserSettingsV1> users)
        {
            this.Users = users ?? throw new global::System.ArgumentNullException(nameof(users));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteTeamUserSettingsListV1" /> class.
        /// </summary>
        public RouteTeamUserSettingsListV1()
        {
        }

    }
}