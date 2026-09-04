
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListVolumeVersionsRequestV1
    {
        /// <summary>
        /// Whether to include deleted versions. A deleted version carries a TOMBSTONED lifecycle and stays restorable until its recovery deadline passes.<br/>
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
        /// <param name="includeTombstoned">
        /// Whether to include deleted versions. A deleted version carries a TOMBSTONED lifecycle and stays restorable until its recovery deadline passes.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListVolumeVersionsRequestV1(
            bool? includeTombstoned)
        {
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