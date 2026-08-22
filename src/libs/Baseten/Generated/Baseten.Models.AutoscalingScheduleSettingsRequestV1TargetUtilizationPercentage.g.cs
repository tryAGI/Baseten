
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Target utilization percentage for scaling up/down. Null stores no schedule override and follows the current environment value.
    /// </summary>
    public sealed partial class AutoscalingScheduleSettingsRequestV1TargetUtilizationPercentage
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}