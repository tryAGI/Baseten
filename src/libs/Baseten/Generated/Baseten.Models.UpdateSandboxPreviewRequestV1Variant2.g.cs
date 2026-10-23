
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateSandboxPreviewRequestV1Variant2
    {
        /// <summary>
        /// Lifetime counted from the request, using seconds, minutes, hours or composite durations such as 1h30m. Whole days are also supported, for example 7d; days cannot be combined with other units. The preview is deleted when it elapses.<br/>
        /// Example: 24h
        /// </summary>
        /// <example>24h</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("ttl")]
        public string? Ttl { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSandboxPreviewRequestV1Variant2" /> class.
        /// </summary>
        /// <param name="ttl">
        /// Lifetime counted from the request, using seconds, minutes, hours or composite durations such as 1h30m. Whole days are also supported, for example 7d; days cannot be combined with other units. The preview is deleted when it elapses.<br/>
        /// Example: 24h
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateSandboxPreviewRequestV1Variant2(
            string? ttl)
        {
            this.Ttl = ttl;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSandboxPreviewRequestV1Variant2" /> class.
        /// </summary>
        public UpdateSandboxPreviewRequestV1Variant2()
        {
        }

    }
}