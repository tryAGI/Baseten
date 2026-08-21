
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Waiting period before scaling down any active replica. Null inherits the environment value.
    /// </summary>
    public sealed partial class AutoscalingScheduleSettingsV1ScaleDownDelay
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}