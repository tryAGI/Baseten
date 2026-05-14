
#nullable enable

namespace Baseten
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class GroupMetadataV1
    {
        /// <summary>
        /// Optional display name for the group.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// External-system identifier for this group. Unique within the caller's org.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_entity_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ExternalEntityId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupMetadataV1" /> class.
        /// </summary>
        /// <param name="externalEntityId">
        /// External-system identifier for this group. Unique within the caller's org.
        /// </param>
        /// <param name="name">
        /// Optional display name for the group.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroupMetadataV1(
            string externalEntityId,
            string? name)
        {
            this.Name = name;
            this.ExternalEntityId = externalEntityId ?? throw new global::System.ArgumentNullException(nameof(externalEntityId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupMetadataV1" /> class.
        /// </summary>
        public GroupMetadataV1()
        {
        }

    }
}