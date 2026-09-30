
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteSpendLimitV1
    {
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
        /// Standing spend limit in USD for each UTC calendar month, returned as an exact decimal string. Null when the user has no standing limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("monthly_limit_usd")]
        public string? MonthlyLimitUsd { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteSpendLimitV1" /> class.
        /// </summary>
        /// <param name="userId">
        /// ID of the user.
        /// </param>
        /// <param name="email">
        /// Email address of the user.
        /// </param>
        /// <param name="monthlyLimitUsd">
        /// Standing spend limit in USD for each UTC calendar month, returned as an exact decimal string. Null when the user has no standing limit.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteSpendLimitV1(
            string userId,
            string? email,
            string? monthlyLimitUsd)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Email = email;
            this.MonthlyLimitUsd = monthlyLimitUsd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteSpendLimitV1" /> class.
        /// </summary>
        public RouteSpendLimitV1()
        {
        }

    }
}