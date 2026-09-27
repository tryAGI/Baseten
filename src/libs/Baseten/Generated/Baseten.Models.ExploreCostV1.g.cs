
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExploreCostV1
    {
        /// <summary>
        /// USD per 1M input tokens, when available.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public double? Input { get; set; }

        /// <summary>
        /// USD per 1M output tokens, when available.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output")]
        public double? Output { get; set; }

        /// <summary>
        /// USD per 1M input tokens read from cache, when available.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_read")]
        public double? CacheRead { get; set; }

        /// <summary>
        /// USD per 1M input tokens written to cache, when available.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cache_write")]
        public double? CacheWrite { get; set; }

        /// <summary>
        /// Prices for long-context requests, when the provider tiers by context length.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("long_context")]
        public global::Baseten.ExploreCostValuesV1? LongContext { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExploreCostV1" /> class.
        /// </summary>
        /// <param name="input">
        /// USD per 1M input tokens, when available.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="output">
        /// USD per 1M output tokens, when available.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cacheRead">
        /// USD per 1M input tokens read from cache, when available.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="cacheWrite">
        /// USD per 1M input tokens written to cache, when available.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="longContext">
        /// Prices for long-context requests, when the provider tiers by context length.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExploreCostV1(
            double? input,
            double? output,
            double? cacheRead,
            double? cacheWrite,
            global::Baseten.ExploreCostValuesV1? longContext)
        {
            this.Input = input;
            this.Output = output;
            this.CacheRead = cacheRead;
            this.CacheWrite = cacheWrite;
            this.LongContext = longContext;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExploreCostV1" /> class.
        /// </summary>
        public ExploreCostV1()
        {
        }

    }
}