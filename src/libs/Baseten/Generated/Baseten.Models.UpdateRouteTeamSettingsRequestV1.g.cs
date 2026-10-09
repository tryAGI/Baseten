
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateRouteTeamSettingsRequestV1
    {
        /// <summary>
        /// Harnesses to change; harnesses left out are unchanged. Pass null to clear every harness, so each role uses the team's default.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("harness_defaults")]
        public global::Baseten.UpdateRouteHarnessDefaultsV1? HarnessDefaults { get; set; }

        /// <summary>
        /// Spend limit fields to change. Pass null to remove the team's limits; omit to leave them unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend_limit")]
        public global::Baseten.UpdateRouteTeamSpendLimitSettingV1? SpendLimit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRouteTeamSettingsRequestV1" /> class.
        /// </summary>
        /// <param name="harnessDefaults">
        /// Harnesses to change; harnesses left out are unchanged. Pass null to clear every harness, so each role uses the team's default.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="spendLimit">
        /// Spend limit fields to change. Pass null to remove the team's limits; omit to leave them unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRouteTeamSettingsRequestV1(
            global::Baseten.UpdateRouteHarnessDefaultsV1? harnessDefaults,
            global::Baseten.UpdateRouteTeamSpendLimitSettingV1? spendLimit)
        {
            this.HarnessDefaults = harnessDefaults;
            this.SpendLimit = spendLimit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRouteTeamSettingsRequestV1" /> class.
        /// </summary>
        public UpdateRouteTeamSettingsRequestV1()
        {
        }

    }
}