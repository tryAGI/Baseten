
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateSamplingServerRequestV1
    {
        /// <summary>
        /// Model to use for standalone samplers (eg, for baselines).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Minimum max-sequence-length the sampler must support. If set, only instance-type entries whose configured max_seq_length is &gt;= this value are considered. Omit to accept any entry.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_seq_length")]
        public int? MaxSeqLength { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSamplingServerRequestV1" /> class.
        /// </summary>
        /// <param name="model">
        /// Model to use for standalone samplers (eg, for baselines).
        /// </param>
        /// <param name="maxSeqLength">
        /// Minimum max-sequence-length the sampler must support. If set, only instance-type entries whose configured max_seq_length is &gt;= this value are considered. Omit to accept any entry.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateSamplingServerRequestV1(
            string model,
            int? maxSeqLength)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.MaxSeqLength = maxSeqLength;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSamplingServerRequestV1" /> class.
        /// </summary>
        public CreateSamplingServerRequestV1()
        {
        }
    }
}