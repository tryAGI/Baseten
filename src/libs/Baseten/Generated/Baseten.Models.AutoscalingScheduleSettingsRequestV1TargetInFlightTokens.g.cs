
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Target number of in-flight tokens for autoscaling decisions. Null stores no schedule override and follows the current environment value. Early access only.
    /// </summary>
    public sealed partial class AutoscalingScheduleSettingsRequestV1TargetInFlightTokens
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}