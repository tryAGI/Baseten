
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Environment settings for a chainlet.
    /// </summary>
    public sealed partial class ChainletEnvironmentSettingsV1
    {
        /// <summary>
        /// Name of the chainlet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chainlet_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChainletName { get; set; }

        /// <summary>
        /// Autoscaling settings for the chainlet. If null, it has not finished deploying
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling_settings")]
        public global::Baseten.AutoscalingSettingsV1? AutoscalingSettings { get; set; }

        /// <summary>
        /// Instance type for the chainlet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instance_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.InstanceTypeV1 InstanceType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainletEnvironmentSettingsV1" /> class.
        /// </summary>
        /// <param name="chainletName">
        /// Name of the chainlet
        /// </param>
        /// <param name="instanceType">
        /// Instance type for the chainlet
        /// </param>
        /// <param name="autoscalingSettings">
        /// Autoscaling settings for the chainlet. If null, it has not finished deploying
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChainletEnvironmentSettingsV1(
            string chainletName,
            global::Baseten.InstanceTypeV1 instanceType,
            global::Baseten.AutoscalingSettingsV1? autoscalingSettings)
        {
            this.ChainletName = chainletName ?? throw new global::System.ArgumentNullException(nameof(chainletName));
            this.AutoscalingSettings = autoscalingSettings;
            this.InstanceType = instanceType ?? throw new global::System.ArgumentNullException(nameof(instanceType));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainletEnvironmentSettingsV1" /> class.
        /// </summary>
        public ChainletEnvironmentSettingsV1()
        {
        }
    }
}