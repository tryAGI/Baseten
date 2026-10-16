
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteUserTeamSettingsListV1
    {
        /// <summary>
        /// The user's settings in each team they have a role in and in any team they have Grid spend in this month, alphabetical by team name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("teams")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.RouteTeamUserSettingsV1> Teams { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteUserTeamSettingsListV1" /> class.
        /// </summary>
        /// <param name="teams">
        /// The user's settings in each team they have a role in and in any team they have Grid spend in this month, alphabetical by team name.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteUserTeamSettingsListV1(
            global::System.Collections.Generic.IList<global::Baseten.RouteTeamUserSettingsV1> teams)
        {
            this.Teams = teams ?? throw new global::System.ArgumentNullException(nameof(teams));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteUserTeamSettingsListV1" /> class.
        /// </summary>
        public RouteUserTeamSettingsListV1()
        {
        }

    }
}