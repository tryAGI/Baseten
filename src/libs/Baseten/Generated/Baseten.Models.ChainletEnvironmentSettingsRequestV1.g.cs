
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Request to create environment settings for a chainlet.
    /// </summary>
    public sealed partial class ChainletEnvironmentSettingsRequestV1
    {
        /// <summary>
        /// Name of the chainlet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chainlet_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChainletName { get; set; }

        /// <summary>
        /// Autoscaling settings for the chainlet<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling_settings")]
        public global::Baseten.UpdateAutoscalingSettingsV1? AutoscalingSettings { get; set; }

        /// <summary>
        /// ID of the instance type to use for the chainlet<br/>
        /// Default Value: 1x2
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_type_id")]
        public string? InstanceTypeId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainletEnvironmentSettingsRequestV1" /> class.
        /// </summary>
        /// <param name="chainletName">
        /// Name of the chainlet
        /// </param>
        /// <param name="autoscalingSettings">
        /// Autoscaling settings for the chainlet<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="instanceTypeId">
        /// ID of the instance type to use for the chainlet<br/>
        /// Default Value: 1x2
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChainletEnvironmentSettingsRequestV1(
            string chainletName,
            global::Baseten.UpdateAutoscalingSettingsV1? autoscalingSettings,
            string? instanceTypeId)
        {
            this.ChainletName = chainletName ?? throw new global::System.ArgumentNullException(nameof(chainletName));
            this.AutoscalingSettings = autoscalingSettings;
            this.InstanceTypeId = instanceTypeId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainletEnvironmentSettingsRequestV1" /> class.
        /// </summary>
        public ChainletEnvironmentSettingsRequestV1()
        {
        }
    }
}