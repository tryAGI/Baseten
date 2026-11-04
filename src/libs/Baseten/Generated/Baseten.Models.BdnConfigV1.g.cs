
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BdnConfigV1
    {
        /// <summary>
        /// The BDN volume versions to mount.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mounts")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.BdnVolumeMountV1> Mounts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BdnConfigV1" /> class.
        /// </summary>
        /// <param name="mounts">
        /// The BDN volume versions to mount.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BdnConfigV1(
            global::System.Collections.Generic.IList<global::Baseten.BdnVolumeMountV1> mounts)
        {
            this.Mounts = mounts ?? throw new global::System.ArgumentNullException(nameof(mounts));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BdnConfigV1" /> class.
        /// </summary>
        public BdnConfigV1()
        {
        }

    }
}