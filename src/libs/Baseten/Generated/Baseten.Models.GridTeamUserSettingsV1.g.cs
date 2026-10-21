
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GridTeamUserSettingsV1
    {
        /// <summary>
        /// ID of the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// Name of the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamName { get; set; }

        /// <summary>
        /// ID of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string UserId { get; set; }

        /// <summary>
        /// Email address of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// Spend limit for Baseten Grid in the team. Applies to requests with Routes keys the user created in the team; personal API keys are not limited.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.GridSpendLimitSettingV1 SpendLimit { get; set; }

        /// <summary>
        /// The user's metered Grid spend in USD in the team this UTC calendar month, returned as an exact decimal string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("month_spend_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string MonthSpendUsd { get; set; }

        /// <summary>
        /// Whether the user's spend this month reached their limit, or the team's spend reached its team-wide limit, so requests with Routes keys they created in the team are rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_blocked")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsBlocked { get; set; }

        /// <summary>
        /// `member` when the user's spend this month reached their limit, `team` when the team's spend reached its team-wide limit. Null when the user is not blocked.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("blocked_by")]
        public global::Baseten.GridSpendBlockedByV1? BlockedBy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GridTeamUserSettingsV1" /> class.
        /// </summary>
        /// <param name="teamId">
        /// ID of the team.
        /// </param>
        /// <param name="teamName">
        /// Name of the team.
        /// </param>
        /// <param name="userId">
        /// ID of the user.
        /// </param>
        /// <param name="spendLimit">
        /// Spend limit for Baseten Grid in the team. Applies to requests with Routes keys the user created in the team; personal API keys are not limited.
        /// </param>
        /// <param name="monthSpendUsd">
        /// The user's metered Grid spend in USD in the team this UTC calendar month, returned as an exact decimal string.
        /// </param>
        /// <param name="isBlocked">
        /// Whether the user's spend this month reached their limit, or the team's spend reached its team-wide limit, so requests with Routes keys they created in the team are rejected.
        /// </param>
        /// <param name="email">
        /// Email address of the user.
        /// </param>
        /// <param name="blockedBy">
        /// `member` when the user's spend this month reached their limit, `team` when the team's spend reached its team-wide limit. Null when the user is not blocked.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GridTeamUserSettingsV1(
            string teamId,
            string teamName,
            string userId,
            global::Baseten.GridSpendLimitSettingV1 spendLimit,
            string monthSpendUsd,
            bool isBlocked,
            string? email,
            global::Baseten.GridSpendBlockedByV1? blockedBy)
        {
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.TeamName = teamName ?? throw new global::System.ArgumentNullException(nameof(teamName));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Email = email;
            this.SpendLimit = spendLimit ?? throw new global::System.ArgumentNullException(nameof(spendLimit));
            this.MonthSpendUsd = monthSpendUsd ?? throw new global::System.ArgumentNullException(nameof(monthSpendUsd));
            this.IsBlocked = isBlocked;
            this.BlockedBy = blockedBy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GridTeamUserSettingsV1" /> class.
        /// </summary>
        public GridTeamUserSettingsV1()
        {
        }

    }
}