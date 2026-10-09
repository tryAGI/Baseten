
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteTeamSpendLimitSettingV1
    {
        /// <summary>
        /// Spend limit in USD for each UTC calendar month that applies to each member's Code spend in this team, unless the member has a limit of their own. Returned as an exact decimal string. Null when the team has no per-member limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_member_monthly_limit_usd")]
        public string? PerMemberMonthlyLimitUsd { get; set; }

        /// <summary>
        /// Spend limit in USD for each UTC calendar month on the Code spend of all members in this team together. Once it is reached, every member's requests in the team are rejected. Returned as an exact decimal string. Null when the team has no team-wide limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_wide_monthly_limit_usd")]
        public string? TeamWideMonthlyLimitUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteTeamSpendLimitSettingV1" /> class.
        /// </summary>
        /// <param name="perMemberMonthlyLimitUsd">
        /// Spend limit in USD for each UTC calendar month that applies to each member's Code spend in this team, unless the member has a limit of their own. Returned as an exact decimal string. Null when the team has no per-member limit.
        /// </param>
        /// <param name="teamWideMonthlyLimitUsd">
        /// Spend limit in USD for each UTC calendar month on the Code spend of all members in this team together. Once it is reached, every member's requests in the team are rejected. Returned as an exact decimal string. Null when the team has no team-wide limit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteTeamSpendLimitSettingV1(
            string? perMemberMonthlyLimitUsd,
            string? teamWideMonthlyLimitUsd)
        {
            this.PerMemberMonthlyLimitUsd = perMemberMonthlyLimitUsd;
            this.TeamWideMonthlyLimitUsd = teamWideMonthlyLimitUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteTeamSpendLimitSettingV1" /> class.
        /// </summary>
        public RouteTeamSpendLimitSettingV1()
        {
        }

    }
}