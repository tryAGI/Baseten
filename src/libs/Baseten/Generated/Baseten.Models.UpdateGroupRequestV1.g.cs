
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateGroupRequestV1
    {
        /// <summary>
        /// Mutable group metadata.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Baseten.UpdateGroupMetadataV1? Metadata { get; set; }

        /// <summary>
        /// Per-model rate and usage limit configuration.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        public global::System.Collections.Generic.IList<global::Baseten.ModelConfigV1>? Models { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGroupRequestV1" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Mutable group metadata.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="models">
        /// Per-model rate and usage limit configuration.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateGroupRequestV1(
            global::Baseten.UpdateGroupMetadataV1? metadata,
            global::System.Collections.Generic.IList<global::Baseten.ModelConfigV1>? models)
        {
            this.Metadata = metadata;
            this.Models = models;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGroupRequestV1" /> class.
        /// </summary>
        public UpdateGroupRequestV1()
        {
        }

    }
}