
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Changes to an environment's settings, applied to a promoted deployment.
    /// </summary>
    public sealed partial class PromotionEnvironmentSettingsUpdateV1
    {
        /// <summary>
        /// Region for the promoted deployment, from `GET /v1/teams/{team_id}/regions`. Use an empty string for Global.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Instance type for the promoted deployment, from `GET /v1/instance_types`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_type_id")]
        public string? InstanceTypeId { get; set; }

        /// <summary>
        /// Autoscaling settings for the promoted deployment.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling_settings")]
        public global::Baseten.UpdateAutoscalingSettingsV1? AutoscalingSettings { get; set; }

        /// <summary>
        /// Request backpressure settings for the promoted deployment.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("request_backpressure_settings")]
        public global::Baseten.UpdateRequestBackpressureSettingsV1? RequestBackpressureSettings { get; set; }

        /// <summary>
        /// Autoscaling schedule changes for the environment, applied when the promotion completes.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling_schedule_settings")]
        public global::Baseten.UpdateAutoscalingScheduleSettingsV1? AutoscalingScheduleSettings { get; set; }

        /// <summary>
        /// Promotion settings for the environment, also used for this promotion.<br/>
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
        /// Initializes a new instance of the <see cref="PromotionEnvironmentSettingsUpdateV1" /> class.
        /// </summary>
        /// <param name="region">
        /// Region for the promoted deployment, from `GET /v1/teams/{team_id}/regions`. Use an empty string for Global.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="instanceTypeId">
        /// Instance type for the promoted deployment, from `GET /v1/instance_types`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="autoscalingSettings">
        /// Autoscaling settings for the promoted deployment.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="requestBackpressureSettings">
        /// Request backpressure settings for the promoted deployment.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="autoscalingScheduleSettings">
        /// Autoscaling schedule changes for the environment, applied when the promotion completes.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="promotionSettings">
        /// Promotion settings for the environment, also used for this promotion.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PromotionEnvironmentSettingsUpdateV1(
            string? region,
            string? instanceTypeId,
            global::Baseten.UpdateAutoscalingSettingsV1? autoscalingSettings,
            global::Baseten.UpdateRequestBackpressureSettingsV1? requestBackpressureSettings,
            global::Baseten.UpdateAutoscalingScheduleSettingsV1? autoscalingScheduleSettings,
            global::Baseten.UpdatePromotionSettingsV1? promotionSettings)
        {
            this.Region = region;
            this.InstanceTypeId = instanceTypeId;
            this.AutoscalingSettings = autoscalingSettings;
            this.RequestBackpressureSettings = requestBackpressureSettings;
            this.AutoscalingScheduleSettings = autoscalingScheduleSettings;
            this.PromotionSettings = promotionSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PromotionEnvironmentSettingsUpdateV1" /> class.
        /// </summary>
        public PromotionEnvironmentSettingsUpdateV1()
        {
        }

    }
}