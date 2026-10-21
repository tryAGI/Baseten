
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateGridUserSettingsRequestV1
    {
        /// <summary>
        /// Spend limit fields to change. Pass null to remove the user's limit; omit to leave it unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("spend_limit")]
        public global::Baseten.UpdateGridSpendLimitSettingV1? SpendLimit { get; set; }

        /// <summary>
        /// ID of the team. When omitted, the team you belong to; required when you belong to several.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("team_id")]
        public string? TeamId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGridUserSettingsRequestV1" /> class.
        /// </summary>
        /// <param name="spendLimit">
        /// Spend limit fields to change. Pass null to remove the user's limit; omit to leave it unchanged.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="teamId">
        /// ID of the team. When omitted, the team you belong to; required when you belong to several.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateGridUserSettingsRequestV1(
            global::Baseten.UpdateGridSpendLimitSettingV1? spendLimit,
            string? teamId)
        {
            this.SpendLimit = spendLimit;
            this.TeamId = teamId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGridUserSettingsRequestV1" /> class.
        /// </summary>
        public UpdateGridUserSettingsRequestV1()
        {
        }

    }
}