
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Maximum percentage of replicas that can be removed per autoscaling window. Null stores no schedule override and follows the current environment value.
    /// </summary>
    public sealed partial class AutoscalingScheduleSettingsRequestV1MaxScaleDownRate
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}