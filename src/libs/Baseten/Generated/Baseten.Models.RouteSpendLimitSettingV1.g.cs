
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteSpendLimitSettingV1
    {
        /// <summary>
        /// Standing spend limit in USD for each UTC calendar month, returned as an exact decimal string. Null when no limit applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_limit_usd")]
        public string? MonthlyLimitUsd { get; set; }

        /// <summary>
        /// Where the limit comes from: `user` when it is set on the user. Null when no limit applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public global::Baseten.RouteSettingSourceV1? Source { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteSpendLimitSettingV1" /> class.
        /// </summary>
        /// <param name="monthlyLimitUsd">
        /// Standing spend limit in USD for each UTC calendar month, returned as an exact decimal string. Null when no limit applies.
        /// </param>
        /// <param name="source">
        /// Where the limit comes from: `user` when it is set on the user. Null when no limit applies.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteSpendLimitSettingV1(
            string? monthlyLimitUsd,
            global::Baseten.RouteSettingSourceV1? source)
        {
            this.MonthlyLimitUsd = monthlyLimitUsd;
            this.Source = source;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteSpendLimitSettingV1" /> class.
        /// </summary>
        public RouteSpendLimitSettingV1()
        {
        }

    }
}