
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateRouteTeamSpendLimitSettingV1
    {
        /// <summary>
        /// Spend limit in USD for each UTC calendar month that applies to each member's Code spend in this team, unless the member has a limit of their own. Send null to remove it; omit to leave it unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_member_monthly_limit_usd")]
        public string? PerMemberMonthlyLimitUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRouteTeamSpendLimitSettingV1" /> class.
        /// </summary>
        /// <param name="perMemberMonthlyLimitUsd">
        /// Spend limit in USD for each UTC calendar month that applies to each member's Code spend in this team, unless the member has a limit of their own. Send null to remove it; omit to leave it unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRouteTeamSpendLimitSettingV1(
            string? perMemberMonthlyLimitUsd)
        {
            this.PerMemberMonthlyLimitUsd = perMemberMonthlyLimitUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRouteTeamSpendLimitSettingV1" /> class.
        /// </summary>
        public UpdateRouteTeamSpendLimitSettingV1()
        {
        }

    }
}