
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateRouteSpendLimitSettingV1
    {
        /// <summary>
        /// Standing spend limit in USD for each UTC calendar month. Send null to remove the limit; omit to leave it unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_monthly_limit_usd")]
        public string? UserMonthlyLimitUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRouteSpendLimitSettingV1" /> class.
        /// </summary>
        /// <param name="userMonthlyLimitUsd">
        /// Standing spend limit in USD for each UTC calendar month. Send null to remove the limit; omit to leave it unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRouteSpendLimitSettingV1(
            string? userMonthlyLimitUsd)
        {
            this.UserMonthlyLimitUsd = userMonthlyLimitUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRouteSpendLimitSettingV1" /> class.
        /// </summary>
        public UpdateRouteSpendLimitSettingV1()
        {
        }

    }
}