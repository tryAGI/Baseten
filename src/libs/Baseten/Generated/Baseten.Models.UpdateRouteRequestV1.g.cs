
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateRouteRequestV1
    {
        /// <summary>
        /// New description. Omit to keep the current description; use an empty string to clear it. Null is not accepted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// New display label. Omit to keep the current label; null is not accepted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("display_name")]
        public string? DisplayName { get; set; }

        /// <summary>
        /// Replaces the entire target. Omit to keep the current target; null is not accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("target")]
        public global::Baseten.TargetVariant1? Target { get; set; }

        /// <summary>
        /// Slug of a metadata row to link. Omit to keep the current link, or to re-resolve from the new target when target is provided (OPENAI_COMPATIBLE and VERTEX targets always require an explicit slug). Null is not accepted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata_slug")]
        public string? MetadataSlug { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRouteRequestV1" /> class.
        /// </summary>
        /// <param name="description">
        /// New description. Omit to keep the current description; use an empty string to clear it. Null is not accepted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="displayName">
        /// New display label. Omit to keep the current label; null is not accepted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="target">
        /// Replaces the entire target. Omit to keep the current target; null is not accepted.
        /// </param>
        /// <param name="metadataSlug">
        /// Slug of a metadata row to link. Omit to keep the current link, or to re-resolve from the new target when target is provided (OPENAI_COMPATIBLE and VERTEX targets always require an explicit slug). Null is not accepted.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateRouteRequestV1(
            string? description,
            string? displayName,
            global::Baseten.TargetVariant1? target,
            string? metadataSlug)
        {
            this.Description = description;
            this.DisplayName = displayName;
            this.Target = target;
            this.MetadataSlug = metadataSlug;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRouteRequestV1" /> class.
        /// </summary>
        public UpdateRouteRequestV1()
        {
        }

    }
}