
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The request to update the autoscaling settings for a chainlet.
    /// </summary>
    public sealed partial class ChainletEnvironmentAutoscalingSettingsUpdateV1
    {
        /// <summary>
        /// Name of the chainlet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chainlet_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ChainletName { get; set; }

        /// <summary>
        /// Autoscaling settings for the chainlet
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("autoscaling_settings")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.UpdateAutoscalingSettingsV1 AutoscalingSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainletEnvironmentAutoscalingSettingsUpdateV1" /> class.
        /// </summary>
        /// <param name="chainletName">
        /// Name of the chainlet
        /// </param>
        /// <param name="autoscalingSettings">
        /// Autoscaling settings for the chainlet
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChainletEnvironmentAutoscalingSettingsUpdateV1(
            string chainletName,
            global::Baseten.UpdateAutoscalingSettingsV1 autoscalingSettings)
        {
            this.ChainletName = chainletName ?? throw new global::System.ArgumentNullException(nameof(chainletName));
            this.AutoscalingSettings = autoscalingSettings ?? throw new global::System.ArgumentNullException(nameof(autoscalingSettings));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChainletEnvironmentAutoscalingSettingsUpdateV1" /> class.
        /// </summary>
        public ChainletEnvironmentAutoscalingSettingsUpdateV1()
        {
        }
    }
}