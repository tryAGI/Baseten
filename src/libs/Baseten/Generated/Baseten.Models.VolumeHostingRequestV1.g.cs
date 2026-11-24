
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Selects the hosting a volume request addresses.
    /// </summary>
    public sealed partial class VolumeHostingRequestV1
    {
        /// <summary>
        /// Where the volumes are stored. Defaults to your organization's hosting when it has one, and is required when it has more than one.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hosting")]
        public global::Baseten.VolumeHostingV1? Hosting { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeHostingRequestV1" /> class.
        /// </summary>
        /// <param name="hosting">
        /// Where the volumes are stored. Defaults to your organization's hosting when it has one, and is required when it has more than one.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VolumeHostingRequestV1(
            global::Baseten.VolumeHostingV1? hosting)
        {
            this.Hosting = hosting;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeHostingRequestV1" /> class.
        /// </summary>
        public VolumeHostingRequestV1()
        {
        }

    }
}