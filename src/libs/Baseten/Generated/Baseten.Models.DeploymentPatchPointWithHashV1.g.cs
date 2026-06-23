
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A patch point plus its server-assigned content hash, returned in responses.<br/>
    /// Requests omit the hash (the server derives it from the source state); responses<br/>
    /// include it so the watch client can echo it back as the next patch's<br/>
    /// `prev_patch_hash` without having to recompute the fold itself.
    /// </summary>
    public sealed partial class DeploymentPatchPointWithHashV1
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
        /// Content hash identifying this exact source state, and the link patches build on. It is derived deterministically from `content_hashes`, so a request need not send it - the server derives it. It is derived by sorting the `content_hashes` keys as paths, splitting each key on '/' into its path components and ordering the keys by comparing those component lists element by element, each component compared by Unicode code point (equivalently UTF-8 byte order). Treating '/' as a path separator this way, rather than as the ordinary character U+002F, means a key that is an ancestor path sorts before a sibling whose name extends the first differing component (so e.g. 'a/b' sorts before 'a.b'). A blake3 hasher is then built, and for each key in that order updated with the blake3 digest (32 raw bytes) of the key encoded as UTF-8, then, when the entry is a file (non-null value), with that file's digest as 32 raw bytes. The stream uses raw digest bytes, but the values in `content_hashes` are those digests hex-encoded (64 hex chars), so decode each value from hex first. Directory entries (null value) contribute only their key digest. The result is the hasher's own hex digest.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hash")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Hash { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentPatchPointWithHashV1" /> class.
        /// </summary>
        /// <param name="contentHashes">
        /// Map of every non-ignored source path, relative and forward-slash, to its content hash: files map to the hex blake3 digest of their bytes, directories map to null. This is the full signature of the source tree and what the content hash is derived from.
        /// </param>
        /// <param name="config">
        /// The verbatim config.yaml text for this source state.
        /// </param>
        /// <param name="hash">
        /// Content hash identifying this exact source state, and the link patches build on. It is derived deterministically from `content_hashes`, so a request need not send it - the server derives it. It is derived by sorting the `content_hashes` keys as paths, splitting each key on '/' into its path components and ordering the keys by comparing those component lists element by element, each component compared by Unicode code point (equivalently UTF-8 byte order). Treating '/' as a path separator this way, rather than as the ordinary character U+002F, means a key that is an ancestor path sorts before a sibling whose name extends the first differing component (so e.g. 'a/b' sorts before 'a.b'). A blake3 hasher is then built, and for each key in that order updated with the blake3 digest (32 raw bytes) of the key encoded as UTF-8, then, when the entry is a file (non-null value), with that file's digest as 32 raw bytes. The stream uses raw digest bytes, but the values in `content_hashes` are those digests hex-encoded (64 hex chars), so decode each value from hex first. Directory entries (null value) contribute only their key digest. The result is the hasher's own hex digest.
        /// </param>
        /// <param name="requirements">
        /// Requirements resolved from the config's requirements file, when it points at one. Empty when requirements are declared inline in the config.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeploymentPatchPointWithHashV1(
            object contentHashes,
            string config,
            string hash,
            global::System.Collections.Generic.IList<string>? requirements)
        {
            this.ContentHashes = contentHashes ?? throw new global::System.ArgumentNullException(nameof(contentHashes));
            this.Config = config ?? throw new global::System.ArgumentNullException(nameof(config));
            this.Requirements = requirements;
            this.Hash = hash ?? throw new global::System.ArgumentNullException(nameof(hash));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeploymentPatchPointWithHashV1" /> class.
        /// </summary>
        public DeploymentPatchPointWithHashV1()
        {
        }

    }
}