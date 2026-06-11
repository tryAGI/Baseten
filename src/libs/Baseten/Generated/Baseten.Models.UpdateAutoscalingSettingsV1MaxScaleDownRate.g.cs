
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Maximum percentage of replicas that can be removed per autoscaling window (1–50). E.g. 20 means at most 20% of replicas are removed per window.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class UpdateAutoscalingSettingsV1MaxScaleDownRate
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}