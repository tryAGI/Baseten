
#nullable enable

namespace Baseten
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxImageBuildLogsResponseV1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("logs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Baseten.SandboxImageBuildLogV1> Logs { get; set; }

        /// <summary>
        /// Number of matching log entries in the requested time range.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long TotalCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxImageBuildLogsResponseV1" /> class.
        /// </summary>
        /// <param name="logs"></param>
        /// <param name="totalCount">
        /// Number of matching log entries in the requested time range.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxImageBuildLogsResponseV1(
            global::System.Collections.Generic.IList<global::Baseten.SandboxImageBuildLogV1> logs,
            long totalCount)
        {
            this.Logs = logs ?? throw new global::System.ArgumentNullException(nameof(logs));
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxImageBuildLogsResponseV1" /> class.
        /// </summary>
        public SandboxImageBuildLogsResponseV1()
        {
        }

    }
}