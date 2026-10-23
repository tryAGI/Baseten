
#nullable enable

namespace Baseten
{
    /// <summary>
    /// Filesystem configuration of a sandbox. The sandbox filesystem is held in memory, so files written count against the sandbox memory.
    /// </summary>
    public sealed partial class SandboxFilesystemV1
    {
        /// <summary>
        /// Maximum memory the filesystem can use, as a percentage of the sandbox memory (e.g. "80%"), a size (e.g. "2Gi") or a number of Mi (e.g. 2048). Defaults to 50%.<br/>
        /// Example: 80%
        /// </summary>
        /// <example>80%</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_memory_usage")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Baseten.JsonConverters.OneOfJsonConverter<string, int?>))]
        public global::Baseten.OneOf<string, int?>? MaxMemoryUsage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxFilesystemV1" /> class.
        /// </summary>
        /// <param name="maxMemoryUsage">
        /// Maximum memory the filesystem can use, as a percentage of the sandbox memory (e.g. "80%"), a size (e.g. "2Gi") or a number of Mi (e.g. 2048). Defaults to 50%.<br/>
        /// Example: 80%
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxFilesystemV1(
            global::Baseten.OneOf<string, int?>? maxMemoryUsage)
        {
            this.MaxMemoryUsage = maxMemoryUsage;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxFilesystemV1" /> class.
        /// </summary>
        public SandboxFilesystemV1()
        {
        }

    }
}