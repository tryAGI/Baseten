
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A model's current serverless Loops prices for this workspace, in USD per million tokens.<br/>
    /// Prices come from the workspace's plan, so they include its price overrides. A meter the plan<br/>
    /// does not price is null.
    /// </summary>
    public sealed partial class LoopsServerlessPricingV1
    {
        /// <summary>
        /// USD per million prompt tokens that miss the prefix cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_per_million_uncached_prefill_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>))]
        public global::Baseten.AnyOf<double?, string>? CostPerMillionUncachedPrefillTokens { get; set; }

        /// <summary>
        /// USD per million prompt tokens served from the prefix cache.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_per_million_cached_prefill_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>))]
        public global::Baseten.AnyOf<double?, string>? CostPerMillionCachedPrefillTokens { get; set; }

        /// <summary>
        /// USD per million tokens the sampler generates.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_per_million_sample_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>))]
        public global::Baseten.AnyOf<double?, string>? CostPerMillionSampleTokens { get; set; }

        /// <summary>
        /// USD per million tokens the trainer processes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cost_per_million_train_tokens")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.AnyOfJsonConverter<double?, string>))]
        public global::Baseten.AnyOf<double?, string>? CostPerMillionTrainTokens { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsServerlessPricingV1" /> class.
        /// </summary>
        /// <param name="costPerMillionUncachedPrefillTokens">
        /// USD per million prompt tokens that miss the prefix cache.
        /// </param>
        /// <param name="costPerMillionCachedPrefillTokens">
        /// USD per million prompt tokens served from the prefix cache.
        /// </param>
        /// <param name="costPerMillionSampleTokens">
        /// USD per million tokens the sampler generates.
        /// </param>
        /// <param name="costPerMillionTrainTokens">
        /// USD per million tokens the trainer processes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoopsServerlessPricingV1(
            global::Baseten.AnyOf<double?, string>? costPerMillionUncachedPrefillTokens,
            global::Baseten.AnyOf<double?, string>? costPerMillionCachedPrefillTokens,
            global::Baseten.AnyOf<double?, string>? costPerMillionSampleTokens,
            global::Baseten.AnyOf<double?, string>? costPerMillionTrainTokens)
        {
            this.CostPerMillionUncachedPrefillTokens = costPerMillionUncachedPrefillTokens;
            this.CostPerMillionCachedPrefillTokens = costPerMillionCachedPrefillTokens;
            this.CostPerMillionSampleTokens = costPerMillionSampleTokens;
            this.CostPerMillionTrainTokens = costPerMillionTrainTokens;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopsServerlessPricingV1" /> class.
        /// </summary>
        public LoopsServerlessPricingV1()
        {
        }

    }
}