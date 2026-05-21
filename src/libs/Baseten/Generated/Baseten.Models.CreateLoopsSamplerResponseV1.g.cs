
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateLoopsSamplerResponseV1
    {
        /// <summary>
        /// 
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
        /// Initializes a new instance of the <see cref="CreateLoopsSamplerResponseV1" /> class.
        /// </summary>
        /// <param name="sampler"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateLoopsSamplerResponseV1(
            global::Baseten.LoopsSamplerV1 sampler)
        {
            this.Sampler = sampler ?? throw new global::System.ArgumentNullException(nameof(sampler));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateLoopsSamplerResponseV1" /> class.
        /// </summary>
        public CreateLoopsSamplerResponseV1()
        {
        }

    }
}