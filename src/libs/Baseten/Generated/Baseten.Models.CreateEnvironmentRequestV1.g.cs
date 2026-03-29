
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to create an environment.
    /// </summary>
    public sealed partial class CreateEnvironmentRequestV1
    {
        /// <summary>
        /// Name of the environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

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
        /// Initializes a new instance of the <see cref="CreateEnvironmentRequestV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the environment
        /// </param>
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
        public CreateEnvironmentRequestV1(
            string name,
            global::Baseten.UpdateAutoscalingSettingsV1? autoscalingSettings,
            global::Baseten.UpdatePromotionSettingsV1? promotionSettings)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.AutoscalingSettings = autoscalingSettings;
            this.PromotionSettings = promotionSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEnvironmentRequestV1" /> class.
        /// </summary>
        public CreateEnvironmentRequestV1()
        {
        }
    }
}