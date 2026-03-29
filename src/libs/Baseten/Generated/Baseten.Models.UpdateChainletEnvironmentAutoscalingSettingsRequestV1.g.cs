
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to update the autoscaling settings for a multiple chainlets in an environment.<br/>
    /// If a chainlet name doesn't exist, an error is returned.
    /// </summary>
    public sealed partial class UpdateChainletEnvironmentAutoscalingSettingsRequestV1
    {
        /// <summary>
        /// Mapping of chainlet name to the desired chainlet autoscaling settings. If the chainlet name doesn't exist, an error is returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updates")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentAutoscalingSettingsUpdateV1> Updates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChainletEnvironmentAutoscalingSettingsRequestV1" /> class.
        /// </summary>
        /// <param name="updates">
        /// Mapping of chainlet name to the desired chainlet autoscaling settings. If the chainlet name doesn't exist, an error is returned.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateChainletEnvironmentAutoscalingSettingsRequestV1(
            global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentAutoscalingSettingsUpdateV1> updates)
        {
            this.Updates = updates ?? throw new global::System.ArgumentNullException(nameof(updates));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateChainletEnvironmentAutoscalingSettingsRequestV1" /> class.
        /// </summary>
        public UpdateChainletEnvironmentAutoscalingSettingsRequestV1()
        {
        }
    }
}