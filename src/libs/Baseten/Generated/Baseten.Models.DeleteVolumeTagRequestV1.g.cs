
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeleteVolumeTagRequestV1
    {
        /// <summary>
        /// Where the volumes are stored. Defaults to your organization's hosting when it has one, and is required when it has more than one.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hosting")]
        public global::Baseten.VolumeHostingV1? Hosting { get; set; }

        /// <summary>
        /// Revision the volume is expected to be at. When set, the delete fails with a conflict if the volume has changed since, so it cannot delete a tag someone else has just set on another version. Take the value from volume_sequence.<br/>
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
        /// Initializes a new instance of the <see cref="DeleteVolumeTagRequestV1" /> class.
        /// </summary>
        /// <param name="hosting">
        /// Where the volumes are stored. Defaults to your organization's hosting when it has one, and is required when it has more than one.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="expectedSequence">
        /// Revision the volume is expected to be at. When set, the delete fails with a conflict if the volume has changed since, so it cannot delete a tag someone else has just set on another version. Take the value from volume_sequence.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeleteVolumeTagRequestV1(
            global::Baseten.VolumeHostingV1? hosting,
            int? expectedSequence)
        {
            this.Hosting = hosting;
            this.ExpectedSequence = expectedSequence;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteVolumeTagRequestV1" /> class.
        /// </summary>
        public DeleteVolumeTagRequestV1()
        {
        }

    }
}