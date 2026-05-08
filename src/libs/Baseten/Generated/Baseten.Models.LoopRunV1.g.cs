
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LoopRunV1
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("base_url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string BaseUrl { get; set; }

        /// <summary>
        /// The sampler bound to this run.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampler")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.LoopSamplerV1 Sampler { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopRunV1" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="baseUrl"></param>
        /// <param name="sampler">
        /// The sampler bound to this run.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LoopRunV1(
            string id,
            string baseUrl,
            global::Baseten.LoopSamplerV1 sampler)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.BaseUrl = baseUrl ?? throw new global::System.ArgumentNullException(nameof(baseUrl));
            this.Sampler = sampler ?? throw new global::System.ArgumentNullException(nameof(sampler));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LoopRunV1" /> class.
        /// </summary>
        public LoopRunV1()
        {
        }
    }
}