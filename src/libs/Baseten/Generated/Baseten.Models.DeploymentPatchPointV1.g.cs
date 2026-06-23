
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A patch point: the source state the next patch is computed against.<br/>
    /// The content hash that identifies a point is derived from this state (see<br/>
    /// `DeploymentPatchPointWithHashV1.hash`), so a request only sends the state and<br/>
    /// the server stamps the hash. A previous point's hash plus the current local<br/>
    /// source is enough to compute the next patch, so the watch client reads the<br/>
    /// point it is patching off of.
    /// </summary>
    public sealed partial class DeploymentPatchPointV1
    {
        /// <summary>
        /// Map of every non-ignored source path, relative and forward-slash, to its content hash: files map to the hex blake3 digest of their bytes, directories map to null. This is the full signature of the source tree and what the content hash is derived from.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_hashes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ContentHashes { get; set; }

        /// <summary>
        /// The verbatim config.yaml text for this source state.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("config")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Config { get; set; }

        /// <summary>
        /// Requirements resolved from the config's requirements file, when it points at one. Empty when requirements are declared inline in the config.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requirements")]
        public global::System.Collections.Generic.IList<string>? Requirements { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentPatchPointV1" /> class.
        /// </summary>
        /// <param name="contentHashes">
        /// Map of every non-ignored source path, relative and forward-slash, to its content hash: files map to the hex blake3 digest of their bytes, directories map to null. This is the full signature of the source tree and what the content hash is derived from.
        /// </param>
        /// <param name="config">
        /// The verbatim config.yaml text for this source state.
        /// </param>
        /// <param name="requirements">
        /// Requirements resolved from the config's requirements file, when it points at one. Empty when requirements are declared inline in the config.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentPatchPointV1(
            object contentHashes,
            string config,
            global::System.Collections.Generic.IList<string>? requirements)
        {
            this.ContentHashes = contentHashes ?? throw new global::System.ArgumentNullException(nameof(contentHashes));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Requirements = requirements;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentPatchPointV1" /> class.
        /// </summary>
        public DeploymentPatchPointV1()
        {
        }

    }
}