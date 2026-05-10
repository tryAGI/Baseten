
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response for ``GET /v1/loops/samplers/&lt;sampler_id&gt;``.
    /// </summary>
    public sealed partial class GetLoopsSamplerResponseV1
    {
        /// <summary>
        /// The Loops sampler.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sampler")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Baseten.LoopsSamplerV1 Sampler { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLoopsSamplerResponseV1" /> class.
        /// </summary>
        /// <param name="sampler">
        /// The Loops sampler.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetLoopsSamplerResponseV1(
            global::Baseten.LoopsSamplerV1 sampler)
        {
            this.Sampler = sampler ?? throw new global::System.ArgumentNullException(nameof(sampler));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetLoopsSamplerResponseV1" /> class.
        /// </summary>
        public GetLoopsSamplerResponseV1()
        {
        }

    }
}