
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteTeamUserSettingsV1
    {
        /// <summary>
        /// ID of the team.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

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
        /// Spend limit for Baseten Code in the team. Applies to requests with Routes keys the user created in the team; personal API keys are not limited.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.RouteSpendLimitSettingV1 SpendLimit { get; set; }

        /// <summary>
        /// The user's metered Code spend in USD in the team this UTC calendar month, returned as an exact decimal string.
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
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteTeamUserSettingsV1" /> class.
        /// </summary>
        /// <param name="teamId">
        /// ID of the team.
        /// </param>
        /// <param name="userId">
        /// ID of the user.
        /// </param>
        /// <param name="spendLimit">
        /// Spend limit for Baseten Code in the team. Applies to requests with Routes keys the user created in the team; personal API keys are not limited.
        /// </param>
        /// <param name="monthSpendUsd">
        /// The user's metered Code spend in USD in the team this UTC calendar month, returned as an exact decimal string.
        /// </param>
        /// <param name="isBlocked">
        /// Whether the user's spend this month reached their limit, or the team's spend reached its team-wide limit, so requests with Routes keys they created in the team are rejected.
        /// </param>
        /// <param name="email">
        /// Email address of the user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteTeamUserSettingsV1(
            string teamId,
            string userId,
            global::Baseten.RouteSpendLimitSettingV1 spendLimit,
            string monthSpendUsd,
            bool isBlocked,
            string? email)
        {
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Email = email;
            this.SpendLimit = spendLimit ?? throw new global::System.ArgumentNullException(nameof(spendLimit));
            this.MonthSpendUsd = monthSpendUsd ?? throw new global::System.ArgumentNullException(nameof(monthSpendUsd));
            this.IsBlocked = isBlocked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteTeamUserSettingsV1" /> class.
        /// </summary>
        public RouteTeamUserSettingsV1()
        {
        }

    }
}