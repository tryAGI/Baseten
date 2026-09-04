
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeleteVolumeVersionRequestV1
    {
        /// <summary>
        /// Revision the volume is expected to be at. When set, the delete fails with a conflict if the volume has changed since, so a read followed by a delete cannot act on a version a tag has since been moved off. Take the value from volume_sequence.<br/>
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
        /// Initializes a new instance of the <see cref="DeleteVolumeVersionRequestV1" /> class.
        /// </summary>
        /// <param name="expectedSequence">
        /// Revision the volume is expected to be at. When set, the delete fails with a conflict if the volume has changed since, so a read followed by a delete cannot act on a version a tag has since been moved off. Take the value from volume_sequence.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteVolumeVersionRequestV1(
            int? expectedSequence)
        {
            this.ExpectedSequence = expectedSequence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteVolumeVersionRequestV1" /> class.
        /// </summary>
        public DeleteVolumeVersionRequestV1()
        {
        }

    }
}