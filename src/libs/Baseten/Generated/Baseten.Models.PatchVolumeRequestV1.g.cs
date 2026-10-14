
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PatchVolumeRequestV1
    {
        /// <summary>
        /// Time at which the volume expires, in ISO 8601 format, with a UTC offset. It must be in the future and at most ten years ahead. Set it to null to clear the expiration time. A body that sets no field is rejected. When the volume expires, all live versions are deleted, all tags are removed, and the volume disappears from listings. Clearing the expiration time afterward does not restore deleted versions. Each deleted version can be restored until its delete_after time. Setting or clearing the expiration time requires the same permission as deleting the volume.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Revision the volume is expected to be at. When set, the update fails with a conflict if the volume has changed since. Take the value from a volume's sequence, or from volume_sequence.<br/>
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
        /// Initializes a new instance of the <see cref="PatchVolumeRequestV1" /> class.
        /// </summary>
        /// <param name="expiresAt">
        /// Time at which the volume expires, in ISO 8601 format, with a UTC offset. It must be in the future and at most ten years ahead. Set it to null to clear the expiration time. A body that sets no field is rejected. When the volume expires, all live versions are deleted, all tags are removed, and the volume disappears from listings. Clearing the expiration time afterward does not restore deleted versions. Each deleted version can be restored until its delete_after time. Setting or clearing the expiration time requires the same permission as deleting the volume.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="expectedSequence">
        /// Revision the volume is expected to be at. When set, the update fails with a conflict if the volume has changed since. Take the value from a volume's sequence, or from volume_sequence.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PatchVolumeRequestV1(
            global::System.DateTime? expiresAt,
            int? expectedSequence)
        {
            this.ExpiresAt = expiresAt;
            this.ExpectedSequence = expectedSequence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatchVolumeRequestV1" /> class.
        /// </summary>
        public PatchVolumeRequestV1()
        {
        }

    }
}