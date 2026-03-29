
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to update an environment.
    /// </summary>
    public sealed partial class UpdateEnvironmentRequestV1
    {
        /// <summary>
        /// Autoscaling settings for the environment<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling_settings")]
        public global::Baseten.UpdateAutoscalingSettingsV1? AutoscalingSettings { get; set; }

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
        /// Initializes a new instance of the <see cref="UpdateEnvironmentRequestV1" /> class.
        /// </summary>
        /// <param name="autoscalingSettings">
        /// Autoscaling settings for the environment<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="promotionSettings">
        /// Promotion settings for the environment<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateEnvironmentRequestV1(
            global::Baseten.UpdateAutoscalingSettingsV1? autoscalingSettings,
            global::Baseten.UpdatePromotionSettingsV1? promotionSettings)
        {
            this.AutoscalingSettings = autoscalingSettings;
            this.PromotionSettings = promotionSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateEnvironmentRequestV1" /> class.
        /// </summary>
        public UpdateEnvironmentRequestV1()
        {
        }
    }
}