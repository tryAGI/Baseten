
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteTeamSpendLimitSettingV1
    {
        /// <summary>
        /// Spend limit in USD for each UTC calendar month that applies to each member whose active Code key belongs to this team, unless the member has a limit of their own. Returned as an exact decimal string. Null when the team has no per-member limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_member_monthly_limit_usd")]
        public string? PerMemberMonthlyLimitUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteTeamSpendLimitSettingV1" /> class.
        /// </summary>
        /// <param name="perMemberMonthlyLimitUsd">
        /// Spend limit in USD for each UTC calendar month that applies to each member whose active Code key belongs to this team, unless the member has a limit of their own. Returned as an exact decimal string. Null when the team has no per-member limit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteTeamSpendLimitSettingV1(
            string? perMemberMonthlyLimitUsd)
        {
            this.PerMemberMonthlyLimitUsd = perMemberMonthlyLimitUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteTeamSpendLimitSettingV1" /> class.
        /// </summary>
        public RouteTeamSpendLimitSettingV1()
        {
        }

    }
}