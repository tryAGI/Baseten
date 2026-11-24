
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListVolumeVersionsRequestV1
    {
        /// <summary>
        /// Where the volumes are stored. Defaults to your organization's hosting when it has one, and is required when it has more than one.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hosting")]
        public global::Baseten.VolumeHostingV1? Hosting { get; set; }

        /// <summary>
        /// Whether to include deleted and expired versions. Such a version carries a TOMBSTONED lifecycle and stays restorable until its recovery deadline passes.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("include_tombstoned")]
        public bool? IncludeTombstoned { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVolumeVersionsRequestV1" /> class.
        /// </summary>
        /// <param name="hosting">
        /// Where the volumes are stored. Defaults to your organization's hosting when it has one, and is required when it has more than one.<br/>
        /// Default Value: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="includeTombstoned">
        /// Whether to include deleted and expired versions. Such a version carries a TOMBSTONED lifecycle and stays restorable until its recovery deadline passes.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListVolumeVersionsRequestV1(
            global::Baseten.VolumeHostingV1? hosting,
            bool? includeTombstoned)
        {
            this.Hosting = hosting;
            this.IncludeTombstoned = includeTombstoned;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVolumeVersionsRequestV1" /> class.
        /// </summary>
        public ListVolumeVersionsRequestV1()
        {
        }

    }
}