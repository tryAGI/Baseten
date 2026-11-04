
#nullable enable

namespace Baseten
{
    /// <summary>
    /// A BDN volume version mounted read-only in the frontend and worker.
    /// </summary>
    public sealed partial class BdnVolumeMountV1
    {
        /// <summary>
        /// The volume version to mount: bdn:&lt;namespace&gt;/&lt;volume&gt;, optionally followed by :&lt;tag&gt; or @b3:&lt;digest&gt;.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Source { get; set; }

        /// <summary>
        /// Where to mount it: /models/&lt;name&gt;, with &lt;name&gt; a single path segment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BdnVolumeMountV1" /> class.
        /// </summary>
        /// <param name="source">
        /// The volume version to mount: bdn:&lt;namespace&gt;/&lt;volume&gt;, optionally followed by :&lt;tag&gt; or @b3:&lt;digest&gt;.
        /// </param>
        /// <param name="path">
        /// Where to mount it: /models/&lt;name&gt;, with &lt;name&gt; a single path segment.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BdnVolumeMountV1(
            string source,
            string path)
        {
            this.Source = source ?? throw new global::System.ArgumentNullException(nameof(source));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BdnVolumeMountV1" /> class.
        /// </summary>
        public BdnVolumeMountV1()
        {
        }

    }
}