
#nullable enable

namespace Baseten
{
    /// <summary>
    /// For on_startup sessions, minutes to add to the expiration. For on_demand/on_failure sessions, minutes to add to the timeout. Use -1 for infinite timeout (bumps by 10 years).<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class PatchInteractiveSessionRequestV1TimeoutMinutes
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}