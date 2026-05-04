
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateTrainerServerRequestV1
    {
        /// <summary>
        /// Base model ID (e.g. 'Qwen/Qwen3-8B').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// Maximum sequence length for training.<br/>
        /// Default Value: 32768
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_seq_len")]
        public int? MaxSeqLen { get; set; }

        /// <summary>
        /// LoRA rank.<br/>
        /// Default Value: 16
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lora_rank")]
        public int? LoraRank { get; set; }

        /// <summary>
        /// Random seed for reproducibility.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("seed")]
        public int? Seed { get; set; }

        /// <summary>
        /// Seconds of inactivity before the trainer scales to zero. Must be positive. Defaults to 3600 (1 hour).<br/>
        /// Default Value: 3600
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_down_delay_seconds")]
        public int? ScaleDownDelaySeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrainerServerRequestV1" /> class.
        /// </summary>
        /// <param name="model">
        /// Base model ID (e.g. 'Qwen/Qwen3-8B').
        /// </param>
        /// <param name="maxSeqLen">
        /// Maximum sequence length for training.<br/>
        /// Default Value: 32768
        /// </param>
        /// <param name="loraRank">
        /// LoRA rank.<br/>
        /// Default Value: 16
        /// </param>
        /// <param name="seed">
        /// Random seed for reproducibility.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="scaleDownDelaySeconds">
        /// Seconds of inactivity before the trainer scales to zero. Must be positive. Defaults to 3600 (1 hour).<br/>
        /// Default Value: 3600
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateTrainerServerRequestV1(
            string model,
            int? maxSeqLen,
            int? loraRank,
            int? seed,
            int? scaleDownDelaySeconds)
        {
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.MaxSeqLen = maxSeqLen;
            this.LoraRank = loraRank;
            this.Seed = seed;
            this.ScaleDownDelaySeconds = scaleDownDelaySeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTrainerServerRequestV1" /> class.
        /// </summary>
        public CreateTrainerServerRequestV1()
        {
        }
    }
}