
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteTeamSettingsV1
    {
        /// <summary>
        /// ID of the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// Route for each model role of each coding harness. A role with no route set by a team admin uses the default chosen from the team's Model API routes: the recommended model for `primary` and the lowest-priced model for `background`. These defaults never use external-provider routes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harness_defaults")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.RouteHarnessDefaultsV1 HarnessDefaults { get; set; }

        /// <summary>
        /// Spend limits for Baseten Code for members whose active Code key belongs to this team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.RouteTeamSpendLimitSettingV1 SpendLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteTeamSettingsV1" /> class.
        /// </summary>
        /// <param name="teamId">
        /// ID of the team.
        /// </param>
        /// <param name="harnessDefaults">
        /// Route for each model role of each coding harness. A role with no route set by a team admin uses the default chosen from the team's Model API routes: the recommended model for `primary` and the lowest-priced model for `background`. These defaults never use external-provider routes.
        /// </param>
        /// <param name="spendLimit">
        /// Spend limits for Baseten Code for members whose active Code key belongs to this team.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteTeamSettingsV1(
            string teamId,
            global::Baseten.RouteHarnessDefaultsV1 harnessDefaults,
            global::Baseten.RouteTeamSpendLimitSettingV1 spendLimit)
        {
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.HarnessDefaults = harnessDefaults ?? throw new global::System.ArgumentNullException(nameof(harnessDefaults));
            this.SpendLimit = spendLimit ?? throw new global::System.ArgumentNullException(nameof(spendLimit));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteTeamSettingsV1" /> class.
        /// </summary>
        public RouteTeamSettingsV1()
        {
        }

    }
}