
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Whether to deploy on all promotions. Enabling this flag allows model code to safely handle environment-specific logic. When a deployment is promoted, a new deployment will be created with a copy of the image.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class UpdatePromotionSettingsV1RedeployOnPromotion
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}