
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Number of requests per replica before scaling up. Null stores no schedule override and follows the current environment value.
    /// </summary>
    public sealed partial class AutoscalingScheduleSettingsRequestV1ConcurrencyTarget
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}