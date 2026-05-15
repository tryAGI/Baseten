
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response for ``POST /v1/loops/checkpoints/validate``. Empty on success;<br/>
    /// inaccessible or malformed paths raise 400.
    /// </summary>
    public sealed partial class ValidateLoopsCheckpointResponseV1
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}