
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteSpendLimitSettingV1
    {
        /// <summary>
        /// Standing spend limit in USD for each UTC calendar month set on the user in the team. Null when the user has no limit of their own there.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_monthly_limit_usd")]
        public string? UserMonthlyLimitUsd { get; set; }

        /// <summary>
        /// Spend limit in USD for the current UTC calendar month set on the user in the team, which supersedes their standing limit. Null when there is none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("month_override_usd")]
        public string? MonthOverrideUsd { get; set; }

        /// <summary>
        /// Per-member limit of the team. This limit applies when the user has no limit of their own. Null when there is none.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_default")]
        public global::Baseten.RouteSpendLimitTeamDefaultV1? TeamDefault { get; set; }

        /// <summary>
        /// The effective limit enforced for the current month.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("effective")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.RouteEffectiveSpendLimitV1 Effective { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteSpendLimitSettingV1" /> class.
        /// </summary>
        /// <param name="effective">
        /// The effective limit enforced for the current month.
        /// </param>
        /// <param name="userMonthlyLimitUsd">
        /// Standing spend limit in USD for each UTC calendar month set on the user in the team. Null when the user has no limit of their own there.
        /// </param>
        /// <param name="monthOverrideUsd">
        /// Spend limit in USD for the current UTC calendar month set on the user in the team, which supersedes their standing limit. Null when there is none.
        /// </param>
        /// <param name="teamDefault">
        /// Per-member limit of the team. This limit applies when the user has no limit of their own. Null when there is none.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteSpendLimitSettingV1(
            global::Baseten.RouteEffectiveSpendLimitV1 effective,
            string? userMonthlyLimitUsd,
            string? monthOverrideUsd,
            global::Baseten.RouteSpendLimitTeamDefaultV1? teamDefault)
        {
            this.UserMonthlyLimitUsd = userMonthlyLimitUsd;
            this.MonthOverrideUsd = monthOverrideUsd;
            this.TeamDefault = teamDefault;
            this.Effective = effective ?? throw new global::System.ArgumentNullException(nameof(effective));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteSpendLimitSettingV1" /> class.
        /// </summary>
        public RouteSpendLimitSettingV1()
        {
        }

    }
}