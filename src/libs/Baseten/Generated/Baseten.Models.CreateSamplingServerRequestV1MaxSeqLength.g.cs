
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Minimum max-sequence-length the sampler must support. If set, only instance-type entries whose configured max_seq_length is &gt;= this value are considered. Omit to accept any entry.<br/>
    /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
    /// </summary>
    public sealed partial class CreateSamplingServerRequestV1MaxSeqLength
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}