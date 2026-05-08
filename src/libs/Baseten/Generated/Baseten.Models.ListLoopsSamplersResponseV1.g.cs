
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Response for ``GET /v1/loops/samplers``.<br/>
    /// Returns the caller's samplers, including those paired to runs and<br/>
    /// standalone samplers. Ordered newest-first.
    /// </summary>
    public sealed partial class ListLoopsSamplersResponseV1
    {
        /// <summary>
        /// List of samplers.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("samplers")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.LoopsSamplerV1> Samplers { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListLoopsSamplersResponseV1" /> class.
        /// </summary>
        /// <param name="samplers">
        /// List of samplers.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListLoopsSamplersResponseV1(
            global::System.Collections.Generic.IList<global::Baseten.LoopsSamplerV1> samplers)
        {
            this.Samplers = samplers ?? throw new global::System.ArgumentNullException(nameof(samplers));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListLoopsSamplersResponseV1" /> class.
        /// </summary>
        public ListLoopsSamplersResponseV1()
        {
        }
    }
}