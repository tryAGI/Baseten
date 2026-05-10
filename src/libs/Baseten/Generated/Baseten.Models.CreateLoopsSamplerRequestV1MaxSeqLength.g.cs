
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Maximum prompt length (in tokens) the sampler must handle. Set this to the longest prompt you plan to send. Omit to use the default for the base model.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class CreateLoopsSamplerRequestV1MaxSeqLength
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}