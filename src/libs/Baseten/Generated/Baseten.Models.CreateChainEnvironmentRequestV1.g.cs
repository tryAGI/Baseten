
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A request to create a custom environment for a chain.
    /// </summary>
    public sealed partial class CreateChainEnvironmentRequestV1
    {
        /// <summary>
        /// Name of the environment
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Promotion settings for the environment<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("promotion_settings")]
        public global::Baseten.UpdatePromotionSettingsV1? PromotionSettings { get; set; }

        /// <summary>
        /// Mapping of chainlet name to the desired chainlet environment settings<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("chainlet_settings")]
        public global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentSettingsRequestV1>? ChainletSettings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChainEnvironmentRequestV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the environment
        /// </param>
        /// <param name="promotionSettings">
        /// Promotion settings for the environment<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="chainletSettings">
        /// Mapping of chainlet name to the desired chainlet environment settings<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateChainEnvironmentRequestV1(
            string name,
            global::Baseten.UpdatePromotionSettingsV1? promotionSettings,
            global::System.Collections.Generic.IList<global::Baseten.ChainletEnvironmentSettingsRequestV1>? chainletSettings)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.PromotionSettings = promotionSettings;
            this.ChainletSettings = chainletSettings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChainEnvironmentRequestV1" /> class.
        /// </summary>
        public CreateChainEnvironmentRequestV1()
        {
        }
    }
}