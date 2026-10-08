
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteSpendLimitTeamDefaultV1
    {
        /// <summary>
        /// ID of the team whose per-member limit this is.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TeamId { get; set; }

        /// <summary>
        /// The team's per-member spend limit in USD for each UTC calendar month.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_member_monthly_limit_usd")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PerMemberMonthlyLimitUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteSpendLimitTeamDefaultV1" /> class.
        /// </summary>
        /// <param name="teamId">
        /// ID of the team whose per-member limit this is.
        /// </param>
        /// <param name="perMemberMonthlyLimitUsd">
        /// The team's per-member spend limit in USD for each UTC calendar month.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteSpendLimitTeamDefaultV1(
            string teamId,
            string perMemberMonthlyLimitUsd)
        {
            this.TeamId = teamId ?? throw new global::System.ArgumentNullException(nameof(teamId));
            this.PerMemberMonthlyLimitUsd = perMemberMonthlyLimitUsd ?? throw new global::System.ArgumentNullException(nameof(perMemberMonthlyLimitUsd));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteSpendLimitTeamDefaultV1" /> class.
        /// </summary>
        public RouteSpendLimitTeamDefaultV1()
        {
        }

    }
}