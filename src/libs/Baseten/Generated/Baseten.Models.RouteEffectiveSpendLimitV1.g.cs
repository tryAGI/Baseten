
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteEffectiveSpendLimitV1
    {
        /// <summary>
        /// Spend limit in USD enforced for the current UTC calendar month: the user's own limit, else the team default. Null when no limit applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_limit_usd")]
        public string? MonthlyLimitUsd { get; set; }

        /// <summary>
        /// Where the limit comes from: `user` when it is set on the user, `team` when it is the team default. Null when no limit applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public global::Baseten.RouteSettingSourceV1? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteEffectiveSpendLimitV1" /> class.
        /// </summary>
        /// <param name="monthlyLimitUsd">
        /// Spend limit in USD enforced for the current UTC calendar month: the user's own limit, else the team default. Null when no limit applies.
        /// </param>
        /// <param name="source">
        /// Where the limit comes from: `user` when it is set on the user, `team` when it is the team default. Null when no limit applies.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteEffectiveSpendLimitV1(
            string? monthlyLimitUsd,
            global::Baseten.RouteSettingSourceV1? source)
        {
            this.MonthlyLimitUsd = monthlyLimitUsd;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteEffectiveSpendLimitV1" /> class.
        /// </summary>
        public RouteEffectiveSpendLimitV1()
        {
        }

    }
}