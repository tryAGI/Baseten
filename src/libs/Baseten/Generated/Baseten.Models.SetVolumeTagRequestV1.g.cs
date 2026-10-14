
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SetVolumeTagRequestV1
    {
        /// <summary>
        /// Name of the tag to set. Tags are case-sensitive. Setting a tag that already exists overwrites it, and the version it pointed at before stays reachable by digest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tag")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Tag { get; set; }

        /// <summary>
        /// Version to set the tag on. Address it with `:&lt;tag&gt;` for a tag, `@&lt;digest&gt;` for a full content digest or a prefix of at least 12 hexadecimal characters, or `head` for the version a reference with no tag or digest resolves to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Version { get; set; }

        /// <summary>
        /// Time at which the tag expires, in ISO 8601 format, with a UTC offset. It must be in the future and at most ten years ahead. Omit it for a tag with no expiration time of its own. Omitting it also clears the expiration time of an existing tag. Version or volume expiration still deletes the tag. Do not specify it when setting `head`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Revision the volume is expected to be at. When set, the request fails with a conflict if the volume has changed since. Take the value from volume_sequence.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expected_sequence")]
        public int? ExpectedSequence { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SetVolumeTagRequestV1" /> class.
        /// </summary>
        /// <param name="tag">
        /// Name of the tag to set. Tags are case-sensitive. Setting a tag that already exists overwrites it, and the version it pointed at before stays reachable by digest.
        /// </param>
        /// <param name="version">
        /// Version to set the tag on. Address it with `:&lt;tag&gt;` for a tag, `@&lt;digest&gt;` for a full content digest or a prefix of at least 12 hexadecimal characters, or `head` for the version a reference with no tag or digest resolves to.
        /// </param>
        /// <param name="expiresAt">
        /// Time at which the tag expires, in ISO 8601 format, with a UTC offset. It must be in the future and at most ten years ahead. Omit it for a tag with no expiration time of its own. Omitting it also clears the expiration time of an existing tag. Version or volume expiration still deletes the tag. Do not specify it when setting `head`.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="expectedSequence">
        /// Revision the volume is expected to be at. When set, the request fails with a conflict if the volume has changed since. Take the value from volume_sequence.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SetVolumeTagRequestV1(
            string tag,
            string version,
            global::System.DateTime? expiresAt,
            int? expectedSequence)
        {
            this.Tag = tag ?? throw new global::System.ArgumentNullException(nameof(tag));
            this.Version = version ?? throw new global::System.ArgumentNullException(nameof(version));
            this.ExpiresAt = expiresAt;
            this.ExpectedSequence = expectedSequence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SetVolumeTagRequestV1" /> class.
        /// </summary>
        public SetVolumeTagRequestV1()
        {
        }

    }
}