
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to update a chain environment.
    /// </summary>
    public sealed partial class UpdateChainEnvironmentRequestV1
    {
        /// <summary>
        /// Promotion settings for the environment<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotion_settings")]
        public global::Baseten.UpdatePromotionSettingsV1? PromotionSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChainEnvironmentRequestV1" /> class.
        /// </summary>
        /// <param name="promotionSettings">
        /// Promotion settings for the environment<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateChainEnvironmentRequestV1(
            global::Baseten.UpdatePromotionSettingsV1? promotionSettings)
        {
            this.PromotionSettings = promotionSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChainEnvironmentRequestV1" /> class.
        /// </summary>
        public UpdateChainEnvironmentRequestV1()
        {
        }
    }
}