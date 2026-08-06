
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Query-string filters for the Loops sampler listing routes.
    /// </summary>
    public sealed partial class ListLoopsSamplersRequestV1
    {
        /// <summary>
        /// Defaults to the caller's own samplers; pass 'org' to include samplers owned by other users in the caller's organization.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        public string? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListLoopsSamplersRequestV1" /> class.
        /// </summary>
        /// <param name="scope">
        /// Defaults to the caller's own samplers; pass 'org' to include samplers owned by other users in the caller's organization.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListLoopsSamplersRequestV1(
            string? scope)
        {
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListLoopsSamplersRequestV1" /> class.
        /// </summary>
        public ListLoopsSamplersRequestV1()
        {
        }

    }
}