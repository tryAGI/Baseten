
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Every version of a volume, newest first.<br/>
    /// Unpaginated: `limit` and `cursor` are absent rather than accepted and<br/>
    /// ignored, so adding them once the volume service pages this listing is a<br/>
    /// purely additive change.
    /// </summary>
    public sealed partial class ListVolumeVersionsResponseV1
    {
        /// <summary>
        /// Versions of the volume, newest first.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("versions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.VolumeVersionV1> Versions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVolumeVersionsResponseV1" /> class.
        /// </summary>
        /// <param name="versions">
        /// Versions of the volume, newest first.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListVolumeVersionsResponseV1(
            global::System.Collections.Generic.IList<global::Baseten.VolumeVersionV1> versions)
        {
            this.Versions = versions ?? throw new global::System.ArgumentNullException(nameof(versions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListVolumeVersionsResponseV1" /> class.
        /// </summary>
        public ListVolumeVersionsResponseV1()
        {
        }

    }
}