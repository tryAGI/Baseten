
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Query-string filters for ``GET /v1/loops/capabilities``.
    /// </summary>
    public sealed partial class GetLoopsCapabilitiesQueryParamsV1
    {
        /// <summary>
        /// Restrict the response to one model, identified by its HuggingFace repo id. A supported model comes back with its 'enabled' flag and, when false, its 'enablement_details'. An empty list means Baseten does not support that model. Omit to list every supported model.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// What the caller intends to run. Defaults to 'rl', the stricter of the two: an RL run needs both a trainer and a sampler, so anything enabled for 'rl' is also enabled for 'sft'.<br/>
        /// Default Value: rl
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_case")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.LoopsUseCaseV1JsonConverter))]
        public global::Baseten.LoopsUseCaseV1? UseCase { get; set; }

        /// <summary>
        /// The sequence length the caller intends to train at — the same value they would pass as 'max_seq_len' when creating the run. Models that cannot serve it are reported as not enabled rather than returned with a ceiling the caller cannot use. Omit for the model's highest enabled sequence length.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_seq_len")]
        public int? MaxSeqLen { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLoopsCapabilitiesQueryParamsV1" /> class.
        /// </summary>
        /// <param name="model">
        /// Restrict the response to one model, identified by its HuggingFace repo id. A supported model comes back with its 'enabled' flag and, when false, its 'enablement_details'. An empty list means Baseten does not support that model. Omit to list every supported model.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="useCase">
        /// What the caller intends to run. Defaults to 'rl', the stricter of the two: an RL run needs both a trainer and a sampler, so anything enabled for 'rl' is also enabled for 'sft'.<br/>
        /// Default Value: rl
        /// </param>
        /// <param name="maxSeqLen">
        /// The sequence length the caller intends to train at — the same value they would pass as 'max_seq_len' when creating the run. Models that cannot serve it are reported as not enabled rather than returned with a ceiling the caller cannot use. Omit for the model's highest enabled sequence length.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetLoopsCapabilitiesQueryParamsV1(
            string? model,
            global::Baseten.LoopsUseCaseV1? useCase,
            int? maxSeqLen)
        {
            this.Model = model;
            this.UseCase = useCase;
            this.MaxSeqLen = maxSeqLen;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLoopsCapabilitiesQueryParamsV1" /> class.
        /// </summary>
        public GetLoopsCapabilitiesQueryParamsV1()
        {
        }

    }
}