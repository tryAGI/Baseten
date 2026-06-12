
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Workspace-specific state for a Model API.
    /// </summary>
    public sealed partial class ModelAPIOrgDetailsV1
    {
        /// <summary>
        /// When the workspace first added this Model API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTime AddedAt { get; set; }

        /// <summary>
        /// When the workspace last invoked this Model API. Null if the workspace has never invoked it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_used_at")]
        public global::System.DateTime? LastUsedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelAPIOrgDetailsV1" /> class.
        /// </summary>
        /// <param name="addedAt">
        /// When the workspace first added this Model API.
        /// </param>
        /// <param name="lastUsedAt">
        /// When the workspace last invoked this Model API. Null if the workspace has never invoked it.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelAPIOrgDetailsV1(
            global::System.DateTime addedAt,
            global::System.DateTime? lastUsedAt)
        {
            this.AddedAt = addedAt;
            this.LastUsedAt = lastUsedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelAPIOrgDetailsV1" /> class.
        /// </summary>
        public ModelAPIOrgDetailsV1()
        {
        }

    }
}