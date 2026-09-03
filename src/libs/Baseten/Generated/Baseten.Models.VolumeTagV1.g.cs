
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class VolumeTagV1
    {
        /// <summary>
        /// Tag name. Tags are case-sensitive.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Digest of the version the tag points at, as `b3:&lt;hex&gt;`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("digest")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Digest { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeTagV1" /> class.
        /// </summary>
        /// <param name="name">
        /// Tag name. Tags are case-sensitive.
        /// </param>
        /// <param name="digest">
        /// Digest of the version the tag points at, as `b3:&lt;hex&gt;`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VolumeTagV1(
            string name,
            string digest)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Digest = digest ?? throw new global::System.ArgumentNullException(nameof(digest));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VolumeTagV1" /> class.
        /// </summary>
        public VolumeTagV1()
        {
        }

    }
}