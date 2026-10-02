
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateRouteUserSettingsRequestV1
    {
        /// <summary>
        /// Spend limit fields to change. Pass null to remove the user's limit; omit to leave it unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend_limit")]
        public global::Baseten.UpdateRouteSpendLimitSettingV1? SpendLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRouteUserSettingsRequestV1" /> class.
        /// </summary>
        /// <param name="spendLimit">
        /// Spend limit fields to change. Pass null to remove the user's limit; omit to leave it unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRouteUserSettingsRequestV1(
            global::Baseten.UpdateRouteSpendLimitSettingV1? spendLimit)
        {
            this.SpendLimit = spendLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRouteUserSettingsRequestV1" /> class.
        /// </summary>
        public UpdateRouteUserSettingsRequestV1()
        {
        }

    }
}