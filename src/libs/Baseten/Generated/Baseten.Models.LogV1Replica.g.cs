
#nullable enable

namespace Baseten
{
    /// <summary>
    /// The replica the log line was emitted from.
    /// </summary>
    public sealed partial class LogV1Replica
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}