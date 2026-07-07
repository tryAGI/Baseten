
#nullable enable

namespace Baseten
{
    /// <summary>
    /// When set, returns only models with this exact name, if any. On a team-scoped route this matches at most one model; on the org-wide route it may match models in multiple teams, since names are unique only within a team.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class ModelsRequestV1Name
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}