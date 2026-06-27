
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A team-scoped grouping of same-named environments (e.g. "production", "staging").<br/>
    /// Restricting an environment group limits who can manage the environment of that name<br/>
    /// across every model and chain in the team.
    /// </summary>
    public sealed partial class EnvironmentGroupV1
    {
        /// <summary>
        /// Name of the environment group, matching the environment name it governs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Unique identifier of the team the environment group belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// Name of the team the environment group belongs to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamName { get; set; }

        /// <summary>
        /// Settings controlling who can manage this environment group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("manage_access")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.EnvironmentGroupManageAccessV1 ManageAccess { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentGroupV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the environment group, matching the environment name it governs.
        /// </param>
        /// <param name="teamId">
        /// Unique identifier of the team the environment group belongs to.
        /// </param>
        /// <param name="teamName">
        /// Name of the team the environment group belongs to.
        /// </param>
        /// <param name="manageAccess">
        /// Settings controlling who can manage this environment group.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentGroupV1(
            string name,
            string teamId,
            string teamName,
            global::Baseten.EnvironmentGroupManageAccessV1 manageAccess)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.TeamName = teamName ?? throw new global::System.ArgumentNullException(nameof(teamName));
            this.ManageAccess = manageAccess ?? throw new global::System.ArgumentNullException(nameof(manageAccess));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentGroupV1" /> class.
        /// </summary>
        public EnvironmentGroupV1()
        {
        }

    }
}