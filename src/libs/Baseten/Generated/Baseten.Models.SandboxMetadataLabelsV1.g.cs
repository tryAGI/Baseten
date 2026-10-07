
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Key-value pairs for organizing and filtering resources. Labels can be used to categorize resources by environment, project, team, or any custom taxonomy.<br/>
    /// Example: {"env":"development","project":"api-review","team":"engineering"}
    /// </summary>
    public sealed partial class SandboxMetadataLabelsV1
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}