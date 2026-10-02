
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RouteUserSettingsV1
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
        /// Spend limit for Baseten Code. Applies to requests with Routes keys the user created; personal API keys are not limited.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend_limit")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.RouteSpendLimitSettingV1 SpendLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteUserSettingsV1" /> class.
        /// </summary>
        /// <param name="userId">
        /// ID of the user.
        /// </param>
        /// <param name="spendLimit">
        /// Spend limit for Baseten Code. Applies to requests with Routes keys the user created; personal API keys are not limited.
        /// </param>
        /// <param name="email">
        /// Email address of the user.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RouteUserSettingsV1(
            string userId,
            global::Baseten.RouteSpendLimitSettingV1 spendLimit,
            string? email)
        {
            this.UserId = userId ?? throw new global::System.ArgumentNullException(nameof(userId));
            this.Email = email;
            this.SpendLimit = spendLimit ?? throw new global::System.ArgumentNullException(nameof(spendLimit));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RouteUserSettingsV1" /> class.
        /// </summary>
        public RouteUserSettingsV1()
        {
        }

    }
}